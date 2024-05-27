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
    public partial class UCHisBuy : UserControl
    {
        DBConnection db = new DBConnection();
        string ID = FLogin.instance.ID;

        public UCHisBuy()
        {
            InitializeComponent();
        }

        private string _idPro;
        private string _name;
        private double _total;
        private string _date;



        [Category("Custom Product")]
        public string IDPro
        {
            get { return _idPro; }
            set { _idPro = value; }
        }

        [Category("Custom Product")]
        public string NamE
        {
            get { return _name; }
            set { _name = value; lblID.Text = value; }
        }

        [Category("Custom Product")]
        public double Total
        {
            get { return _total; }
            set { _total = value; lblTotal.Text = value.ToString() + '$'; }
        }

        [Category("Custom Product")]
        public string Date
        {
            get { return _date; }
            set { _date = value; lblDateOrder.Text = value.Substring(0, 9); }
        }


        private void UCHisBuy_Click(object sender, EventArgs e)
        {
            FRateProduct f = new FRateProduct();
            f.Addid(IDPro);
            f.ShowDialog();
        }
    }
}
