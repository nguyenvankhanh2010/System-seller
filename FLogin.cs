using System.Data.SqlClient;
using System.Linq.Expressions;
using DemoDoAnVer02.Properties;

namespace DemoDoAnVer02
{
    public partial class FLogin : Form
    {
        public string ID;
        public static FLogin instance;

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FLogin()
        {
            InitializeComponent();
            tbPassword.PasswordChar = true;
            instance = this;
        }

        private void lblToSignUp_Click(object sender, EventArgs e)
        {
            FSignUp fSignUp = new FSignUp();
            this.Hide();
            fSignUp.ShowDialog();
            this.Show();
        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShow.Checked == true)
            {
                tbPassword.PasswordChar = false;
            }
            if (chbShow.Checked == false)
            {
                tbPassword.PasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = tbUsername.Texts;
            string mk = tbPassword.Texts;
            if (!string.IsNullOrEmpty(tk) && !string.IsNullOrEmpty(mk))
            {
                try
                {
                    conn.Open();
                    string sqlStrTK = "Select * From Login Where TenDangNhap = '" + tk + "' and MatKhau = '" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sqlStrTK, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        ID = tbUsername.Texts;
                        FHome fHome = new FHome();
                        this.Hide();
                        fHome.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Dang nhap that bai");
                    }
                }
                catch
                {
                    MessageBox.Show("Loi ket noi");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
