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
using System.Reflection.Emit;
//using Microsoft.Data.Sqlite;

namespace Hotel_Management_OOP.Controls
{
    public partial class BookingTabUserControl : UserControl
    {
        public int bookingID = 0;
        public int custID = 0;
        public int noOfDays = 0;
        public int paymentID = 0;
        public double totalAmount = 0;

        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;


        public BookingTabUserControl()
        {
            InitializeComponent();
            SetConnectDB();
            UpdateDataGridView();

            // Disable Edit button by default
            EditBBtn.Enabled = false;

            // Subscribe to DataGridView selection changed event
            dataGridViewBooking.SelectionChanged += DataGridViewBooking_SelectionChanged;


        }
        // Method to connect app to database
        private void SetConnectDB()

        {
            sqlConn = new SQLiteConnection("Data Source = C:\\Users\\Cheryl Jeanne\\source\\repos\\Hotel_Management_OOP\\Hotel_Management_OOP\\bin\\Debug\\Hotel.db");
        }


        public void UpdateDataGridView()
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

        private void DataGridViewBooking_SelectionChanged(object sender, EventArgs e)
        {
            // Enable the Edit button if a row is selected
            if (dataGridViewBooking.SelectedRows.Count > 0)
            {
                EditBBtn.Enabled = true;
            }
            else
            {
                EditBBtn.Enabled = false;
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

        /*private void ComputeNoOfDays()
        {
            DateTime f = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime s = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan de = s.Subtract(f);
            noOfDays = Convert.ToInt32(de.Days);
        }*/

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

        public void ComputeNoOfDays()
        {
            DateTime f = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime s = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan de = s.Subtract(f);
            noOfDays = Convert.ToInt32(de.Days);
        }


        private void AddGuestbtn_Click(object sender, EventArgs e)
        {
            SetConnectDB(); // establish the database connection
            sqlConn.Open(); // open the connection

            // Fetch the maximum BookingID from the Booking table
            bookingID = GetNextID("Booking", "BookingID");
            // Fetch the maximum CustID from the Guest table
            custID = GetNextID("Guest", "CustID");
            paymentID = GetNextID("Payment", "PaymentID");

            // Determine the price based on the RoomType
            int pricePerNight = 0;
            string roomType = comboBox2.Text;

            if (roomType == "Standard")
            {
                pricePerNight = 150;
            }
            else if (roomType == "Deluxe")
            {
                pricePerNight = 200;
            }
            else if (roomType == "Suite")
            {
                pricePerNight = 300;
            }

            // Compute the AgeCategory based on the Birthdate
            string ageCategory = ComputeAgeCategory(dateTimePicker3.Value);

            // SQL statement with parameterized query to avoid SQL injection and properly insert values into Booking table
            string bookingCommandText = "INSERT INTO Booking (BookingID, CustID, RoomID, CheckInDate, CheckOutDate, RoomType, RoomStatus, NoOfGuest, CustName, CustSex, ContactNumber, Birthdate, BookingStatus) " +
                                        "VALUES (@BookingID, @CustID, @RoomID, @CheckInDate, @CheckOutDate, @RoomType, @RoomStatus, @NoOfGuest, @CustName, @CustSex, @ContactNumber, @Birthdate, @BookingStatus)";

            // Create SQL command and parameters for Booking table
            sqlCmd = new SQLiteCommand(bookingCommandText, sqlConn);
            sqlCmd.Parameters.AddWithValue("@BookingID", bookingID);
            sqlCmd.Parameters.AddWithValue("@CustID", custID);
            sqlCmd.Parameters.AddWithValue("@RoomID", textBox1.Text);
            sqlCmd.Parameters.AddWithValue("@CheckInDate", dateTimePicker1.Value);
            sqlCmd.Parameters.AddWithValue("@CheckOutDate", dateTimePicker2.Value);
            sqlCmd.Parameters.AddWithValue("@RoomType", roomType);
            sqlCmd.Parameters.AddWithValue("@RoomStatus", comboBox1.Text);
            sqlCmd.Parameters.AddWithValue("@NoOfGuest", textBox3.Text);
            sqlCmd.Parameters.AddWithValue("@CustName", textBox2.Text);
            sqlCmd.Parameters.AddWithValue("@CustSex", comboBox3.Text);
            sqlCmd.Parameters.AddWithValue("@ContactNumber", textBox6.Text);
            sqlCmd.Parameters.AddWithValue("@Birthdate", dateTimePicker3.Value);
            sqlCmd.Parameters.AddWithValue("@BookingStatus", "Active");

            // SQL statement with parameterized query to insert values into Room table
            string roomCommandText = "INSERT INTO Room (RoomID, RoomType, RoomStatus, PricePerNight) VALUES (@RoomID, @RoomType, @RoomStatus, @PricePerNight)";

            // Create SQL command and parameters for Room table
            SQLiteCommand roomCmd = new SQLiteCommand(roomCommandText, sqlConn);
            roomCmd.Parameters.AddWithValue("@RoomID", textBox1.Text);
            roomCmd.Parameters.AddWithValue("@RoomType", roomType);
            roomCmd.Parameters.AddWithValue("@RoomStatus", comboBox1.Text);
            roomCmd.Parameters.AddWithValue("@PricePerNight", pricePerNight);

            // SQL statement with parameterized query to insert values into Guest table
            string guestCommandText = "INSERT INTO Guest (CustID, CustName, CustSex, ContactNumber, AgeCategory, RoomID, Status) VALUES (@CustID, @CustName, @CustSex, @ContactNumber, @AgeCategory, @RoomID, @Status)";

            // Create SQL command and parameters for Guest table
            SQLiteCommand guestCmd = new SQLiteCommand(guestCommandText, sqlConn);
            guestCmd.Parameters.AddWithValue("@CustID", custID);
            guestCmd.Parameters.AddWithValue("@CustName", textBox2.Text);
            guestCmd.Parameters.AddWithValue("@CustSex", comboBox3.Text);
            guestCmd.Parameters.AddWithValue("@ContactNumber", textBox6.Text);
            guestCmd.Parameters.AddWithValue("@AgeCategory", ageCategory);
            guestCmd.Parameters.AddWithValue("@RoomID", textBox1.Text);
            guestCmd.Parameters.AddWithValue("@Status", "Active");

            // SQL statement with parameterized query to insert values into Payment table
            string paymentCommandText = "INSERT INTO Payment (PaymentID, PaymentStatus, PaymentMethod, Amount) VALUES (@PaymentID, @PaymentStatus, @PaymentMethod, @Amount)";

            // Solve the total amount to be paid
            ComputeNoOfDays();
            totalAmount = pricePerNight * noOfDays;
            label9.Text =totalAmount.ToString();

            // Create SQL command and parameters for Guest table
            SQLiteCommand paymentCmd = new SQLiteCommand(paymentCommandText, sqlConn);
            paymentCmd.Parameters.AddWithValue("@PaymentID", paymentID);
            paymentCmd.Parameters.AddWithValue("@PaymentStatus", "Paid");
            paymentCmd.Parameters.AddWithValue("@PaymentMethod", comboBox5.Text);
            paymentCmd.Parameters.AddWithValue("@Amount", totalAmount);

            try
            {
                // Execute the commands
                sqlCmd.ExecuteNonQuery();
                roomCmd.ExecuteNonQuery();
                guestCmd.ExecuteNonQuery();
                paymentCmd.ExecuteNonQuery();

                MessageBox.Show("Booking successfully added.");

                // Refresh data grids in all relevant user controls
                UpdateDataGridView(); // For BookingTabUserControl
                                      //RefreshGuestDataGrid(); // For GuestTabUserControl
                                      // RefreshRoomDataGrid(); // For RoomsTabUserControl
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

        private int GetNextID(string tableName, string columnName)
        {
            int nextID = 1;
            string query = $"SELECT MAX({columnName}) FROM {tableName}";
            SQLiteCommand cmd = new SQLiteCommand(query, sqlConn);
            var result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                nextID = Convert.ToInt32(result) + 1;
            }
            return nextID;
        }

        private string ComputeAgeCategory(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age)) age--; // Adjust for birthdate not yet occurred this year

            if (age >= 0 && age <= 19)
            {
                return "Young";
            }
            else if (age >= 20 && age <= 64)
            {
                return "Adult";
            }
            else
            {
                return "Elderly";
            }
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

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooking.SelectedRows.Count > 0)
            {
                // Get the selected BookingID
                int selectedRowIndex = dataGridViewBooking.SelectedRows[0].Index;
                int bookingID = Convert.ToInt32(dataGridViewBooking.Rows[selectedRowIndex].Cells["BookingID"].Value);

                // Get the RoomID associated with the selected BookingID
                int roomID = Convert.ToInt32(dataGridViewBooking.Rows[selectedRowIndex].Cells["RoomID"].Value);

                // Set the BookingStatus to "Inactive" for the selected BookingID
                string updateBookingQuery = $"UPDATE Booking SET BookingStatus = 'Inactive' WHERE BookingID = {bookingID}";

                // Set the RoomStatus to "Available" for the associated RoomID
                string updateRoomQuery = $"UPDATE Room SET RoomStatus = 'Available' WHERE RoomID = {roomID}";

                try
                {
                    SetConnectDB();
                    sqlConn.Open();

                    // Create a transaction to ensure both updates are executed atomically
                    using (var transaction = sqlConn.BeginTransaction())
                    {
                        // Update Booking table
                        sqlCmd = new SQLiteCommand(updateBookingQuery, sqlConn);
                        sqlCmd.ExecuteNonQuery();

                        // Update Room table
                        sqlCmd.CommandText = updateRoomQuery;
                        sqlCmd.ExecuteNonQuery();

                        // Commit transaction
                        transaction.Commit();
                    }

                    MessageBox.Show("Booking successfully marked as Inactive and Room status updated to Available.");

                    // Refresh the DataGridView to reflect the changes
                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating booking and room status: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to remove.");
            }
        }

        public void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                UpdateDataGridView();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string keyword = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // If keyword is empty or null, refresh DataGridView
                UpdateDataGridView();
                return;
            }

