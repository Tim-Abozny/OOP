using System;
using System.Windows.Forms;

namespace system_ATM
{
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            MyProgress.Value = start;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
