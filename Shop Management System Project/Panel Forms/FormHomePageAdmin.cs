using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormHomePageAdmin : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private readonly string _adminName;
        public FormHomePageAdmin(string username)
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
                            _adminName = reader["name"].ToString();
                        }
                    }
                }
            }
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            InitializeComponent();
            lblAdminName.Text = @"Welcome, " +  _adminName;
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void FormHomePageAdmin_Load(object sender, EventArgs e)
        {
            salesReportViewTableAdapter.Fill(superShopDatabaseDataSet9.salesReportView);
            
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            salesReportViewTableAdapter.Fill(superShopDatabaseDataSet9.salesReportView);
        }

    }
}
