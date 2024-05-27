using DemoDoAnVer02.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Globalization;
using System.Linq;

namespace DemoDoAnVer02
{
    public partial class FHome : Form
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        ProductDAO pDAO = new ProductDAO();
        UserDAO userDAO = new UserDAO();
        AccountDAO accountDAO = new AccountDAO();
        DonHangDAO dhDAO = new DonHangDAO();

        List<UCProduct> listProduct = new List<UCProduct>();
        List<UCProductInCart> listProductInCart = new List<UCProductInCart>();
        List<UCHisBuy> listProductBought = new List<UCHisBuy>();
        List<UCOrderConfirm> listConfirm = new List<UCOrderConfirm>();
        List<UCProduct> listProduct_Search = new List<UCProduct>();

        string ID = FLogin.instance.ID;
        string sex;

        private bool changePass = true;
        private bool changeInfo = true;

        private bool isCollapsed;

        Point Loction_btnCart;
        Point Loction_btnAccount;

        public static FHome instance;
        public Label lbStart;
        public Label lbEnd;
        public Label Name_Bank;
        public Label Name1_Pay;
        public Label Number_Pay;

        public Label Name2_Pay;
        public Label Phone_Pay;

        byte[] imageData;
        public FHome()
        {

            InitializeComponent();
            btnHome.BackColor = Color.Goldenrod;

            Loction_btnCart = btnCart.Location;
            Loction_btnAccount = btnAccount.Location;


            lbDateStart_Sold.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbDateEnd_Sold.Text = DateTime.Now.ToString("dd/MM/yyyy");

            instance = this;
            lbStart = lbDateStart_Sold;
            lbEnd = lbDateEnd_Sold;

        }


        //Load form chính.
        internal void FHome_Load(object sender, EventArgs e)
        {
            clearAll();
            getProduct();
            getProductInCart();
            getProductInHistoryBuy();
            getConfirmList();
            CartOrder_Load();
            HomeProduct_Load();
            HistoryBuy_Load();
            dgvDonHang_Load();
            Confirm_Load();
            ReLoad_DH();
            ProductList_Load(sender, e);
            ProductList_Reload();
            getTypeAddress();
        }


        //Clear tất cả danh sách.
        private void clearAll()
        {
            flpProductInCart.Controls.Clear();
            flpProductHome.Controls.Clear();
            flpHisBuy.Controls.Clear();
            flpConfirm.Controls.Clear();
        }


