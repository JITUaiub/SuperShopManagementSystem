using System;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormDigitalClock : Form
    {
        public FormDigitalClock()
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

        private void timerLiveTime_Tick(object sender, EventArgs e)
        {
            lblHourMinute.Text = DateTime.Now.ToString("h:mm:ss");
            lblSecond.Text = DateTime.Now.ToString("tt");
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }
    }
}