            try
            {
                SetConnectDB();
                sqlConn.Open();
                sqlCmd = sqlConn.CreateCommand();

                // Define the query dynamically to search in any column
                string CommandText = "SELECT * FROM Booking WHERE ";

                // Build the search criteria based on keyword
                List<string> searchConditions = new List<string>();
                searchConditions.Add("CustName LIKE @keyword");
                searchConditions.Add("RoomType LIKE @keyword");
                searchConditions.Add("RoomID LIKE @keyword");
                searchConditions.Add("RoomStatus LIKE @keyword");
                searchConditions.Add("ContactNumber LIKE @keyword");
                searchConditions.Add("Birthdate LIKE @keyword"); // Adjust format for date search if needed
                searchConditions.Add("CheckInDate LIKE @keyword"); // Adjust format for date search if needed
                searchConditions.Add("CheckOutDate LIKE @keyword"); // Adjust format for date search if needed
                searchConditions.Add("NoOfGuest LIKE @keyword");
                searchConditions.Add("CustSex LIKE @keyword");

                Console.WriteLine(CommandText);

                CommandText += string.Join(" OR ", searchConditions);

                sqlCmd.CommandText = CommandText;
                sqlCmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                // Reset DataSet and fill it with data from database
                DS.Reset();
                DB = new SQLiteDataAdapter(sqlCmd);
                DB.Fill(DS);

                // Update the DataTable and bind to DataGridView
                sqlDT = DS.Tables[0];
                dataGridViewBooking.DataSource = sqlDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             if (dataGridViewBooking.SelectedRows.Count == 0)
             {
                 MessageBox.Show("Please select a record to edit.");
                 return;
             }

             // Get the selected booking details
             int selectedRowIndex = dataGridViewBooking.SelectedRows[0].Index;
             int bookingID = Convert.ToInt32(dataGridViewBooking.Rows[selectedRowIndex].Cells["BookingID"].Value);
             string custName = dataGridViewBooking.Rows[selectedRowIndex].Cells["CustName"].Value.ToString();
             string roomType = dataGridViewBooking.Rows[selectedRowIndex].Cells["RoomType"].Value.ToString();
             //string roomStatus = dataGridViewBooking.Rows[selectedRowIndex].Cells["RoomStatus"].Value.ToString();
             int noOfGuest = Convert.ToInt32(dataGridViewBooking.Rows[selectedRowIndex].Cells["NoOfGuest"].Value);
             string custSex = dataGridViewBooking.Rows[selectedRowIndex].Cells["CustSex"].Value.ToString();
             string contactNumber = dataGridViewBooking.Rows[selectedRowIndex].Cells["ContactNumber"].Value.ToString();
             DateTime birthdate = Convert.ToDateTime(dataGridViewBooking.Rows[selectedRowIndex].Cells["Birthdate"].Value);
             DateTime checkInDate = Convert.ToDateTime(dataGridViewBooking.Rows[selectedRowIndex].Cells["CheckInDate"].Value);
             DateTime checkOutDate = Convert.ToDateTime(dataGridViewBooking.Rows[selectedRowIndex].Cells["CheckOutDate"].Value);

             // Pass details to EditBooking form
             EditBooking editBooking = new EditBooking(bookingID, custName, roomType, noOfGuest, custSex, contactNumber, birthdate, checkInDate, checkOutDate);
             editBooking.ShowDialog();
         }*/

