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
    public partial class BookingUserControl : UserControl
    {
        public BookingUserControl()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logged out of your account.");
            Application.Exit();
        }

        private void guestaddbutton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            BOOKING form = new BOOKING();
            form.ShowDialog();
        }
    }
}
