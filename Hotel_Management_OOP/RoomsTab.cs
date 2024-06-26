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
    public partial class RoomsTab : Form
    {
        public RoomsTab()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GuestTab form = new GuestTab();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingTab form = new BookingTab();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
