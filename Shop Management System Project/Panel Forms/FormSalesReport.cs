using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormSalesReport : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        readonly SqlConnection _con = new SqlConnection(Connectionstring);
        SqlDataAdapter _sda;
        DataTable _dt;
        public FormSalesReport()
        {
            _con.Open();
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();
            comboBoxSearch.SelectedItem = "Invoice Number";
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridViewSalesReport.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.Text == @"Invoice Number")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView] where invoice_number like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSalesReport.DataSource = dt;
            }
            else if (comboBoxSearch.Text == @"Customer Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView] where customer_name like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSalesReport.DataSource = dt;
            }
            else if (comboBoxSearch.Text == @"Employee Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView] where employee_name like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSalesReport.DataSource = dt;
            }
            else if (comboBoxSearch.Text == @"Product Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView] where product_name like '%" + txtSearchItems.Text + "%'", _con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSalesReport.DataSource = dt;
            }
        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView]", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewSalesReport.DataSource = _dt; 
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView]", _con);

            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewSalesReport.DataSource = _dt; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Refund Product Code here
            string mainQuantity = "";
            string quantity = "";
            string productName = "";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                if (dataGridViewSalesReport.CurrentRow != null)
                {
                    string query = "select product_name, quantity from [dbo].[salesReportView] where [invoice_number] = '" + dataGridViewSalesReport.CurrentRow.Cells[3].Value + "'";


                    using (SqlCommand cmda = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmda.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                quantity = reader["quantity"].ToString();
                                productName = reader["product_name"].ToString();
                            }
                        }
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "select quantity from [dbo].[products] where [name] = '" + productName + "'";


                using (SqlCommand cmda = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mainQuantity = reader["quantity"].ToString();
                        }
                    }
                }
            }
            string totalQuantity = (Convert.ToInt32(mainQuantity) + Convert.ToInt32(quantity)).ToString();
            SqlCommand cmd2 = new SqlCommand
            {
                CommandText = "update products set quantity = '" + totalQuantity + "' where name = '" + productName +
                              "'",
                Connection = _con
            };
            cmd2.ExecuteNonQuery();
            
            // Delete Transection
            if (dataGridViewSalesReport.CurrentRow != null)
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "DELETE FROM [dbo].[sales_Report] WHERE [invoice_number] ='" +
                                  dataGridViewSalesReport.CurrentRow.Cells[3].Value + "'",
                    Connection = _con
                };
                cmd.ExecuteNonQuery();
            }

            if (dataGridViewSalesReport.CurrentRow != null)
            {
                SqlCommand cmd1 = new SqlCommand
                {
                    CommandText = "DELETE FROM [dbo].[items] WHERE [invoice_number] ='" +
                                  dataGridViewSalesReport.CurrentRow.Cells[3].Value + "'",
                    Connection = _con
                };
                cmd1.ExecuteNonQuery();
            }

            _sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView]", _con);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridViewSalesReport.DataSource = _dt;
            MessageBox.Show(@"Transection Deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}