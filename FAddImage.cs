using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoAnVer02
{
    public partial class FAddImage : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public Label label1;
        public FAddImage()
        {
            InitializeComponent();
            label1 = new Label();
            label1.Text = "";
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png|All files (*.*)|*.*";
            op.FilterIndex = 1;
            op.RestoreDirectory = true;
            if(op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = op.FileName;
                label1.Text = op.FileName;
            }    
 
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            //if(!checkProduct()) return;
            try
            {
                conn.Open();
                string strCon = "insert into ImageProduct values (@ID,@Describe,@Anh)";
                SqlCommand com = new SqlCommand(strCon,conn);
                com.Parameters.AddWithValue("@ID", tbProductID.Texts);
                com.Parameters.AddWithValue("@Describe", tbDecribeforImage.Texts);
                com.Parameters.AddWithValue("@Anh", convertImageToBytes());
                com.ExecuteNonQuery();
                conn.Close();
                FMessageBox fMessageBox = new FMessageBox();
                fMessageBox.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(label1.Text,FileMode.Open,FileAccess.Read);
            byte[] picByte = new byte[fs.Length];
            fs.Read(picByte,0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picByte;

        }

        private bool checkProduct()
        {
            if(string.IsNullOrEmpty(tbProductID.Texts) || checkID(tbProductID.Texts))
            {
                tbProductID.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(tbDecribeforImage.Texts))
            {
                tbDecribeforImage.Focus();
                return false;
            }
            if(label1.Text == "")
            {
                MessageBox.Show("Vui lòng thêm ảnh");
                return false;
            }
            return true;
        }

        private bool checkID(string id)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From inforProduct Where idProduct = '{0}'", tbProductID.Texts);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.HasRows) 
                {
                    sqlDataReader.Close();
                    conn.Close();
                    return true;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
