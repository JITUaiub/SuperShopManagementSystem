using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Shop_Management_System_Project.Information_Classes;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormCompanyInfo : Form
    {
        private readonly CompanyInfo _companyInfo = new CompanyInfo("Test", "Test");
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        public FormCompanyInfo()
        {
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM [Company_Info]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            _companyInfo.Name = reader["company_name"].ToString();
                            _companyInfo.Address = reader["address"].ToString();
                        }
                    }
                }
            }

            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();

            lblCompanyName.Text = _companyInfo.Name;
            lblCompanyAddress.Text = _companyInfo.Address;
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            //Company Name
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "UPDATE [Company_Info] SET company_name = '" + ((txtCompanyName.Text == "") ? _companyInfo.Name : txtCompanyName.Text) + "'";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

            }
            //Company Address
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "UPDATE [Company_Info] SET address = '" + ((txtCompanyAddress.Text == "") ? _companyInfo.Address : txtCompanyAddress.Text) + "'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

            }
            MessageBox.Show(@"Updated. Restart application or Sign out to look for changes.", @"Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            btnUpdateAll.Enabled = txtCompanyName.Text != "";
        }

        private void txtCompanyAddress_TextChanged(object sender, EventArgs e)
        {
            btnUpdateAll.Enabled = txtCompanyAddress.Text != "";
        }
    }
}
