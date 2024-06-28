using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_OOP
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoad.Width += 6;
            if (panelLoad.Width>= 521)
            {
                timer1.Stop();
                this.Hide();

                //MessageBox.Show("   Welcome to Flora Suites\n   Hotel Management System!");
                GuestTab form = new GuestTab();
                form.ShowDialog();

            }
           
        }
    }
}