        private void EditBBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            // Get the selected booking details
            int selectedRowIndex = dataGridViewBooking.SelectedRows[0].Index;
            int bookingID = Convert.ToInt32(dataGridViewBooking.Rows[selectedRowIndex].Cells["BookingID"].Value);
            string custName = dataGridViewBooking.Rows[selectedRowIndex].Cells["CustName"].Value.ToString();
            string roomType = dataGridViewBooking.Rows[selectedRowIndex].Cells["RoomType"].Value.ToString();
            //string roomStatus = dataGridViewBooking.Rows[selectedRowIndex].Cells["RoomStatus"].Value.ToString();
            int noOfGuest = Convert.ToInt32(dataGridViewBooking.Rows[selectedRowIndex].Cells["NoOfGuest"].Value);
            string custSex = dataGridViewBooking.Rows[selectedRowIndex].Cells["CustSex"].Value.ToString();
            string contactNumber = dataGridViewBooking.Rows[selectedRowIndex].Cells["ContactNumber"].Value.ToString();
            DateTime birthdate = Convert.ToDateTime(dataGridViewBooking.Rows[selectedRowIndex].Cells["Birthdate"].Value);
            DateTime checkInDate = Convert.ToDateTime(dataGridViewBooking.Rows[selectedRowIndex].Cells["CheckInDate"].Value);
            DateTime checkOutDate = Convert.ToDateTime(dataGridViewBooking.Rows[selectedRowIndex].Cells["CheckOutDate"].Value);

            // Pass details to EditBooking forms
            EditBookingTab editBooking = new EditBookingTab(bookingID, custName, roomType, noOfGuest, custSex, contactNumber, birthdate, checkInDate, checkOutDate);
            //editBooking.Show();

            //BookingUserControl BookingTab = new BookingUserControl();
            //this.BringtToFront(panel1);
            this.Controls.SetChildIndex(panel1, 0);
            panel1.Controls.Clear();
            panel1.Controls.Add(editBooking);
            editBooking.Dock = DockStyle.Fill;
            // Bring the editBooking control to the front
            editBooking.BringToFront();
            panel1.Controls.SetChildIndex(editBooking, 0);
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_2(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

