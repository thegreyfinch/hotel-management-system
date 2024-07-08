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
using Microsoft.Data.Sqlite;

namespace Hotel_Management_OOP.Controls
{
    public partial class BookingTabUserControl : UserControl
    {
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


        public BookingTabUserControl()
        {
            InitializeComponent();
            // Setup initial DataGridView when form loads
            SetConnectDB();
            UpdateDataGridView();


        }
        // Method to connect app to database
        private void SetConnectDB()

        {
            sqlConn = new SQLiteConnection("Data Source = HMS.db");
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
                dataGridViewBooking.DataSource = sqlDT;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void comboBox2_SelectedIndexChange(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComputeNoOfDays()
        {
            DateTime f = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime s = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan de = s.Subtract(f);
            noOfDays = Convert.ToInt32(de.Days);
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                sqlCmd.CommandText = query;
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Query executed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SetConnectDB(); // establish the database connection
            sqlConn.Open(); // open the connection

            // increment the values of the IDs (if needed, adjust as per your application logic)
            bookingID++;
            custID++;
            guestID++;
            roomID++;

            // method call to compute the number of days
            ComputeNoOfDays();

            // SQL statement with parameterized query to avoid SQL injection and properly insert values
            string CommandText = "INSERT INTO Booking (CustID, GuestID, RoomID, CustName, ArrivalTime, DepartureTime, BookingStatus, RoomType, NoOfDays) " +
                                "VALUES (@CustID, @GuestID, @RoomID, @CustName, @ArrivalTime, @DepartureTime, @BookingStatus, @RoomType, @NoOfDays)";

            // Create SQL command and parameters
            sqlCmd = new SQLiteCommand(CommandText, sqlConn);
            sqlCmd.Parameters.AddWithValue("@CustID", custID);
            sqlCmd.Parameters.AddWithValue("@GuestID", guestID);
            sqlCmd.Parameters.AddWithValue("@RoomID", roomID);
            sqlCmd.Parameters.AddWithValue("@CustName", textBox2.Text);
            sqlCmd.Parameters.AddWithValue("@ArrivalTime", dateTimePicker1.Value);
            sqlCmd.Parameters.AddWithValue("@DepartureTime", dateTimePicker2.Value);
            sqlCmd.Parameters.AddWithValue("@BookingStatus", comboBox1.Text);
            sqlCmd.Parameters.AddWithValue("@RoomType", comboBox2.Text);
            sqlCmd.Parameters.AddWithValue("@NoOfDays", noOfDays);

            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Booking successfully added.");
                // Refresh the DataGridView after adding the booking
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message);
            }
            finally
            {
                sqlConn.Close(); // close the connection
            }
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SetConnectDB();
                sqlConn.Open();
                sqlCmd = sqlConn.CreateCommand();

                // Use parameterized query to avoid SQL injection and correctly pass the value
                string CommandText = "SELECT * FROM Booking WHERE RoomID = @RoomID";
                sqlCmd.CommandText = CommandText;

                // Add parameter
                sqlCmd.Parameters.AddWithValue("@RoomID", textBox1.Text);

                // Execute query and fill DataTable
                DB = new SQLiteDataAdapter(sqlCmd);
                DS.Reset();
                DB.Fill(DS);
                sqlDT = DS.Tables[0];

                // Close connection
                sqlConn.Close();

                // Set the DataSource of your DataGridView to the DataTable
                dataGridViewBooking.DataSource = sqlDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void AddGuestbtn_Click(object sender, EventArgs e)
        {
            //show Dialog of Confirmation
            // Add or update database
        }

        private void SaveGuestBtn_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RoomIDtxtbox_TextChanged(object sender, EventArgs e)
        {

        }


        /*public string? CustomFormat { get; set; }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
        }*/
    }
}

/*
private void button1_Click(object sender, EventArgs e)
    {
        SetConnectDB();
        sqlConn.Open();

        bookingID++;
        custID++;
        guestID++;
        roomID++;

        ComputeNoOfDays();

        string CommandText = "INSERT INTO Booking (CustID, GuestID, RoomID, CustName, ArrivalTime, DepartureTime, BookingStatus, RoomType, NoOfDays)"
            + "VALUES (@CustID, @GuestID, @RoomID, @CustName, @ArrivalTime, @DepartureTime, @BookingStatus, @RoomType, @NoOfDays)";

    }



        private void label2_Click(Object sender, EventArgs e)
            {

            }


               

        }

        private void AddBookingBtn_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            AddBookingUserControl AddBooking = new AddBookingUserControl();
            //panel1.Controls.Clear();
            //panel1.Controls.Add(AddBooking);
            AddBooking.Dock = DockStyle.Fill;
            AddBooking.BringToFront();

            //this.Hide();
            //Form.showDialog(BOOKING);
            //
            //AddBookingUserControl AddBooking = new AddBookingUserControl();

            /*panel1.Controls.Clear();
            panel1.Controls.Add(AddBookingUserControl);
            AddBookingUserControl.Dock = DockStyle.Fill;
            //
            
            form.ShowDialog(BOOKING);*/
            //BOOKING BOOKING = new BOOKING();

            //BOOKING.Show();


        /*
       <<<<<<< Updated upstream
       =======
               // declare and initialize the variables here

               // Method to connect app to database
               private void SetConnectDB()
               {
                   sqlConn = new SQLiteConnection("Data Source = "booking.db");


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
                       dataGridView1.DataSource = sqlDT;
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Error loading data: " + ex.Message);
                   }
               }


       >>>>>>> Stashed changes
       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddGuestbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
*/