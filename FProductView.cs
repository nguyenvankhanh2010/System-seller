using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoAnVer02
{
    public partial class FProductView : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        int imageIndex = 0;
        byte[] imageData;
        string decribe;
        string ID = FLogin.instance.ID;
        private string idProduct;
        List<ImageNDecribe> imgDS = new List<ImageNDecribe>();
        List<UCProduct> listProduct = new List<UCProduct>();
        List<ProductRate> listProductRate = new List<ProductRate>();
        int NumRate;
        int NumBuy;
        ImageNDecribe[] imgList;

        public FProductView(string idProduct)
        {
            InitializeComponent();
            this.idProduct = idProduct;
            getInfor();
            getImage();
        }

        private void pnlLogo_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            MessageBox.Show("" + idProduct);
            fHome.Show();
            this.Close();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!checkID())
            {
                MessageBox.Show("Bạn là người bán sản phẩm này");
                return;
            }
            try
            {
                conn.Open();
                string sqlStr = string.Format("Insert into productInCart Values ('{0}', '{1}', '{2}')", idProduct, ID, nudQuantity.Value);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    FMessageBox fMessageBox = new FMessageBox();
                    fMessageBox.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Loi ket noi CSDL");
            }
            finally
            {
                conn.Close();
            }
        }


        private Image convertByteToImage(byte[] byteArray)
        {
            if (byteArray != null)
            {
                MemoryStream ms = new MemoryStream(byteArray);
                Image returnIMG = Image.FromStream(ms);
                return returnIMG;
            }
            else
            {
                MessageBox.Show("Ko co Anh");
                return null;
            }
        }


        private void getImage()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select picProduct, decribeImage From ImageProduct Where idProduct = '{0}'", idProduct);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        imageData = (byte[])(reader["picProduct"]);
                        decribe = reader.GetString(1);
                        ImageNDecribe img = new ImageNDecribe(convertByteToImage(imageData), decribe);
                        imgDS.Add(img);
                    }
                    reader.Close();
                    imgList = imgDS.ToArray();
                }
            }
            catch
            {

            }
            finally { conn.Close(); }
        }

        private void imageVisible(int index)
        {
            for (int i = 0; i < imgList.Length; i++)
            {
                if (i == index)
                {
                    pnlProductView1.BackgroundImage = imgList[i].img;
                    lblDeInPic1.Text = imgList[i].decribe;
                }
            }
        }
        private void getInfor()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From inforProduct Where idProduct = '{0}'", idProduct);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Text = reader.GetString(2);
                        lblUser.Text = reader.GetString(1);
                        lblNameProduct1.Text = reader.GetString(2);
                        lblType.Text = reader.GetString(3);
                        lblRetail1.Text = reader.GetDouble(5).ToString() + '$';
                        lblResell1.Text = reader.GetDouble(6).ToString() + '$';
                        lblBrandProduct1.Text = reader.GetString(7);
                        lblDecribe1.Text = reader.GetString(8);
                        nudQuantity.Maximum = reader.GetInt32(4);
                        lblAddress.Text = reader.GetString(9);
                    }
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Loi ket noi CSDL");
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnNextPic_Click(object sender, EventArgs e)
        {
            if (imageIndex >= 0 && imageIndex < imgList.Length - 1)
            {
                imageIndex++;
            }
            else if (imageIndex == imgList.Length - 1)
            {
                imageIndex = 0;
            }
            FProductView_Load(sender, e);
        }

        private void btnBackPic_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0 && imageIndex <= imgList.Length - 1)
            {
                imageIndex--;
            }
            else if (imageIndex == 0)
            {
                imageIndex = imgList.Length - 1;
            }
            FProductView_Load(sender, e);
        }

        private void getProduct()
        {
            listProduct.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select idProduct, nameProduct, resellProduct, typeProduct, retailProduct, addressProduct From inforProduct Where quantityProduct > 0");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UCProduct product = new UCProduct();
                        product.ID = reader.GetString(0);
                        product.NamE = reader.GetString(1);
                        double price = reader.GetDouble(2);
                        product.Price = price.ToString() + '$';
                        product.Type = reader.GetString(3);
                        double oldPrice = reader.GetDouble(4);
                        product.OldPrice = oldPrice.ToString() + '$';
                        product.Address = reader.GetString(5);
                        product.pnlAddToCart.Visible = false;
                        listProduct.Add(product);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("KO co du lieu");
                }
            }
            catch
            {
                MessageBox.Show("Loi ket noi CSDL");
            }
            finally
            {
                conn.Close();
            }
            flpProduct.Controls.Clear();
            foreach (UCProduct product in listProduct)
            {
                if (product.Type == lblType.Text)
                {
                    flpProduct.Controls.Add(product);
                }
            }
        }
        private void FProductView_Load(object sender, EventArgs e)
        {
            imageVisible(imageIndex);
            getProduct();
            getRate();
            getNumPay();
        }

        private bool checkID()
        {
            if (ID == lblUser.Text)
            {
                return false;
            }
            return true;
        }
        private void getRate()
        {
            listProductRate.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select rateBuyer, daterate From rateProduct Where idProduct ='{0}'",idProduct);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductRate rate = new ProductRate();
                        rate.Date = reader.GetDateTime(1).ToString();
                        rate.Des = reader.GetString(0);
                        listProductRate.Add(rate);
                    }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi"+ex);
            }
            finally
            {
                conn.Close();
            }
            flbRate.Controls.Clear();
            foreach (ProductRate product in listProductRate)
            {   
                   flbRate.Controls.Add(product);

            }
            NumRate = listProductRate.Count;
            lblNumRate.Text = NumRate.ToString();
        }
        private void getNumPay()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT Count(DonHang.idProduct) \r\nFROM DonHang \r\nINNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct \r\nWHERE DonHang.tinhTrang = N'Đã giao' and DonHang.idProduct ='{0}'", idProduct);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumBuy.Text = reader.GetInt32(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
