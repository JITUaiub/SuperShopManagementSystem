using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Shop_Management_System_Project.Information_Classes;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormManageEmployees : Form
    {
        private User _user;
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private readonly SqlConnection _con = new SqlConnection(Connectionstring);
        private SqlDataAdapter _sda;
        public SqlCommandBuilder Scb { get; private set; }
        private DataTable _dt;
        public DataGridViewRow DgvRow { get; private set; }
        private int _employeeCount;
        public FormManageEmployees()
        {
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM [User] where account_type = 'Employee'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            //Adding Customer Data
                            _user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                        }
                    }
                }
            }

            lblEmployeeUserName.Text = _user.UserName;
            lblEmployeeContactNumber.Text = _user.ContactNo;
            lblEmployeeName.Text = _user.Name;
            lblEmployeeAddress.Text = _user.Address;

            comboBoxSearch.SelectedItem = "Username";
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;

            _con.Open();
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string queryS = "SELECT USERNAME FROM [User] WHERE USERNAME = '" + txtUsername.Text.Trim().ToLower() + "'";
            using (SqlCommand cmd = new SqlCommand(queryS, _con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        _employeeCount++;
                    }
                }
            }

            if (_employeeCount == 0)
            {
                //Adding new Employee

                if (txtUsername.Text == "" || txtPassword.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtContactNo.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show(@"Please fill all values", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "Insert into [User] values (@un, @pass, @n, @em, @add, @cont, @join, 'Employee')"
                    };
                    cmd.Parameters.AddWithValue("@un", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@cont", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@join", joinDate.Value.ToString(CultureInfo.InvariantCulture));

                    cmd.Connection = _con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"New employee added.", @"Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    string query = "SELECT * FROM [User] where account_type = 'Employee'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                //Adding Customer Data
                                _user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)); 
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(@"You already have an employee with that username.", @"Employee Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _employeeCount = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
        }

        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.Text == @"Username")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where username like '%" + txtSearchItems.Text + "%' and account_type = 'Employee'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewEmployee.DataSource = dt;
            }
            else if (comboBoxSearch.Text == @"Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where name like '%" + txtSearchItems.Text + "%' and account_type = 'Employee'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewEmployee.DataSource = dt;
            }
            else if (comboBoxSearch.Text == @"Contact Number")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where contact_no like '%" + txtSearchItems.Text + "%' and account_type = 'Employee'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewEmployee.DataSource = dt;
            }
        }

        private void FormManageEmployees_Load(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where account_type = 'Employee'", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewEmployee.DataSource = _dt;
        }

        private void dataGridViewEmployee_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DgvRow = new DataGridViewRow();
                if (dataGridViewEmployee.CurrentRow != null)
                {
                    lblEmployeeUserName.Text = dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();
                    lblEmployeeName.Text = dataGridViewEmployee.CurrentRow.Cells[1].Value.ToString();
                    lblEmployeeAddress.Text = dataGridViewEmployee.CurrentRow.Cells[3].Value.ToString();
                    lblEmployeeContactNumber.Text = dataGridViewEmployee.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error Loading Data", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            Scb = new SqlCommandBuilder(_sda);
            _sda.Update(_dt);
            MessageBox.Show(@"Data Updated", @"Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where account_type = 'Employee'", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewEmployee.DataSource = _dt;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (dataGridViewEmployee.CurrentRow != null)
                cmd.CommandText = "DELETE FROM [User] WHERE username='" +
                                  dataGridViewEmployee.CurrentRow.Cells[0].Value + "' and account_type = 'Employee'";
            cmd.Connection = _con;
            cmd.ExecuteNonQuery();

            _sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where account_type = 'Employee'", _con);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewEmployee.DataSource = _dt;
            MessageBox.Show(@"Employee deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
