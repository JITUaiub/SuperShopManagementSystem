using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormInventory : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private readonly SqlConnection _con = new SqlConnection(Connectionstring);
        private SqlDataAdapter _sda;
        private DataTable _dt;
        public FormInventory()
        {
            _con.Open();
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();
            comboBoxSearch.SelectedItem = "ID";
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridViewProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void txtSearchItems_TextChanged_1(object sender, EventArgs e)
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

        private void FormInventory_Load(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewProducts.DataSource = _dt; 
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewProducts.DataSource = _dt; 
        }
    }
}
