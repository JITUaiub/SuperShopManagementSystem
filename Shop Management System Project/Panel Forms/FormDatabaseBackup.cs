using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormDatabaseBackup : Form
    {
        const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private SqlConnection _conn;
        private SqlCommand _command;
        private string _query = "";

        public FormDatabaseBackup()
        {
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

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = @"Backup Files(*.bak)|*.bak|All Files(*.*)|*.*",
                FilterIndex = 0
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRestoreLocation.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                _conn = new SqlConnection(Connectionstring);
                _conn.Open();
                //Database Name
                _query = "BACKUP DATABASE SuperShopDatabase TO DISK = '" + txtBackupLocation.Text + "\\SuperShopDatabase - " + DateTime.Now.Ticks.ToString() + ".bak'";

                _command = new SqlCommand(_query, _conn);
                _command.ExecuteNonQuery();
                MessageBox.Show(@"Successfuly database backup completed.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                _conn = new SqlConnection(Connectionstring);
                _conn.Open();

                string sqlStmt2 = "ALTER DATABASE SuperShopDatabase SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                SqlCommand bu2 = new SqlCommand(sqlStmt2, _conn);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE SuperShopDatabase FROM DISK='" + txtRestoreLocation.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, _conn);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = "ALTER DATABASE SuperShopDatabase SET MULTI_USER";
                SqlCommand bu4 = new SqlCommand(sqlStmt4, _conn);
                bu4.ExecuteNonQuery();


                MessageBox.Show(@"Successfully restored data from database");
                MessageBox.Show(@"Now the application will restart");
                _conn.Close();

                //Restart Aplication
                ProcessStartInfo info =
                    new ProcessStartInfo
                    {
                        Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    };
                Process.Start(info);
                Application.Exit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
