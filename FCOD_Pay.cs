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
    public partial class FCOD_Pay : Form
    {
        DBConnection db = new DBConnection();
        string ID = FLogin.instance.ID;

        public FCOD_Pay()
        {
            InitializeComponent();
        }

        private void btnAddOCD_Pay_Click(object sender, EventArgs e)
        {
            if(!check()) return;
            string sqlStr = string.Format("Insert into MOMO (Id, SDT, TenNguoiNhan) Values ('{0}', '{1}', N'{2}')", ID, tbPhone.Texts, tbName2_pay.Texts);
            db.thucThiAdd(sqlStr);
            FHome.instance.setMOMO();
            this.Close();
        }

        private bool check()
        {
            if(string.IsNullOrEmpty(tbName2_pay.Texts))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return false;
            }
            if(string.IsNullOrEmpty(tbPhone.Texts) || !db.isPhone(tbPhone.Texts)) 
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
                return false;
            }
            return true;
        }
    }
}
