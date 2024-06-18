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
    public partial class BookingTab : Form
    {
        public BookingTab()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            // constraint
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HOME_DRAFT_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            GuestTab form = new GuestTab();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RoomsTab form = new RoomsTab();
            form.ShowDialog();  
        }
    }
}
