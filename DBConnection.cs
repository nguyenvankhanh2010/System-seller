using DemoDoAnVer02.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoDoAnVer02
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public void thucThiAdd(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    FMessageBox fMessageBox = new FMessageBox();
                    fMessageBox.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi CSDL"+ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void thucThiDel(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    FMessageBox fMessageBox = new FMessageBox();
                    //fMessageBox.lblNotifi.Text = "   Xóa thành công";
                    //fMessageBox.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
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

        public void thucThiUpdate(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    FMessageBox fMessageBox = new FMessageBox();
                    //fMessageBox.lblNotifi.Text = "Cập nhật thành công";
                    //fMessageBox.ShowDialog();
                }
                else
                {
                    //MessageBox.Show("Doi mat khau khong thanh cong");
                }
            }
            catch
            {
                MessageBox.Show("Loi ket noi den CSDL");
            }
            finally
            {
                conn.Close();
            }
        }


        public DataTable thucThiLoadDGV(string sqlStr)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Hàm kiểm tra email.
        public bool isEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //Hàm kiểm tra sdt.
        public bool isPhone(string phone)
        {
            if (phone.Length == 10)
            {
                foreach (char s in phone)
                {
                    if ('0' >= s && s >= '9')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        //Hàm kiểm tra tuổi.
        public bool is16YearsOld(DateTime date)
        {
            TimeSpan SAge = DateTime.Now - date;
            double age = SAge.TotalDays / 365.2425;
            if (age < 16)
            {
                return false;
            }
            return true;
        }

        //
        public string createIdOrder(string idOrder)
        {
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            idOrder = trimmer.Replace(idOrder, " ");
            string[] charsToRemove = new string[] { "@", ",", ".", ";", "'", "/", ":" };
            foreach (var c in charsToRemove)
            {
                idOrder = idOrder.Replace(c,string.Empty);
            }
            return idOrder;
        }

    }
}
