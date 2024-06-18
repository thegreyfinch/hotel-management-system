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
            RoomsTab form = new RoomsTab();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingTab form = new BookingTab();
            form.ShowDialog();
        }
    }
}
