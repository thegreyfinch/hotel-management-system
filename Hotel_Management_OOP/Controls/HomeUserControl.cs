using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Linq.Expressions;

namespace Hotel_Management_OOP
{
    public partial class HomeUserControl : UserControl
    {
        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;

        private void SetConnectDB()

        {
            sqlConn = new SQLiteConnection("Data Source = C:\\Users\\Cheryl Jeanne\\source\\repos\\Hotel_Management_OOP\\Hotel_Management_OOP\\bin\\Debug\\Hotel.db");
        }
        public HomeUserControl()
        {
            InitializeComponent();
            SetConnectDB();
            UpdateAvailableRoomsLabel();
            UpdateOccupiedRoomsLabel();
            UpdateMaleLabel();
            UpdateFemaleLabel();
            UpdateTotalRevenue();
            UpdateOccupancyRate();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
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

        private void UpdateAvailableRoomsLabel()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Room WHERE RoomStatus = 'Occupied'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int occupiedRooms = Convert.ToInt32(sqlCmd.ExecuteScalar());
                int availableRooms = 100 - occupiedRooms;
                label4.Text = $"{availableRooms}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void UpdateOccupiedRoomsLabel()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Room WHERE RoomStatus = 'Occupied'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int availableRooms = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label6.Text = $"{availableRooms}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void UpdateMaleLabel()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Guest WHERE CustSex = 'Male'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int availableRooms = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label16.Text = $"{availableRooms}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void UpdateFemaleLabel()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Guest WHERE CustSex = 'Female'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int availableRooms = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label18.Text = $"{availableRooms}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void UpdateTotalRevenue()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT SUM(PricePerNight) FROM Room";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                decimal totalRevenue = Convert.ToDecimal(sqlCmd.ExecuteScalar());
                label8.Text = $"{totalRevenue}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void UpdateOccupancyRate()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Room WHERE RoomStatus = 'Occupied'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int occupiedRooms = Convert.ToInt32(sqlCmd.ExecuteScalar());
                decimal occupancyRate = Convert.ToDecimal(occupiedRooms) / 100 * 100;
                label14.Text = $"{occupancyRate}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
