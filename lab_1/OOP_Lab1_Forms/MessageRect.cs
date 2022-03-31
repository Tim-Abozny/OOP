using System;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class MessageRect : Form
    {
        public MessageRect()
        {
            InitializeComponent();
        }
        public static string exMessage;
        private void MessageRect_Load(object sender, EventArgs e)
        {
            exceptionLabel.Text = exMessage;
            this.Width = exceptionLabel.Width + 20;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
