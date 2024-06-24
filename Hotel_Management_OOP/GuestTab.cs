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
    public partial class GuestTab : Form
    {
        public GuestTab()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //RoomsTab form = new RoomsTab();
            //form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BookingTab form = new BookingTab();
            // form.ShowDialog();
        }
        private void guestaddbutton_Click(object sender, EventArgs e)
        {
            // CheckIfDataExists();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BillingAndInvoicing form = new BillingAndInvoicing();
            form.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillingAndInvoicing form = new BillingAndInvoicing();
            form.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private static void button6_Click(object sender, EventArgs e)
        {
            //HomeUserControl.Hide();
            //UserControl1.Show();
            //UserControl1.BringToFront();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Booking_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You are logged out of your account.");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //UserControl.Visible = true;
            //UserControl1.Hide();
            //HomeUserControl.Show();
            //HomeUserControl.BringToFront();
            

        }

        /*private void CheckIfDataExists()
        {
            if (!File.Exists("HMS.db"))
            {
                SQLiteConnection.CreateFile("HMS.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source = HMS.db;Version=3"))
                {
                    string commandstring = 
                }
            }
        }

       */
    }
}
