using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Shop_Management_System_Project.Information_Classes;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormManageCustomer : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private readonly SqlConnection _con = new SqlConnection(Connectionstring);
        private SqlDataAdapter _sda;
        public SqlCommandBuilder Scb { get; private set; }
        private DataTable _dt;
        public DataGridViewRow DgvRow { get; private set; }
        private readonly CustomerInfo _customerInfo;
        public FormManageCustomer()
        {
            _con.Open();
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM CUSTOMER";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Adding Customer Data
                            _customerInfo = new CustomerInfo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                    }
                }
            }

            InitializeComponent();

            lblCustomerID.Text = _customerInfo.CustomerId.ToString();
            lblCustomerName.Text = _customerInfo.Name;
            lblContactNumber.Text = _customerInfo.ContactNo;
            lblCustomerAddress.Text = _customerInfo.Address;

            comboBoxSearch.SelectedItem = "ID";
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.Text == @"ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer where id like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewCustomer.DataSource = dt;
            }
            else if (comboBoxSearch.Text == @"Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer where name like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewCustomer.DataSource = dt;
            }
            else if (comboBoxSearch.Text == @"Contact Number")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer where contact_number like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewCustomer.DataSource = dt;
            }
        }

        private void FormManageCustomer_Load(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewCustomer.DataSource = _dt; 
        }

        private void dataGridViewCustomer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DgvRow = new DataGridViewRow();
                if (dataGridViewCustomer.CurrentRow != null)
                {
                    lblCustomerID.Text = dataGridViewCustomer.CurrentRow.Cells[0].Value.ToString();
                    lblCustomerName.Text = dataGridViewCustomer.CurrentRow.Cells[1].Value.ToString();
                    lblCustomerAddress.Text = dataGridViewCustomer.CurrentRow.Cells[2].Value.ToString();
                    lblContactNumber.Text = dataGridViewCustomer.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception )
            {
                MessageBox.Show(@"Error Loading Data", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Scb = new SqlCommandBuilder(_sda);
            _sda.Update(_dt);
            MessageBox.Show(@"Data Updated", @"Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewCustomer.DataSource = _dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (dataGridViewCustomer.CurrentRow != null)
                cmd.CommandText = "DELETE FROM Customer WHERE id='" + dataGridViewCustomer.CurrentRow.Cells[0].Value +
                                  "'";
            cmd.Connection = _con;
            cmd.ExecuteNonQuery();
            
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer", _con);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewCustomer.DataSource = _dt;
            MessageBox.Show(@"Customer Deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewCustomer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && !string.IsNullOrWhiteSpace(dataGridViewCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                dataGridViewCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = Color.Black, BackColor = Color.White };
            }
            else
            {
                dataGridViewCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = dataGridViewCustomer.DefaultCellStyle;
            }
        }
    }
}
