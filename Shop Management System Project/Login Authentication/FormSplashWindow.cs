using System;
using System.Windows.Forms;

namespace Shop_Management_System_Project.Login_Authentication
{
    public partial class FormSplashWindow : Form
    {
        private Boolean _flag;
        private int _x, _y;
        public FormSplashWindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value >= 100)
            {
                timer1.Stop();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _flag = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _flag = true;
            _x = e.X;
            _y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(_flag)
            {
                SetDesktopLocation(Cursor.Position.X - _x, Cursor.Position.Y - _y);
            }
        }
    }
}
