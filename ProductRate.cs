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
    public partial class ProductRate : UserControl
    {
        public ProductRate()
        {
            InitializeComponent();
        }

        private string _idPro;
        private string _date;
        private string _des;



        [Category("Custom Product")]
        public string IDPro
        {
            get { return _idPro; }
            set { _idPro = value; }
        }



        [Category("Custom Product")]
        public string Date
        {
            get { return _date; }
            set { _date = value; lbldateRate.Text = value; }
        }

        public string Des
        {
            get { return _des; }
            set { _des = value; lblDescription.Text = value; }
        }
    }
}
