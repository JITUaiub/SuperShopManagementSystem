using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Shop_Management_System_Project.Information_Classes;
using Shop_Management_System_Project.Panel_Forms;

namespace Shop_Management_System_Project.User_Panels
{
    public partial class FormAdminPanel : Form
    {
        public string Username { get; set; }

        // Panel Declarations
        private readonly FormManageUserAdmin _manageUser;
        private readonly FormManageCustomer _manageCustomer = new FormManageCustomer();
        private readonly FormHomePageAdmin _homePage;
        private readonly FormAbout _about = new FormAbout();
        private readonly FormAddProducts _addProducts = new FormAddProducts();
        private readonly FormSellProducts _sellProducts;
        private readonly FormManageProducts _manageProducts = new FormManageProducts();
        private readonly FormManageEmployees _manageEmployees = new FormManageEmployees();
        private readonly FormInventory _inventory = new FormInventory();
        private readonly FormSalesReport _salesReport = new FormSalesReport();
        private readonly FormDatabaseBackup _databaseBackup = new FormDatabaseBackup();
        private readonly FormDigitalClock _digitalClock = new FormDigitalClock();
        private readonly FormCompanyInfo _companyInfo = new FormCompanyInfo();

        // Objects 
        private readonly User _user = new User("Test", "Test", "Test", "Test", "Test", "Test", "Test", "Admin");

        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private Boolean _flag;
        private int _x, _y;
        public FormAdminPanel(string username)
        {
            Username = username;
            //Connecting Database
            _manageUser = new FormManageUserAdmin(Username);
            _homePage = new FormHomePageAdmin(Username);
            _sellProducts = new FormSellProducts(Username);
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM [User] where username = '" + Username + "'";
                
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    //cmd.Parameters.AddWithValue("@nam", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            //Adding Admin Data
                            _user.UserName = reader["username"].ToString();
                            _user.Password = reader["password"].ToString();
                            _user.Name = reader["name"].ToString();
                            _user.Email = reader["email"].ToString();
                            _user.Address = reader["address"].ToString();
                            _user.ContactNo = reader["contact_no"].ToString();
                            _user.JoinDate = reader["join_date"].ToString();
                            _user.AccountType = reader["account_type"].ToString();
                        }
                    }
                }
            }

            // Show Admin Info

            InitializeComponent();

            lblApplicationModeType.Text = @"Home Menu";
            lblAdminName.Text = _user.Name;
            lblAdminEmail.Text = @"Email: " + _user.Email;
            lblAdminContactNumber.Text = @"Contact Number: " + _user.ContactNo;
            lblJoinedDate.Text = @"Joined Date: " +  _user.JoinDate;
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_homePage);
            _homePage.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _flag = true;
            _x = e.X;
            _y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(_flag)
                SetDesktopLocation(Cursor.Position.X - _x - 270, Cursor.Position.Y - _y);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Home Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_homePage);
            _homePage.Show();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Add Products Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_addProducts);
            _addProducts.Show();
        }

        private void btnSellProducts_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Sell Products Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_sellProducts);
            _sellProducts.Show();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Manage Products Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_manageProducts);
            _manageProducts.Show();
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Manage Employees Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_manageEmployees);
            _manageEmployees.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Inventory Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_inventory);
            _inventory.Show();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Sales Report Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_salesReport);
            _salesReport.Show();
        }

        private void btnDatabaseBackup_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Database Backup Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_databaseBackup);
            _databaseBackup.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"About Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_about);
            _about.Show();
        }

        private void timerSystemTime_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            lblSystemDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _flag = false;
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Manage Customer Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_manageCustomer);
            _manageCustomer.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAdminName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblJoinedDate_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminName_Click(object sender, EventArgs e)
        {

        }

        private void lblSystemTime_Click(object sender, EventArgs e)
        {

        }

        private void lblSystemDate_Click(object sender, EventArgs e)
        {

        }

        private void lblSystemDate1_Click(object sender, EventArgs e)
        {

        }

        private void lblSystemTime1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSystemTime_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblApplicationModeType_Click(object sender, EventArgs e)
        {

        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void panelAdminName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblApplicationModeType.Text = @"Edit Profile Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_manageUser);
            _manageUser.Show();
        }

        private void panelSystemTime_DoubleClick(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"System Time Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_digitalClock);
            _digitalClock.Show();
        }
        
        private void btnCompanyinfo_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Company Information Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_companyInfo);
            _companyInfo.Show();
        }
    }
}
