using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormHomePageEmployee : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private readonly string _employeeName;
        public FormHomePageEmployee(string username)
        {
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT name FROM [User] where username = '" + username + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _employeeName = reader["name"].ToString();
                        }
                    }
                }
            }
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();
            lblAdminName.Text = @"Welcome, " + _employeeName;
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void FormHomePageEmployee_Load(object sender, EventArgs e)
        {
            salesReportViewTableAdapter.Fill(superShopDatabaseDataSet_LatestTransection.salesReportView);
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            salesReportViewTableAdapter.Fill(superShopDatabaseDataSet_LatestTransection.salesReportView);
        }
    }
}
