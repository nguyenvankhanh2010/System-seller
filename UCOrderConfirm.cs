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
    public partial class UCOrderConfirm : UserControl
    {
        DBConnection db = new DBConnection();
        public UCOrderConfirm()
        {
            InitializeComponent();
        }

        private string _idPro;
        private string _idDH;
        private string _name;
        private string _tinhTrang;
        private int _soLuong;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(btnConfirm.Text == "Hủy đơn hàng")
            {
                string sqlStr = string.Format("Delete From DonHang Where idOrder = '{0}'", MaDH);
                db.thucThiDel(sqlStr);
                string sqlStr1 = string.Format("Update  inforProduct Set quantityProduct = quantityProduct + '{0}' Where idProduct = '{1}'", SoLuong, IDPro);
                db.thucThiUpdate(sqlStr1);
            }
            if(btnConfirm.Text == "Đã nhận hàng")
            {
                string sqlStr2 = string.Format("Update  DonHang Set tinhTrang = N'Đã giao' Where idOrder = '{0}'", MaDH);
                db.thucThiUpdate(sqlStr2);
            }
            FHome.instance.FHome_Load(sender, e);
        }

        [Category("Custom Product")]
        public string IDPro
        {
            get { return _idPro; }
            set { _idPro = value; }
        }

        [Category("Custom Product")]
        public string MaDH
        {
            get { return _idDH; }
            set { _idDH = value; }
        }

        [Category("Custom Product")]
        public string NamE
        {
            get { return _name; }
            set { _name = value; lblID.Text = value; }
        }

        [Category("Custom Product")]
        public string TinhTrang
        {
            get { return _tinhTrang; }
            set
            {
                _tinhTrang = value;
                if (_tinhTrang == "Chờ xác nhận")
                {
                    btnConfirm.Text = "Hủy đơn hàng";
                    btnConfirm.BackColor = Color.Tomato;
                }
                if (_tinhTrang == "Đang giao hàng")
                {
                    btnConfirm.Text = "Đã nhận hàng";
                    btnConfirm.BackColor = Color.LimeGreen;
                }
            }
        }

        [Category("Custom Product")]
        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}
