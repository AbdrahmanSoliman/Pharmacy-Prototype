using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (username.Text == "kkk" && password.Text == "777")
            {
                Program.f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("  Invalid username or password");
            }
            username.Text = "";
            password.Text = "";
        }
    }
}
