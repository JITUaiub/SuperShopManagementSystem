using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Shop_Management_System_Project.Information_Classes;
using Shop_Management_System_Project.User_Panels;

namespace Shop_Management_System_Project.Login_Authentication
{
    public partial class FormLogOn : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private Boolean _flag;
        private int _x, _y;
        private int _loginCount;
        private readonly User _user = new User("Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test");

        public FormLogOn()
        {
            Thread thread = new Thread(StartSplash);
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread.Abort();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void StartSplash()
        {
            Application.Run(new FormSplashWindow());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _flag = false;
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
            {
                SetDesktopLocation(Cursor.Position.X - _x, Cursor.Position.Y - _y);
            }
        }

        private void FormLogOn_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
        private void LoginUser()
        {
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM [User] WHERE USERNAME = '" + txtUserName.Text.Trim() + "' AND PASSWORD = '" +
                               txtPassword.Text.Trim() + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                        conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _loginCount++;
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

            if (_loginCount == 1 && _user.AccountType == "Admin")
            {
                Hide();
                FormAdminPanel adminPanel = new FormAdminPanel(txtUserName.Text);
                adminPanel.Show();
                Hide();
            }
            else if (_loginCount == 1 && _user.AccountType == "Employee")
            {
                Hide();
                FormEmployeePanel employeePanel = new FormEmployeePanel(txtUserName.Text);
                employeePanel.Show();
            }
            else
            {
                MessageBox.Show(@"Access Denied", @"Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LoginUser();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }
    }
}
