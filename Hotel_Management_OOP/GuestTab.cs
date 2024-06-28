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
        // Instantiate user controls
        //public UserControl HomeUserControl;
        //public UserControl BookingUserControl;

        HomeUserControl Dashboard = new HomeUserControl();
        BookingUserControl Booking = new BookingUserControl();
        BillingUserControl1 Billing = new BillingUserControl1();
        SettingsUserControl Settings = new SettingsUserControl();

        public GuestTab()
        {
            InitializeComponent();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(Dashboard);
            Dashboard.Dock = DockStyle.Fill;
            //InitializeUserControls();
        }

        /*private void InitializeUserControls()
        {
            this.HomeUserControl = new Hotel_Management_OOP.HomeUserControl();
            this.BookingUserControl = new Hotel_Management_OOP.BookingUserControl();

            // Set properties for HomeUserControl
            //this.HomeUserControl.Location = new System.Drawing.Point(0, 0);
            //this.HomeUserControl.Name = "homeUserControl";
            //this.HomeUserControl.Size = new System.Drawing.Size(800, 450);
            //this.HomeUserControl.TabIndex = 0;

            // Set properties for BookingUserControl
            //this.BookingUserControl.Location = new System.Drawing.Point(0, 0);
            //this.BookingUserControl.Name = "bookingUserControl";
            //this.BookingUserControl.Size = new System.Drawing.Size(800, 450);
            //this.BookingUserControl.TabIndex = 1;

            // Add controls to the form
            //this.Controls.Add(this.HomeUserControl);
            // this.Controls.Add(this.BookingUserControl);

            // Set initial visibility
            this.HomeUserControl.Visible = false;
            this.BookingUserControl.Visible = false;
        }
        */

        private void button6_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(Booking);
            Booking.Dock = DockStyle.Fill;
            //HomeUserControl.Visible = false;
            //BookingUserControl.Visible = true;
            //BookingUserControl.Show();
            //BookingUserControl.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //HomeUserControl.Show();
            //HomeUserControl.BringToFront();
            //HomeUserControl.Visible = true;
            //BookingUserControl.Visible = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(Dashboard);
            Dashboard.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BillingAndInvoicing form = new BillingAndInvoicing();
            // form.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //BillingAndInvoicing form = new BillingAndInvoicing();
            //form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logged out of your account.");
            this.Close();
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

        private void button9_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(Billing);
            Billing.Dock = DockStyle.Fill;
            //BillingAndInvoicing form = new BillingAndInvoicing();
            //form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(Settings);
            Settings.Dock = DockStyle.Fill;
        }

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Booking_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guestaddbutton_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to quit the application?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //WindowState.Minimize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?",
               "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                MessageBox.Show("You are logged out of your account.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Hide();

                Login form = new Login();
                form.ShowDialog();


                //Application.Exit();
            }

        }
    }
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

