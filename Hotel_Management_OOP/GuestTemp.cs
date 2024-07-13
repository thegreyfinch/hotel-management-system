using Hotel_Management_OOP.Controls;
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
    public partial class GuestTemp : Form
    {
        BookingTabUserControl BookingTab = new BookingTabUserControl();
        GuestTabUserControl GuestTab = new GuestTabUserControl();
        RoomsTabUserControl RoomsTab = new RoomsTabUserControl();
        AddBookingUserControl AddBooking = new AddBookingUserControl();
        public GuestTemp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookingTabbutton_Click(object sender, EventArgs e)
        {
            BookingTabUserControl BookingTab = new BookingTabUserControl();
            this.Controls.SetChildIndex(panel1, 0);
            BookingTab.panel1.SendToBack();
            panel1.Controls.Clear();
            panel1.Controls.Add(BookingTab);
            BookingTab.Dock = DockStyle.Fill;
        }

        private void GuestTabbutton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(GuestTab);
            GuestTab.Dock = DockStyle.Fill;
        }

        private void RoomsTabbutton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(RoomsTab);
            RoomsTab.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear any existing controls in the panel
            panel1.Controls.Clear();

            // Create a new instance of HomeUserControl
            HomeUserControl homeUserControl = new HomeUserControl();

            // Set the Dock property to Fill to make the user control occupy the entire panel
            homeUserControl.Dock = DockStyle.Fill;

            // Add the HomeUserControl to the panel
            panel1.Controls.Add(homeUserControl);

            // Bring the user control to the front
            homeUserControl.BringToFront();
        }
    }
}
