using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoAnVer02
{
    public partial class FAddressInfor : Form
    {
        string id = FLogin.instance.ID;
        DBConnection db = new DBConnection();
        public FAddressInfor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbNameOrder.Texts))
            {
                MessageBox.Show("Vui long nhap ten nguoi nhan");
                return;
            }
            if (string.IsNullOrEmpty(tbPhoneOrder.Texts))
            {
                MessageBox.Show("Vui long nhap so dien thoai nguoi nhan");
                return;
            }
            if (string.IsNullOrEmpty(tbEmailOrder.Texts))
            {
                MessageBox.Show("Vui long nhap email nguoi nhan");
                return;
            }
            if (string.IsNullOrEmpty(tbAddressOrder.Texts))
            {
                MessageBox.Show("Vui long nhap dia chi nhan hang");
                return;
            }
            if(cbbTypeAddress.TabIndex == -1) 
            {
                MessageBox.Show("Vui long chon loai dia chi");
                return;
            }
            string sqlStr = string.Format("Insert into addressInfor Values ('{0}',N'{1}', '{2}', N'{3}', '{4}', N'{5}')", id, tbAddressOrder.Texts, tbPhoneOrder.Texts, tbNameOrder.Texts, tbEmailOrder.Texts, cbbTypeAddress.Text);
            db.thucThiAdd(sqlStr);
            FHome.instance.FHome_Load(sender, e);
        }
    }
}
