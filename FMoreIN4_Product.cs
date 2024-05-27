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
    public partial class FMoreIN4_Product : Form
    {
        public FMoreIN4_Product()
        {
            InitializeComponent();
        }
        public void ShowTabControl1()
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tbpDoDienTu"];
            this.Show();
        }
        public void ShowTabControl2()
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tbpThoiTrang"];
            this.Show();
        }
        public void ShowTabControl3()
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tbpTulanh"];
            this.Show();
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
