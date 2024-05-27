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
    public partial class UCProductInCart : UserControl
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();

        string idUser = FLogin.instance.ID;
        byte[] imageData;
        public UCProductInCart()
        {
            InitializeComponent();
        }
        private string _name;
        private string _price;
        private double _total;
        private string _id;
        private int _quantity;
        private double _prices;
        private int _maxQuantity;

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
            set
            {
                _price = value;
                lblPrice.Text = _price.ToString() + '$';
            }
        }

        [Category("Custom Product")]
        public double Total
        {
            get { return _total; }
            set
            {
                _total = value;
                lblTotalPrice.Text = _total.ToString() + '$';
            }
        }

        [Category("Custom Product")]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value; nudQuantity.Value = value;
            }
        }

        [Category("Custom Product")]
        public double Prices
        {
            get { return _prices; }
            set { _prices = value; }
        }

        [Category("Custom Product")]
        public int MaxQuantity
        {
            get { return _maxQuantity; }
            set
            {
                _maxQuantity = value; nudQuantity.Maximum = value;
            }
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Delete From productInCart Where idProduct = '{0}' and idUser = '{1}'", ID, idUser);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    FHome.instance.FHome_Load(sender, e);
                    this.Hide();
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

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            double t = 0;
            t = Prices * (double)(nudQuantity.Value);
            Price = Prices.ToString();
            Quantity = (int)(nudQuantity.Value);
            Total = t;

            string sqlStr = string.Format("Update productInCart Set quantity = '{2}' Where idProduct = '{0}' and idUser = '{1}'", ID, idUser, nudQuantity.Value);
            db.thucThiUpdate(sqlStr);

            FHome.instance.CartOrder_Load();
        }

        private void UCProductInCart_Load(object sender, EventArgs e)
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
    }

}
