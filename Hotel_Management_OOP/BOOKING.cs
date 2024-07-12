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


namespace Hotel_Management_OOP
{
    public partial class BOOKING : Form
    {
        public BOOKING()
        {
            InitializeComponent();

            // Set up initial DataGridView when form loads
            SetConnectDB();
            UpdateDataGridView();
        }

        // declare and initialize the variables here
        public int bookingID = 0;
        public int custID = 0;
        public int guestID = 0;
        public int roomID = 0;
        public int noOfDays = 0;

        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;

        // Method to connect app to database
        private void SetConnectDB()
        {
            sqlConn = new SQLiteConnection("Data Source = booking.db"); //change path
        }


        private void UpdateDataGridView()
        {
            try
            {
                SetConnectDB();
                sqlConn.Open();
                sqlCmd = sqlConn.CreateCommand();
                string CommandText = "SELECT * FROM Booking";
                DB = new SQLiteDataAdapter(CommandText, sqlConn);
                DS.Reset();
                DB.Fill(DS);
                sqlDT = DS.Tables[0];
                sqlConn.Close();

                // Set the DataSource of your DataGridView to the DataTable
                //dataGridViewBooking.DataSource = sqlDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
