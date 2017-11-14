using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormManageProducts : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private readonly SqlConnection _con = new SqlConnection(Connectionstring);
        private SqlDataAdapter _sda;
        public SqlCommandBuilder Scb { get; private set; }
        private DataTable _dt;
        public FormManageProducts()
        {
            _con.Open();
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();
            comboBoxSearch.SelectedItem = "ID";
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewProducts.DataSource = _dt; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Scb = new SqlCommandBuilder(_sda);
            _sda.Update(_dt);
            MessageBox.Show(@"Data Updated", @"Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormManageProducts_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn dc in dataGridViewProducts.Columns)
            {
                dc.ReadOnly = !dc.Index.Equals(0);
            }

            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewProducts.DataSource = _dt; 
        }

        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.Text == @"ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS where id like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);  
                dataGridViewProducts.DataSource = dt;
            }
            else if (comboBoxSearch.Text == @"Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS where name like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (dataGridViewProducts.CurrentRow != null)
                cmd.CommandText = "DELETE FROM Products WHERE id='" + dataGridViewProducts.CurrentRow.Cells[0].Value +
                                  "'";
            cmd.Connection = _con;
            cmd.ExecuteNonQuery();

            //Update Previous Items
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", _con);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewProducts.DataSource = _dt;
            MessageBox.Show(@"Product Deleted", @"Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
