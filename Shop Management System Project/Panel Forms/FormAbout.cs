using System;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormAbout : Form
    {
        public FormAbout()
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

        private void btnFacebookJitu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/nashid.jitu");
        }

        private void btnFacebookShuvo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/rpm.shuvo");
        }

        private void btnFacebookSakir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/mehdihassans1");
        }

        private void btnFacebookNoushin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/noushin.jannat.3");
        }
    }
}
