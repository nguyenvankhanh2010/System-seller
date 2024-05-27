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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoDoAnVer02
{
    public partial class FBank_pay : Form
    {
        DBConnection db = new DBConnection();
        string ID = FLogin.instance.ID;
        public FBank_pay()
        {
            InitializeComponent();
        }

        private void btnAddBank_Pay_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            string sqlStr = string.Format("Insert into TKNganHang (ID, TenNganHang, STK, TenTK) Values ('{0}','{1}', '{2}', N'{3}')", ID, ccbBank.Texts, tbNum_pay.Texts, tbName1_pay.Texts);
            db.thucThiAdd(sqlStr);
            FHome.instance.setTKNganHang();
            this.Close();
        }

        private bool check()
        {
            if(string.IsNullOrEmpty(tbName1_pay.Texts))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return false;
            }
            if (string.IsNullOrEmpty(tbNum_pay.Texts) || !long.TryParse(tbNum_pay.Texts, out long a) || a < 0)
            {
                MessageBox.Show("Vui lòng nhập đúng số tài khoản");
                return false;
            }
            if (ccbBank.Texts =="Chọn ngân hàng")
            {
                MessageBox.Show("Vui lòng chọn ngân hàng");
                return false;
            }
            return true;
        }
    }
}
