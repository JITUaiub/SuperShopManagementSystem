using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormAddProducts : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private readonly SqlConnection _con = new SqlConnection(Connectionstring);
        private SqlDataAdapter _sda;
        private DataTable _dt;

        public FormAddProducts()
        {
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();
            comboBoxProductUnit.SelectedItem = "Kg";
            comboBoxProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            _con.Open();
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtAvailableAmount.Text = "";
            txtPerUnitPrice.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
            _sda = new SqlDataAdapter(@"insert into products values (1, '" + comboBoxProductUnit.Text + "', " + txtAvailableAmount.Text + "," + " '" + comboBoxProductUnit.Text + "', " + txtPerUnitPrice.Text + "')", _con);
            //Showing Previous Items
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", _con);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewProducts.DataSource = _dt;

            if (txtProductName.Text == "" || txtPerUnitPrice.Text == "" || txtAvailableAmount.Text == "")
            {
                MessageBox.Show(@"Please fill all values", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText =
                        "Insert into [Products](name, quantity, unit, per_unit_price) values (@nm, @qua, @unit, @pup)"
                };
                cmd.Parameters.AddWithValue("@nm", txtProductName.Text);
                cmd.Parameters.AddWithValue("@qua", txtAvailableAmount.Text);
                cmd.Parameters.AddWithValue("@unit", comboBoxProductUnit.Text);
                cmd.Parameters.AddWithValue("@pup", txtPerUnitPrice.Text);
                cmd.Connection = _con;
                cmd.ExecuteNonQuery();
                MessageBox.Show(@"Product Added", @"Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Update Previous Items 
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", _con);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewProducts.DataSource = _dt;
        }

        private void FormAddProducts_Load(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewProducts.DataSource = _dt;

        }

        private void txtPerUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (txtDecimal != null && (e.KeyChar == '.' && txtDecimal.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void txtAvailableAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (txtDecimal != null && (e.KeyChar == '.' && txtDecimal.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

    }
}
