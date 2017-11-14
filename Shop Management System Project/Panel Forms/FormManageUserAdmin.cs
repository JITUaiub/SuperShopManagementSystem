using System;
using  System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using Shop_Management_System_Project.Information_Classes;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormManageUserAdmin : Form
    {
        private readonly User _user = new User("Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test");
        private readonly string _username;
        private const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        public FormManageUserAdmin(string username)
        {
            _username = username;

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM [User] WHERE USERNAME = '" + _username + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
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

            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            };
            Process.Start(info);
            Application.Exit();
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            
            // Name
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "UPDATE [User] SET name = '" + ((txtName.Text == "") ? _user.Name : txtName.Text) + "' WHERE username = @nam";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@nam", _username);
                    cmd.ExecuteNonQuery();
                }

            }
            //Password
            string currentPassword = "";

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT password FROM [User] where username = '" + _username + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currentPassword = reader["password"].ToString();
                        }
                    }
                }
            }

            if (currentPassword == txtCurrentPassword.Text)
            {
                if (txtNewPassword.Text == "")
                {
                    MessageBox.Show(@"New password required", @"Required New Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    string query = "UPDATE [User] SET password = '" + ((txtNewPassword.Text == "") ? _user.Password : txtNewPassword.Text) + "' WHERE username = @nam";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@nam", _username);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                if (txtCurrentPassword.Text != "")
                {
                    MessageBox.Show(@"Wrong current password", @"Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //Email
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "UPDATE [User] SET email = '" + ((txtEmail.Text == "") ? _user.Email : txtEmail.Text) + "' WHERE username = @nam";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@nam", _username);
                    cmd.ExecuteNonQuery();
                }

            }
            //Address
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "UPDATE [User] SET address = '" + ((txtAddress.Text == "") ? _user.Address : txtAddress.Text) + "' WHERE username = @nam";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@nam", _username);
                    cmd.ExecuteNonQuery();
                }

            }

            //Contact No
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "UPDATE [User] SET contact_no = '" + ((txtContactNo.Text == "") ? _user.ContactNo : txtContactNo.Text) + "' WHERE username = @nam";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@nam", _username);
                    cmd.ExecuteNonQuery();
                }

            }

            MessageBox.Show(@"Updated. Restart application or Sign out to look for changes.", @"Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "" && (txtCurrentPassword.Text == "") && txtEmail.Text == "" && txtAddress.Text == "" && txtContactNo.Text == "")
            {
                btnUpdateAll.Enabled = false;
            }
            else
            {
                btnUpdateAll.Enabled = true;
            }
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "" && (txtCurrentPassword.Text == "") && txtEmail.Text == "" && txtAddress.Text == "" && txtContactNo.Text == "")
            {
                btnUpdateAll.Enabled = false;
            }
            else
            {
                btnUpdateAll.Enabled = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "" && (txtCurrentPassword.Text == "") && txtEmail.Text == "" && txtAddress.Text == "" && txtContactNo.Text == "")
            {
                btnUpdateAll.Enabled = false;
            }
            else
            {
                btnUpdateAll.Enabled = true;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "" && (txtCurrentPassword.Text == "") && txtEmail.Text == "" && txtAddress.Text == "" && txtContactNo.Text == "")
            {
                btnUpdateAll.Enabled = false;
            }
            else
            {
                btnUpdateAll.Enabled = true;
            }
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "" && (txtCurrentPassword.Text == "") && txtEmail.Text == "" && txtAddress.Text == "" && txtContactNo.Text == "")
            {
                btnUpdateAll.Enabled = false;
            }
            else
            {
                btnUpdateAll.Enabled = true;
            }
        }
    }
}
