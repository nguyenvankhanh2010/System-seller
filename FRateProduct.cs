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
    public partial class FRateProduct : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string IDpro1;
        string IDpro;
        public FRateProduct()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtRateBuyer.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập đánh giá");

            }
            else
            {

                try
                {


                    conn.Open();
                    string sqlStr = string.Format("insert into rateProduct(idProduct,rateBuyer,daterate) values ('{0}',N'{1}','{2}')", IDpro, txtRateBuyer.Texts, DateTime.Now);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    conn.Close();
                    this.Close();
                }
            }
         }
        public void Addid(string IDpro1 )
        {
            IDpro = IDpro1;
        }
    }
}
