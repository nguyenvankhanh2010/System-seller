using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DemoDoAnVer02
{
    public partial class SelectDate :Form
    {
        public SelectDate()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (DateStart.Value > DateTime.Now || DateEnd.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian không hợp lệ");
            }
            else 
            {
                FHome.instance.lbStart.Text = DateStart.Value.ToString("dd/MM/yyyy");
                FHome.instance.lbEnd.Text = DateEnd.Value.ToString("dd/MM/yyyy");
                FHome.instance.ConfirmDay(sender, e);
                this.Close();
            } 
                
           
        }
    }
}
