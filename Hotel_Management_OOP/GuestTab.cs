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
