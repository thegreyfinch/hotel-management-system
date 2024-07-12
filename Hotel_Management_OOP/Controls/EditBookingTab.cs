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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_OOP.Controls
{
    public partial class EditBookingTab : UserControl
    {
        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;
        private int bookingID;

        private void SetConnectDB()

        {
            sqlConn = new SQLiteConnection("Data Source = C:\\Users\\Cheryl Jeanne\\source\\repos\\Hotel_Management_OOP\\Hotel_Management_OOP\\bin\\Debug\\Hotel.db");
        }
        public EditBookingTab(int bookingID, string custName, string roomType, int noOfGuest, string custSex, string contactNumber, DateTime birthdate, DateTime checkInDate, DateTime checkOutDate)
        {
            InitializeComponent();

            // Store bookingID
            this.bookingID = bookingID;

            // Set form fields
            textBox2.Text = custName;
            comboBox2.Text = roomType;
            //comboBox2.Text = roomStatus;
            textBox1.Text = noOfGuest.ToString();
            comboBox3.Text = custSex;
            textBox3.Text = contactNumber;
            dateTimePicker3.Value = birthdate;
            dateTimePicker1.Value = checkInDate;
            dateTimePicker2.Value = checkOutDate;

            // Setup database connection
            SetConnectDB();
        }

        private void UpdateBooking()
        {
            try
            {
                sqlConn.Open();

                string getCustIDQuery = "SELECT CustID FROM Booking WHERE BookingID = @BookingID";
                int custID;
                using (SQLiteCommand getCustIDCmd = new SQLiteCommand(getCustIDQuery, sqlConn))
                {
                    getCustIDCmd.Parameters.AddWithValue("@BookingID", bookingID);
                    custID = Convert.ToInt32(getCustIDCmd.ExecuteScalar());
                }

                string updateBookingQuery = "UPDATE Booking SET CustName = @CustName, RoomType = @RoomType, NoOfGuest = @NoOfGuest, CustSex = @CustSex, ContactNumber = @ContactNumber, Birthdate = @Birthdate, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate WHERE BookingID = @BookingID";

                using (SQLiteCommand updateBookingCmd = new SQLiteCommand(updateBookingQuery, sqlConn))
                {
                    updateBookingCmd.Parameters.AddWithValue("@CustName", textBox2.Text);
                    updateBookingCmd.Parameters.AddWithValue("@RoomType", comboBox2.Text);
                    updateBookingCmd.Parameters.AddWithValue("@NoOfGuest", int.Parse(textBox1.Text));
                    updateBookingCmd.Parameters.AddWithValue("@CustSex", comboBox3.Text);
                    updateBookingCmd.Parameters.AddWithValue("@ContactNumber", textBox3.Text);
                    updateBookingCmd.Parameters.AddWithValue("@Birthdate", dateTimePicker3.Value);
                    updateBookingCmd.Parameters.AddWithValue("@CheckInDate", dateTimePicker1.Value);
                    updateBookingCmd.Parameters.AddWithValue("@CheckOutDate", dateTimePicker2.Value);
                    updateBookingCmd.Parameters.AddWithValue("@BookingID", bookingID);

                    updateBookingCmd.ExecuteNonQuery();
                }

                string updateRoomQuery = "UPDATE Room SET RoomType = @RoomType WHERE RoomID = (SELECT RoomID FROM Booking WHERE BookingID = @BookingID)";
                using (SQLiteCommand updateRoomCmd = new SQLiteCommand(updateRoomQuery, sqlConn))
                {
                    updateRoomCmd.Parameters.AddWithValue("@RoomType", comboBox2.Text);
                    updateRoomCmd.Parameters.AddWithValue("@BookingID", bookingID);

                    updateRoomCmd.ExecuteNonQuery();
                }

                string updateGuestQuery = "UPDATE Guest SET CustName = @CustName, CustSex = @CustSex, ContactNumber = @ContactNumber WHERE CustID = @CustID";
                using (SQLiteCommand updateGuestCmd = new SQLiteCommand(updateGuestQuery, sqlConn))
                {
                    updateGuestCmd.Parameters.AddWithValue("@CustName", textBox2.Text);
                    updateGuestCmd.Parameters.AddWithValue("@CustSex", comboBox3.Text);
                    updateGuestCmd.Parameters.AddWithValue("@ContactNumber", textBox3.Text);
                    updateGuestCmd.Parameters.AddWithValue("@CustID", custID);

                    updateGuestCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Booking, Room, and Guest updated successfully.");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update the booking record
            UpdateBooking();
        }
    }
}
