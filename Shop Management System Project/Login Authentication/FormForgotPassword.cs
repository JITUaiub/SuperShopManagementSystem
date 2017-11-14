using System;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Login_Authentication
{
    public partial class FormForgotPassword : Form
    {
        private Boolean _flag;
        private int _x, _y;
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _flag = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _flag = true;
            _x = e.X;
            _y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(_flag)
            {
                SetDesktopLocation(Cursor.Position.X - _x, Cursor.Position.Y - _y);
            }
        }
    }
}
