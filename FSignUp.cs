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
    public partial class FSignUp : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        UserDAO userDAO = new UserDAO();
        AccountDAO accountDAO = new AccountDAO();

        string sex;
        public FSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            if (rbMale.Checked)
            {
                sex = "Nam";
            }
            else if (rbFemale.Checked)
            {
                sex = "Nu";
            }
            User u = new User(tbUserName.Texts, tbName.Texts, tbAddress.Texts, tbPhone.Texts, sex, tbEmail.Texts, dtpDOB.Value);
            Account a = new Account(tbUserName.Texts, tbPassword.Texts);
            accountDAO.Add(a);
            userDAO.Add(u);
            this.Close();
        }

        private bool check()
        {
            if (!checkID()) return false;
            if (string.IsNullOrEmpty(tbName.Texts))
            {
                MessageBox.Show("Chưa nhập tên");
                return false;
            }
            if (string.IsNullOrEmpty(tbAddress.Texts))
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                return false;
            }
            if (string.IsNullOrEmpty(tbPhone.Texts) || !db.isPhone(tbPhone.Texts))
            {
                MessageBox.Show("Vui lòng điền đúng số điện thoại");
                return false;
            }
            if (string.IsNullOrEmpty(tbEmail.Texts) || !db.isEmail(tbEmail.Texts))
            {
                MessageBox.Show("Vui lòng điền đúng email");
                return false;
            }
            if (!db.is16YearsOld(dtpDOB.Value))
            {
                MessageBox.Show("Chưa đủ 16 tuổi");
                return false;
            }
            if (!rbFemale.Checked && !rbMale.Checked)
            {
                MessageBox.Show("Chưa chọn giới tính");
                return false;
            }
            if (string.IsNullOrEmpty(tbPassword.Texts))
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                return false;
            }
            if (string.IsNullOrEmpty(tbEnterPass.Texts))
            {
                MessageBox.Show("Chưa xác nhận mật khẩu");
                return false;
            }
            if (tbEnterPass.Texts != tbPassword.Texts)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return false;
            }
            return true;
        }

        private bool checkID()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select TenDangNhap From Login Where TenDangNhap = '{0}'", tbUserName.Texts);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại");
                    return false;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}