        //Đăng xuất tài khoản.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.ShowDialog();
            this.Close();
        }


        //Trang Đăng bán sản phẩm.

        //Click mở trang đăng bán sản phẩm.
        private void btnSale_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tbpSale"];
            btnManage.BackColor = Color.Gold;
            btnHistory_Sale.BackColor = Color.Gold;
            btnSale.BackColor = Color.Goldenrod;
            btnSaler.BackColor = Color.Gold;

        }

        //Thêm sản phẩm.
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!checkProduct()) return;
            Product p = new Product(tbProductID.Text, ID, tbNameProduct.Text, cbbSelectType.Texts, (int)Convert.ToInt32(tbQuantityProduct.Text), (double)Convert.ToDouble(tbPriceOLD.Text), (double)Convert.ToDouble(tbPriceNEW.Text), tbBrand.Text, tbDecribe.Text, tbAddressProduct.Text);
            pDAO.Add(p);
            FHome_Load(sender, e);
        }

        //Cập nhật sản phẩm.
        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            if (!checkProduct()) return;
            Product p = new Product(tbProductID.Text, ID, tbNameProduct.Text, cbbSelectType.Texts, (int)Convert.ToInt32(tbQuantityProduct.Text), (double)Convert.ToDouble(tbPriceOLD.Text), (double)Convert.ToDouble(tbPriceNEW.Text), tbBrand.Text, tbDecribe.Text, tbAddressProduct.Text);
            pDAO.Update(p);
            FHome_Load(sender, e);
        }

        //Xóa sản phẩm.
        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product(tbProductID.Text, ID, tbNameProduct.Text, cbbSelectType.Texts, (int)Convert.ToInt32(tbQuantityProduct.Text), (double)Convert.ToDouble(tbPriceOLD.Text), (double)Convert.ToDouble(tbPriceNEW.Text), tbBrand.Text, tbDecribe.Text, tbAddressProduct.Text);
            pDAO.Delete(p);
            FHome_Load(sender, e);
        }

        //Reload textbox lại ban đầu.
        private void ProductList_Reload()
        {
            tbPriceNEW.Text = "";
            tbPriceOLD.Text = "";
            tbProductID.Text = "";
            tbNameProduct.Text = "";
            tbBrand.Text = "";
            tbDecribe.Text = "";
            tbQuantityProduct.Text = "";
            tbAddressProduct.Text = "";
            cbbSelectType.Texts = "Loại sản phẩm";
        }

        //Load dgv Sản phẩm.
        private void ProductList_Load(object sender, EventArgs e)
        {
            dgvProductList.DataSource = pDAO.Load(ID);
        }

        //Cellclick dgv Sản phẩm.
        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvProductList.Rows[e.RowIndex];
            tbNameProduct.Text = Convert.ToString(row.Cells["Tên sản phẩm"].Value);
            tbProductID.Text = Convert.ToString(row.Cells["Mã sản phẩm"].Value);
            cbbSelectType.Texts = Convert.ToString(row.Cells["Loại sản phẩm"].Value);
            tbQuantityProduct.Text = Convert.ToString(row.Cells["Số lượng"].Value);
            tbPriceOLD.Text = Convert.ToString(row.Cells["Giá niêm yết"].Value);
            tbPriceNEW.Text = Convert.ToString(row.Cells["Giá bán"].Value);
            tbBrand.Text = Convert.ToString(row.Cells["Hãng sản xuất"].Value);
            tbDecribe.Text = Convert.ToString(row.Cells["Mô tả"].Value);
            tbAddressProduct.Text = Convert.ToString(row.Cells["Địa chỉ"].Value);
        }

        //Mở form thêm ảnh cho sản phẩm.
        private void btnAddImage_Click_1(object sender, EventArgs e)
        {
            FAddImage fAddImage = new FAddImage();
            fAddImage.Text = "Thêm ảnh sản phẩm";
            fAddImage.ShowDialog();
        }

        //Check thông tin sản phẩm.
        private bool checkProduct()
        {
            if (string.IsNullOrEmpty(tbNameProduct.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                tbNameProduct.Focus();
                return false;
            }
            if (cbbSelectType.Texts == "Loại sản phẩm")
            {
                MessageBox.Show("Chọn loại sản phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(tbProductID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
                tbProductID.Focus();
                return false;
            }
            if (!int.TryParse(tbQuantityProduct.Text, out int a) || string.IsNullOrEmpty(tbQuantityProduct.Text) || a < 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
                tbQuantityProduct.Focus();
                return false;
            }
            if (!double.TryParse(tbPriceOLD.Text, out double t) || double.IsNaN(t) || double.IsInfinity(t) || string.IsNullOrEmpty(tbPriceOLD.Text) || t < 0)
            {
                MessageBox.Show("Vui nhập giá niêm yết của sản phẩm");
                tbPriceOLD.Focus();
                return false;
            }
            if (!double.TryParse(tbPriceNEW.Text, out double n) || double.IsNaN(n) || double.IsInfinity(n) || string.IsNullOrEmpty(tbPriceNEW.Text) || n < 0)
            {
                MessageBox.Show("Vui lòng nhập giá bán sản phẩm");
                tbPriceNEW.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbBrand.Text))
            {
                MessageBox.Show("Vui lòng nhập hãng sản xuất");
                tbBrand.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbDecribe.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả sản phẩm");
                tbDecribe.Focus();
                return false;
            }
            return true;
        }

        //




        //Trang Tài khoản 


        //Click vào trang Account.
        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gold;
            btnCart.BackColor = Color.Gold;
            btnAccount.BackColor = Color.Goldenrod;
            btnSaler.BackColor = Color.Gold;
            btnSale.BackColor = Color.Gold;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpAccount"];
            UCAccountView_Load(sender, e);
            DongkhungPanel();
        }

        //Lấy thông tin tài khoản từ CSDL
        public void setInfor()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select * From Login inner join ThongTinUser on ThongTinUser.ID = Login.TenDangNhap where Login.TenDangNhap = '{0}'", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbUserName.Texts = reader.GetString(0);
                        tbPassword.Texts = reader.GetString(1);
                        tbEnterPass.Texts = reader.GetString(1);
                        tbName1.Texts = reader.GetString(2);
                        tbAddress1.Texts = reader.GetString(3);
                        tbPhone1.Texts = reader.GetString(4);
                        tbEmail1.Texts = reader.GetString(5);
                        dtpDOB1.Value = reader.GetDateTime(7);
                        if (reader.GetString(6) == "Nam")
                        {
                            rbMale1.Checked = true;
                        }
                        else
                        {
                            rbFemale1.Checked = true;
                        }
                    }
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Ket noi khong thanh cong den CSDL");
            }
            finally
            {
                conn.Close();
            }
        }

        //Sửa thông tin cá nhân.
        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if (changeInfo)
            {
                SetInfor(changeInfo);
                btnChangeInfor.Text = "Lưu thông tin";
            }
            else
            {
                if (!checkTK()) return;
                SetInfor(changeInfo);
                btnChangeInfor.Text = "Sửa thông tin";
                SaveInfor();
            }
            UCAccountView_Load(sender, e);
            changeInfo = !changeInfo;
        }

        //set chỉnh sửa textbox thông tin.
        private void SetInfor(bool key)
        {
            tbName1.Enabled = key;
            tbAddress1.Enabled = key;
            tbEmail1.Enabled = key;
            tbPhone1.Enabled = key;
            rbFemale1.Enabled = key;
            rbMale1.Enabled = key;
            dtpDOB1.Enabled = key;
        }

        //Lưu thông tin thay đổi.
        public void SaveInfor()
        {
            if (rbMale1.Checked)
            {
                sex = "Nam";
            }
            else if (rbFemale1.Checked)
            {
                sex = "Nu";
            }
            User u = new User(ID, tbName1.Texts, tbAddress1.Texts, tbPhone1.Texts, sex, tbEmail1.Texts, dtpDOB1.Value);
            userDAO.Update(u);
        }

        //Đổi mật khẩu 
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (changePass)
            {
                tbUserName.Enabled = false;
                tbPassword.Enabled = true;
                tbEnterPass.Enabled = true;
                btnChangePass.Text = "Lưu mật khẩu";
            }
            else
            {
                if (!checkPass()) return;
                tbUserName.Enabled = false;
                tbPassword.Enabled = false;
                tbEnterPass.Enabled = false;
                btnChangePass.Text = "Đổi mật khẩu";
                Account a = new Account(tbUserName.Texts, tbPassword.Texts);
                accountDAO.Update(a);
                UCAccountView_Load(sender, e);
            }
            changePass = !changePass;
        }

        //Mở form thêm tài khoản ngân hàng.
        private void btnBank_Pay_Click(object sender, EventArgs e)
        {
            FBank_pay fBank = new FBank_pay();
            fBank.Show();
        }

        //Set thông tin tk ngân hàng.
        public void setTKNganHang()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select * from TKNganHang where TKNganHang.ID = '{0}'", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbBank_Pay.Text = reader.GetString(1);
                        lbNum_Pay.Text = reader.GetString(2);
                        lbName1_Pay.Text = reader.GetString(3);
                    }
                }
                else
                {
                    lbBank_Pay.Text = "NULL";
                    lbNum_Pay.Text = "NULL";
                    lbName1_Pay.Text = "NULL";
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Ket noi khong thanh cong den CSDL");
            }
            finally
            {
                conn.Close();
            }
        }

        //Mở form thêm tài khoản MoMo.
        private void btnCOD_Pay_Click(object sender, EventArgs e)
        {
            FCOD_Pay fBank = new FCOD_Pay();
            fBank.Show();
        }

        //Set thông tin MoMo
        public void setMOMO()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select * from MOMO where Id = '{0}'", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbName2_Pay.Text = reader.GetString(2);
                        lbPhone_Pay.Text = reader.GetString(1);
                    }
                }
                else
                {
                    lbName2_Pay.Text = "";
                    lbPhone_Pay.Text = "";
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Ket noi khong thanh cong den CSDL");
            }
            finally
            {
                conn.Close();
            }
        }

        //Account view load.
        private void UCAccountView_Load(object sender, EventArgs e)
        {
            setInfor();
            setTKNganHang();
            setMOMO();
        }

        //Lấy thông tin đơn hàng đã mua của tài khoản từ CSDL.
        private void getProductInHistoryBuy()
        {
            listProductBought.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select DonHang.idProduct, inforProduct.nameProduct, DonHang.quantityBuy, inforProduct.resellProduct, DonHang.dateBuy From DonHang inner join inforProduct on DonHang.idProduct = inforProduct.idProduct  Where idBuyer = '{0}' and tinhTrang = N'Đã giao'", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UCHisBuy product = new UCHisBuy();
                        product.IDPro = reader.GetString(0);
                        product.NamE = reader.GetString(1);
                        int soLuong = reader.GetInt32(2);
                        double price = reader.GetDouble(3);
                        product.Total = soLuong * price + 30;
                        product.Date = reader["dateBuy"].ToString();
                        listProductBought.Add(product);
                    }
                    reader.Close();
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void getConfirmList()
        {
            listConfirm.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select DonHang.idProduct, inforProduct.nameProduct, DonHang.quantityBuy, DonHang.tinhTrang, DonHang.idOrder From DonHang inner join inforProduct on DonHang.idProduct = inforProduct.idProduct  Where idBuyer = '{0}' and (tinhTrang =  N'Chờ xác nhận' or tinhTrang = N'Đang giao hàng')", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UCOrderConfirm product = new UCOrderConfirm();
                        product.IDPro = reader.GetString(0);
                        product.NamE = reader.GetString(1);
                        product.SoLuong = reader.GetInt32(2);
                        product.TinhTrang = reader.GetString(3);
                        product.MaDH = reader.GetString(4);
                        listConfirm.Add(product);
                    }
                    reader.Close();
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        //Load Confirm list.
        private void Confirm_Load()
        {
            foreach (UCOrderConfirm product in listConfirm)
            {
                flpConfirm.Controls.Add(product);
            }
        }

        //Load lịch sử mua hàng.
        private void HistoryBuy_Load()
        {
            foreach (UCHisBuy product in listProductBought)
            {
                flpHisBuy.Controls.Add(product);
            }
        }

        //Hàm kiểm tra thông tin.
        private bool checkTK()
        {
            if (string.IsNullOrEmpty(tbName1.Texts))
            {
                MessageBox.Show("Chưa nhập tên");
                return false;
            }
            if (string.IsNullOrEmpty(tbAddress1.Texts))
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                return false;
            }
            if (string.IsNullOrEmpty(tbPhone1.Texts) || !db.isPhone(tbPhone1.Texts))
            {
                MessageBox.Show("Vui lòng điền đúng số điện thoại");
                return false;
            }
            if (string.IsNullOrEmpty(tbEmail1.Texts) || !db.isEmail(tbEmail1.Texts))
            {
                MessageBox.Show("Vui lòng điền đúng email");
                return false;
            }
            if (!db.is16YearsOld(dtpDOB1.Value))
            {
                MessageBox.Show("Chưa đủ 16 tuổi");
                return false;
            }
            if (!rbFemale1.Checked && !rbMale1.Checked)
            {
                MessageBox.Show("Chưa chọn giới tính");
                return false;
            }
            return true;
        }

        //Hàm kiểm tra mật khẩu.
        private bool checkPass()
        {
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

        //


        //Trang chủ.


        //Click vào trang chủ
        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Goldenrod;
            btnCart.BackColor = Color.Gold;
            btnAccount.BackColor = Color.Gold;
            btnSaler.BackColor = Color.Gold;
            btnSale.BackColor = Color.Gold;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpHome"];
            DongkhungPanel();
        }

        //Bộ lọc sản phẩm.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FHome_Load(sender, e);
        }

        //Load sản phẩm ở trang chủ.
        private void HomeProduct_Load()
        {
            foreach (UCProduct product in listProduct)
            {
                if (ccbListProduct.Text == "Tất cả sản phẩm" || ccbListProduct.Text == "Danh mục")
                {
                    flpProductHome.Controls.Add(product);
                }
                else
                {
                    if (product.Type == ccbListProduct.Text)
                    {
                        flpProductHome.Controls.Add(product);
                    }
                }
            }
        }

        //Lấy danh sách sản phẩm từ CSDL.
        private void getProduct()
        {
            listProduct.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select idProduct, nameProduct, resellProduct, typeProduct, retailProduct, addressProduct From inforProduct Where quantityProduct > 0");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UCProduct product = new UCProduct();
                        product.ID = reader.GetString(0);
                        product.NamE = reader.GetString(1);
                        double price = reader.GetDouble(2);
                        product.Price = price.ToString() + '$';
                        product.Type = reader.GetString(3);
                        double oldPrice = reader.GetDouble(4);
                        product.OldPrice = oldPrice.ToString() + '$';
                        product.Address = reader.GetString(5);
                        listProduct.Add(product);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("KO co du lieu");
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

        //
        private void button1_Click(object sender, EventArgs e)
        {
            flpProductHome.Controls.Clear();
            listProduct.Clear();
            if (tbSearchBar.Texts == "   Tìm kiếm ....")
            {
                getProduct();

            }
            else
            {
                try
                {
                    conn.Open();
                    string sqlStr = string.Format("Select idProduct, nameProduct, resellProduct, typeProduct From inforProduct Where quantityProduct > 0 and CHARINDEX('{0}', nameProduct) > 0", tbSearchBar.Texts);//CHARINDEX kiểm tra sự tồn tại của chuỗi

                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UCProduct product = new UCProduct();
                            product.ID = reader.GetString(0);
                            product.NamE = reader.GetString(1);
                            double price = reader.GetDouble(2);
                            product.Price = price.ToString() + '$';
                            product.Type = reader.GetString(3);
                            listProduct.Add(product);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("KO co du lieu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi ket noi CSDL7777" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            HomeProduct_Load();
        }
        private void cbb_ArrPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpProductHome.Controls.Clear();
            List<UCProduct> sortedProducts = new List<UCProduct>();
            try
            {
                if (cbb_ArrPrice.Text == "Giá: Thấp đến Cao")
                {
                    // Sắp xếp các sản phẩm theo giá tăng dần
                    sortedProducts = listProduct.OrderBy(p => double.Parse(p.Price.Replace("$", ""))).ToList();
                    listProduct.Clear();

                }
                else if (cbb_ArrPrice.Text == "Giá: Cao đến Thấp")
                {
                    // Sắp xếp các sản phẩm theo giá giảm dần
                    sortedProducts = listProduct.OrderByDescending(p => double.Parse(p.Price.Replace("$", ""))).ToList();
                    listProduct.Clear();

                }
                foreach (var product in sortedProducts)
                {

                    // Thêm product vào flpProductHome
                    listProduct.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                HomeProduct_Load();
            }
        }
        private void chbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            flpProductHome.Controls.Clear();
            List<UCProduct> sortedProducts = new List<UCProduct>();
            try
            {

                if (chbUpdate.Checked == true)
                {

                    conn.Open();
                    string sqlStr = string.Format("Select idProduct, nameProduct, resellProduct, typeProduct  FROM DonHang DH INNER JOIN inforProduct IP ON DH.idProduct = IP.idProduct ORDER BY dateSell ASC where quantity >0 tên cái sản phẩm tìm kiếm nữa ");

                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UCProduct product = new UCProduct();
                            product.ID = reader.GetString(0);
                            product.NamE = reader.GetString(1);
                            double price = reader.GetDouble(2);
                            product.Price = price.ToString() + '$';
                            product.Type = reader.GetString(3);
                            listProduct.Add(product);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("KO co du lieu");
                    }

                }
                else
                {

                }
                foreach (var product in sortedProducts)
                {
                    // Thêm product vào flpProductHome
                    listProduct.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                HomeProduct_Load();
            }
        }

        //Trang Giỏ hàng.


        //Click vào Giỏ hàng.
        internal void btnCart_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gold;
            btnCart.BackColor = Color.Goldenrod;
            btnAccount.BackColor = Color.Gold;
            btnSaler.BackColor = Color.Gold;
            btnSale.BackColor = Color.Gold;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpCart"];
            FHome_Load(sender, e);
            DongkhungPanel();
        }

        //Load sản phẩm được thêm vào giỏ hàng.
        internal void CartOrder_Load()
        {
            double t = 0;
            foreach (UCProductInCart product in listProductInCart)
            {
                flpProductInCart.Controls.Add(product);
                t += product.Total;
            }
            if (t == 0)
            {
                lblDiscount.Text = "";
                lblShipping.Text = "";
                lblPriceOrder.Text = "";
                Total.Text = "";
            }
            else
            {
                lblDiscount.Text = "No";
                lblShipping.Text = "30$";
                lblPriceOrder.Text = t.ToString() + '$';
                Total.Text = '$' + (t + 30).ToString();
            }
            lblDiscountRe.Text = lblDiscount.Text;
            lblPriceRe.Text = lblPriceOrder.Text;
            lblShipRe.Text = lblShipping.Text;
            lblTotalRe.Text = Total.Text;
        }

        //Lấy danh sách sản phẩm được thêm vào giỏ hàng từ CSDL.
        private void getProductInCart()
        {
            listProductInCart.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select productInCart.idProduct, nameProduct, resellProduct, quantity, quantityProduct From productInCart inner join inforProduct on productInCart.idProduct = inforProduct.idProduct Where productInCart.idUser = '{0}'", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UCProductInCart product = new UCProductInCart();
                        product.ID = reader.GetString(0);
                        product.NamE = reader.GetString(1);
                        product.Price = reader.GetDouble(2).ToString();
                        product.Prices = reader.GetDouble(2);
                        product.Quantity = (int)reader.GetValue(3);
                        product.Total = reader.GetDouble(2) * (int)reader.GetValue(3);
                        product.MaxQuantity = reader.GetInt32(4);
                        listProductInCart.Add(product);
                    }
                    reader.Close();
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

        //Chuyển sang trang thanh toán.
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gold;
            btnCart.BackColor = Color.Goldenrod;
            btnAccount.BackColor = Color.Gold;
            btnSaler.BackColor = Color.Gold;
            btnSale.BackColor = Color.Gold;
            getProductInCart();
            CartOrder_Load();
            if (listProductInCart.Count <= 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
            else
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tbStep2Order"];
            }
        }

        //





        //Trang thanh toán.

        //Chọn phương thức thanh toán qua tk ngân hàng.
        private void rbBanking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBanking.Checked)
            {
                lblInforPayment.Visible = true;
                lblINameBank.Visible = true;
                lblISTK.Visible = true;
                lblNameSeller.Visible = true;
                lblINameSeller.Visible = true;
                lblBankName.Visible = true;
                lblSTK.Visible = true;
                lblINameBank.Text = "Techcombank";
                lblISTK.Text = "100820046666";
                lblSTK.Text = "Số tài khoản:";
            }
        }

        //Chọn phương thức thanh toán qua tk MoMo.
        private void rbMoMo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMoMo.Checked)
            {
                lblInforPayment.Visible = true;
                lblINameBank.Visible = false;
                lblBankName.Visible = false;
                lblISTK.Visible = true;
                lblNameSeller.Visible = true;
                lblINameSeller.Visible = true;
                lblSTK.Visible = true;
                lblISTK.Text = "0947166477";
                lblSTK.Text = "Số MoMo:";
            }
        }

        //Chọn phương thức thanh toán COD.
        private void rbCOD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCOD.Checked)
            {
                lblInforPayment.Visible = false;
                lblINameBank.Visible = false;
                lblBankName.Visible = false;
                lblISTK.Visible = false;
                lblNameSeller.Visible = false;
                lblINameSeller.Visible = false;
                lblSTK.Visible = false;
            }
        }

        //Nút xác nhận đã thanh toán.
        private void newButton3_Click(object sender, EventArgs e)
        {
            if (!rbCOD.Checked)
            {
                MessageBox.Show("Đã thanh toán thành công");
                btnConfirmPayment.Text = "Đã thanh toán";
                btnConfirmPayment.BackColor = Color.MediumSeaGreen;
            }
        }

        //Tạo đơn hàng.
        private void creatDonHang(object sender, EventArgs e)
        {
            foreach (UCProductInCart product in listProductInCart)
            {
                DonHang dh = new DonHang(product.ID, ID, product.Quantity, DateTime.Now, tbNameOrder.Texts, tbPhoneOrder.Texts, tbEmailOrder.Texts, tbAddressOrder.Texts, tbNoteOrder.Texts, db.createIdOrder(product.ID + ID + DateTime.Now.ToShortDateString() + DateTime.Now.Minute.ToString()));
                dhDAO.AddDH(dh);
            }
            flpProductInCart.Controls.Clear();
            listProductInCart.Clear();
            FHome_Load(sender, e);
        }

        //Confirm order.
        private void btnCheckoutOrder_Click(object sender, EventArgs e)
        {
            //if (!checkOrder()) return;
            if (rbCOD.Checked || rbBanking.Checked || rbMoMo.Checked)
            {
                if (rbCOD.Checked)
                {
                    creatDonHang(sender, e);
                    btnHome_Click(sender, e);
                }
                else if (btnConfirmPayment.Text == "Đã thanh toán" && (rbBanking.Checked == true || rbMoMo.Checked == true))
                {
                    creatDonHang(sender, e);
                    btnHome_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng thanh toán đơn hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán");
            }
        }

        //
        private bool checkOrder()
        {
            if (string.IsNullOrEmpty(tbNameOrder.Texts))
            {
                MessageBox.Show("Vui lòng nhập tên người nhận");
                return false;
            }
            if (string.IsNullOrEmpty(tbPhoneOrder.Texts) || !db.isPhone(tbPhoneOrder.Texts))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại nhận hàng");
                return false;
            }
            if (string.IsNullOrEmpty(tbEmailOrder.Texts) || !db.isEmail(tbEmailOrder.Texts))
            {
                MessageBox.Show("Vui lòng nhập đúng email");
                return false;
            }
            if (string.IsNullOrEmpty(tbAddressOrder.Texts))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ giao hàng");
                return false;
            }
            return true;
        }

        //



        //Trang quản lí đơn hàng.


        //Load dgv đơn hàng.
        private void dgvDonHang_Load()
        {
            string sqlStr = string.Format("Select idOrder as 'Mã đơn hàng', DonHang.idProduct as 'Mã sản phẩm', inforProduct.nameProduct as 'Tên sản phẩm', quantityBuy as 'Số lượng mua', resellProduct as 'Đơn giá bán', idBuyer as 'ID người mua', dateBuy as 'Ngày lập đơn' From DonHang inner join inforProduct on DonHang.idProduct = inforProduct.idProduct Where idSeller = '{0}'", ID);
            dgvDonHang.DataSource = db.thucThiLoadDGV(sqlStr);
        }

        //Click hiện chi tiết đơn hàng
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDonHang.Rows[e.RowIndex];
            lblIDOrder1.Text = Convert.ToString(row.Cells["Mã đơn hàng"].Value);


            try
            {
                conn.Open();
                string sqlStr = string.Format("Select idBuyer, nameBuyer, phoneBuyer, addressBuyer, nameProduct, quantityBuy, resellProduct, noteOrder, tinhTrang From DonHang inner join inforProduct on DonHang.idProduct = inforProduct.idProduct Where idOrder = '{0}'", lblIDOrder1.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                lblIDBuyer.Text = reader.GetString(0);
                lblNameBuyer.Text = reader.GetString(1);
                lblPhoneBuyer.Text = reader.GetString(2);
                lblAddressBuyer.Text = reader.GetString(3);
                lblNamePro.Text = reader.GetString(4);
                int q = reader.GetInt32(5);
                lblQuantityPro.Text = q.ToString();
                double p = reader.GetDouble(6);
                lblToTalBuyer.Text = (q * p).ToString() + '$';
                lblNoteBuyer.Text = reader.GetString(7);
                btnShipConfirm.Visible = true;
                btnShipConfirm.Text = reader.GetString(8);
                btnConfim(btnShipConfirm.Text);
                reader.Close();
            }
            catch
            {
            }
            finally { conn.Close(); }
        }

        //Reset chi tiết đơn hàng.
        private void ReLoad_DH()
        {
            lblIDOrder1.Text = "";
            lblIDBuyer.Text = "";
            lblNameBuyer.Text = "";
            lblPhoneBuyer.Text = "";
            lblAddressBuyer.Text = "";
            lblNamePro.Text = "";
            lblQuantityPro.Text = "";
            lblToTalBuyer.Text = "";
            lblNoteBuyer.Text = "";
        }

        //
        private void btnConfim(string s)
        {
            if (s == "Chờ xác nhận") btnShipConfirm.BackColor = Color.Tomato;
            if (s == "Đang giao hàng") btnShipConfirm.BackColor = Color.Gold;
            if (s == "Đã giao") btnShipConfirm.BackColor = Color.LimeGreen;
        }

        //
        private void btnShipConfirm_Click(object sender, EventArgs e)
        {
            if (btnShipConfirm.Text == "Chờ xác nhận")
            {
                string sqlStr = string.Format("Update DonHang Set tinhTrang = N'Đang giao hàng' Where idOrder = '{0}'", lblIDOrder1.Text);
                db.thucThiUpdate(sqlStr);
                btnShipConfirm.Text = "Đang giao hàng";
            }
            btnConfim(btnShipConfirm.Text);
        }


        //


        private void btnSaler_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gold;
            btnCart.BackColor = Color.Gold;
            btnAccount.BackColor = Color.Gold;
            btnSaler.BackColor = Color.Goldenrod;
            ProductList_Load(sender, e);
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnSaler.Image = Resources.drop_icon2__1___2_;
                btnSaler.Font = new System.Drawing.Font(btnSaler.Font.FontFamily, 11);
                btnCart.Location = new Point(0, 508);
                btnAccount.Location = new Point(0, 561);
                pnlDropDown.Height += 10;
                if (pnlDropDown.Size == pnlDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnSaler.Image = Resources.drop_icon__1_;
                btnSaler.Font = new System.Drawing.Font(btnSaler.Font.FontFamily, 12);
                btnCart.Location = new Point(Loction_btnCart.X, Loction_btnCart.Y);
                btnAccount.Location = new Point(Loction_btnAccount.X, Loction_btnAccount.Y);
                pnlDropDown.Height -= 10;
                if (pnlDropDown.Size == pnlDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void DongkhungPanel()
        {
            if (isCollapsed == false)
            {
                timer1.Start();
            }
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tbpManage"];
            btnManage.BackColor = Color.Goldenrod;
            btnHistory_Sale.BackColor = Color.Gold;
            btnSale.BackColor = Color.Gold;
            btnSaler.BackColor = Color.Gold;

            //Xu li Bang chart Lợi Nhuận
            try
            {
                foreach (var series in chartRevenue.Series)
                {
                    series.Points.Clear();
                }
                conn.Open();

                string sqlStr = string.Format("SELECT dateBuy,SUM(resellProduct) AS total_amount_per_day,Sum(quantityBuy) as total_quantity_per_day\r\nFROM DonHang JOIN inforProduct \r\non DonHang.idProduct = inforProduct.idProduct\r\nwhere idSeller ='{0}'\r\nGROUP BY dateBuy", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        chartRevenue.Series["Số lượng"].Points.AddXY(((DateTime)reader["dateBuy"]).ToString("dd/MM/yyyy"), reader["total_quantity_per_day"].ToString());
                        chartRevenue.Series["Lợi nhuận"].Points.AddXY(((DateTime)reader["dateBuy"]).ToString("dd/MM/yyyy"), reader["total_amount_per_day"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }


            //Xu li Bang chart Loại hàng đã bán
            try
            {
                foreach (var series in chartTypeProduct.Series)
                {
                    series.Points.Clear();
                }
                conn.Open();

                string sqlStr = string.Format("SELECT typeProduct,sum(quantityBuy) as SOLUONG\r\nFROM DonHang JOIN inforProduct \r\non DonHang.idProduct = inforProduct.idProduct\r\nwhere idSeller = '{0}'\r\nGROUP BY typeProduct", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        chartTypeProduct.Series["Series"].Points.AddXY(reader["typeProduct"], reader["SOLUONG"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        }


        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            Form f = new SelectDate();
            f.Show();
        }


        private void btnHistory_Sale_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tbp_History_Sell"];
            btnManage.BackColor = Color.Gold;
            btnHistory_Sale.BackColor = Color.Goldenrod;
            btnSale.BackColor = Color.Gold;
            btnSaler.BackColor = Color.Gold;

        }

        private void btnToday_time_Click(object sender, EventArgs e)
        {
            //Hiện ngày tháng năm
            lbDateStart_Sold.Text = DateTime.Now.ToString("d/M/yyyy");
            lbDateEnd_Sold.Text = DateTime.Now.ToString("d/M/yyyy");


            //Tính thông số của Total Buyer 
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(DISTINCT idBuyer) AS SoNguoiMua FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy = CONVERT(date, GETDATE()) ", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberBuyer.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
            //Tính thông số của Product 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(idBuyer) AS SoSPSell FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy = CONVERT(date, GETDATE()) ", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberProduct.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }


            //Tính thông số của Total Profit 
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SUM(resellProduct) AS Tongsobai FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblProfit.Text = reader.GetValue(0).ToString();
                        if (lblProfit.Text == "")
                            lblProfit.Text = "0";
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btn7day_time_Click(object sender, EventArgs e)
        {
            DateTime ngayThangHienTai = DateTime.Now;

            // Trừ đi 7 ngày để lấy ngày tháng năm 7 ngày trước
            DateTime ngayThangTruoc = ngayThangHienTai.AddDays(-7);

            lbDateStart_Sold.Text = ngayThangTruoc.ToString("d/M/yyyy");
            lbDateEnd_Sold.Text = DateTime.Now.ToString("d/M/yyyy");

            //Tính thông số của Total Buyer 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(DISTINCT idBuyer) AS SoNguoiMua FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(DAY, -7, GETDATE()) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberBuyer.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

            //Tính thông số của Product 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(idBuyer) AS SoSPSell FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(DAY, -7, GETDATE()) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberProduct.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }


            //Tính thông số của Total Profit 
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SUM(resellProduct) AS Tongsobai  FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(DAY, -7, GETDATE()) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblProfit.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn30day_time_Click(object sender, EventArgs e)
        {
            DateTime ngayThangHienTai = DateTime.Now;

            DateTime ngayThangTruoc = ngayThangHienTai.AddDays(-30);

            lbDateStart_Sold.Text = ngayThangTruoc.ToString("d/M/yyyy");
            lbDateEnd_Sold.Text = DateTime.Now.ToString("d/M/yyyy");


            //Tính thông số của Total Buyer 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(DISTINCT idBuyer) AS SoNguoiMua FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(DAY, -30, GETDATE()) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberBuyer.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

            //Tính thông số của Product 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(idBuyer) AS SoSPSell FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(DAY, -30, GETDATE()) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberProduct.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

            //Tính thông số của Total Profit 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SUM(resellProduct) AS Tongsobai  FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(DAY, -30, GETDATE()) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblProfit.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn1moth_time_Click(object sender, EventArgs e)
        {
            DateTime ngayThangHienTai = DateTime.Today;

            // Lấy ngày đầu tiên của tháng này
            DateTime ngayDauThang = new DateTime(ngayThangHienTai.Year, ngayThangHienTai.Month, 1);


            lbDateStart_Sold.Text = ngayDauThang.ToString("d/M/yyyy");
            lbDateEnd_Sold.Text = DateTime.Now.ToString("d/M/yyyy");


            //Tính thông số của Total Buyer 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(DISTINCT idBuyer) AS SoNguoiMua FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberBuyer.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }


            //Tính thông số của Product 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(idBuyer) AS SoSPSell FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberProduct.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }


            //Tính thông số của Total Profit 
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SUM(resellProduct) AS Tongsobai  FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) and dateBuy <= CONVERT(date, GETDATE())", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblProfit.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

        }

        public void ConfirmDay(object sender, EventArgs e)
        {
            DateTime ngayBatDauStr = DateTime.ParseExact(lbDateStart_Sold.Text, "dd/MM/yyyy", null);
            DateTime ngayKetThucStr = DateTime.ParseExact(lbDateEnd_Sold.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //Tính thông số của Total Buyer 
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(DISTINCT idBuyer) AS SoNguoiMua FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy <= '{1}' and  dateBuy >= '{2}'", ID, ngayKetThucStr, ngayBatDauStr);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberBuyer.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }


            //Tính thông số của Product 

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT COUNT(idBuyer) AS SoSPSell FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy <= '{1}' and  dateBuy >= '{2}'", ID, ngayKetThucStr, ngayBatDauStr);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumberProduct.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }


            //Tính thông số của Total Profit 
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SUM(resellProduct) AS Tongsobai  FROM DonHang INNER JOIN inforProduct ON DonHang.idProduct = inforProduct.idProduct where inforProduct.idSeller = '{0}' and dateBuy <= '{1}' and  dateBuy >= '{2}'", ID, ngayKetThucStr, ngayBatDauStr);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblProfit.Text = reader.GetValue(0).ToString();
                        if (lblProfit.Text == "")
                            lblProfit.Text = "0";
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            FAddressInfor fAddressInfor = new FAddressInfor();
            fAddressInfor.ShowDialog();
        }

        private void cbbTypeAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * from addressInfor Where ID = '{0}' and Type = N'{1}'", ID, cbbTypeAddress.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbNameOrder.Texts = reader.GetString(3);
                        tbPhoneOrder.Texts = reader.GetString(2);
                        tbEmailOrder.Texts = reader.GetString(4);
                        tbAddressOrder.Texts = reader.GetString(1);
                    }
                    reader.Close();
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void getTypeAddress()
        {
            cbbTypeAddress.Items.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select Type from addressInfor Where ID = '{0}'", ID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbbTypeAddress.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
