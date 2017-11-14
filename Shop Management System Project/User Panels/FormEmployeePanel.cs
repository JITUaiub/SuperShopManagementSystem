using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Shop_Management_System_Project.Information_Classes;
using Shop_Management_System_Project.Panel_Forms;

namespace Shop_Management_System_Project.User_Panels
{
    public partial class FormEmployeePanel : Form
    {
        // Panel Declarations
        private readonly FormManageUserEmployee _manageUser;
        private readonly FormManageCustomer _manageCustomer = new FormManageCustomer();
        private readonly FormHomePageEmployee _homePage;
        private readonly FormAbout _about = new FormAbout();
        private readonly FormSellProducts _sellProducts;
        private readonly FormInventory _inventory = new FormInventory();
        private readonly FormDigitalClock _digitalClock = new FormDigitalClock();
        private readonly FormSalesReport _salesReport = new FormSalesReport();

        private readonly User _user = new User("Test", "Test", "Test", "Test", "Test", "Test", "Test", "Employee");

        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private Boolean _flag;
        private int _x, _y;
        public string Username { get; set; }

        public FormEmployeePanel(string username)
        {
            Username = username;
            _homePage = new FormHomePageEmployee(Username);
            _manageUser = new FormManageUserEmployee(Username);
            _sellProducts = new FormSellProducts(Username);

            //Connecting Database
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {

                string query = "SELECT * FROM [User] where username = '" + Username + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        while(reader.Read())
                        {
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

            // Show Employee Info

            InitializeComponent();

            lblApplicationModeType.Text = @"Home Menu";
            lblAdminName.Text = _user.Name;
            lblAdminEmail.Text = @"Email: " + _user.Email;
            lblAdminContactNumber.Text = @"Contact Number: " + _user.ContactNo;
            lblJoinedDate.Text = @"Joined Date: " + _user.JoinDate;
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

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _flag = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_flag)
                SetDesktopLocation(Cursor.Position.X - _x - 270, Cursor.Position.Y - _y);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _flag = true;
            _x = e.X;
            _y = e.Y;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Home Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_homePage);
            _homePage.Show();
        }

        private void btnSellProducts_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Sell Products Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_sellProducts);
            _sellProducts.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Inventory Menu";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_inventory);
            _inventory.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"About";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_about);
            _about.Show();
        }

        private void timerSystemTime_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            lblSystemDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Manage Customer";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_manageCustomer);
            _manageCustomer.Show();
        }

        private void panelAdminName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAdminName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblApplicationModeType.Text = @"Edit Profile";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_manageUser);
            _manageUser.Show();
        }

        private void panelSystemTime_DoubleClick(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"System Time";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_digitalClock);
            _digitalClock.Show();
        }
        
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            lblApplicationModeType.Text = @"Sales Report";
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(_salesReport);
            _salesReport.Show();
        }

    }
}
