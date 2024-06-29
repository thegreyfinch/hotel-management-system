using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite; //edit 
using Microsoft.EntityFrameworkCore;
using Hotel_Management_OOP.Controls;

namespace Hotel_Management_OOP
{
    //SqlConnection conn = new SqlConnection("Data.Source=.;initial catalog=users;integrated security=true"); //edit
    public partial class BookingUserControl : UserControl
    {
        public BookingUserControl()
        {
            InitializeComponent();
            BookingTabUserControl bookingTabUserControl = new BookingTabUserControl();
            GuestTabUserControl guestTabUserControl = new GuestTabUserControl();
            RoomsTabUserControl roomsTabUserControl = new RoomsTabUserControl();

            bookingTabUserControl.Location = new Point(10,10);
            bookingTabUserControl.Name = "Booking Tab";
            bookingTabUserControl.Size = new Size (200, 100);

            this.Controls.Add(bookingTabUserControl);
            this.Controls.Add(guestTabUserControl);
            this.Controls.Add(roomsTabUserControl);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logged out of your account.");
            Application.Exit();
        }

        private void guestaddbutton_Click(object sender, EventArgs e)
        {
            /* SqlCommand cmd = new SqlCommand("Select Booking_ID,Customer_ID,Room_ID,Check-in,Check-out,Price, Booking_Status, Booking_Date group from dataGridViewBooking where ID_group=@parm1", conn); //edit
             cmd.Parameters.AddWithValue("@parm1", TextBox.Text); //edit
             SQLiteDataAdapter da = new SQLiteDataAdapter();  //edit
             da.SelectCommand = cmd;   //edit
             DataTable dt = new DataTable(); //edit
             dt.Clear();  //edit
             da.Fill(dt);  //edit
             dataGridViewBooking.DataSource = dt;   //edit
             dataGridViewBooking.AllowUserToAddRows = false;   //edit

             this.SendToBack();
             BOOKING form = new BOOKING();
             form.ShowDialog();
            */

            //this.SendToBack();
            //BOOKING form = new BOOKING();
            //form.ShowDialog();
        }

        private void Booking_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
