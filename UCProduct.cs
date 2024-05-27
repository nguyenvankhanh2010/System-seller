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
    public partial class UCProduct : UserControl
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        byte[] imageData;

        string IDUser = FLogin.instance.ID;
        public UCProduct()
        {
            InitializeComponent();
        }

        private string _name;
        private string _price;
        private string _id;
        private string _type;
        private string _oldPrice;
        private string _address;

        [Category("Custom Product")]
        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        [Category("Custom Product")]
        public string NamE
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }


        [Category("Custom Product")]
        public string Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }

        [Category("Custom Product")]
        public string OldPrice
        {
            get { return _oldPrice; }
            set { _oldPrice = value; lblOldPrice.Text = value; }
        }

        [Category("Custom Product")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        [Category("Custom Product")]
        public string Address
        {
            get { return _address; }
            set { _address = value; lblAddress.Text = value; }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FProductView product = new FProductView(ID);
            product.ShowDialog();
        }

        private void UCProduct_Click(object sender, EventArgs e)
        {
            FProductView product = new FProductView(ID);
            product.ShowDialog();
        }

        private void pnlAddToCart_Click(object sender, EventArgs e)
        {
            if (!checkID())
            {
                MessageBox.Show("Bạn là người bán sản phẩm này");
                return;
            }
            try
            {
                conn.Open();
                string sqlStr = string.Format("Insert into productInCart Values ('{0}', '{1}', '{2}')", ID, IDUser, 1);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    FMessageBox fMessageBox = new FMessageBox();
                    fMessageBox.ShowDialog();
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

        private void UCProduct_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select picProduct From ImageProduct Where idProduct = '{0}'", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    imageData = (byte[])(reader["picProduct"]);
                    panel1.BackgroundImage = convertByteToImage(imageData);
                    reader.Close();
                }
            }
            catch
            {

            }
            finally { conn.Close(); }
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

        private bool checkID()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select idSeller From inforProduct Where idProduct = '{0}'", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string s = reader.GetString(0);
                    reader.Close();
                    if (s == IDUser) return false;
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}
