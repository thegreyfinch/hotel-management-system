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
            sqlConn = new SQLiteConnection("Data Source = C:\\Users\\QCU\\Downloads\\CloneOfficial2\\Hotel_Management_OOP\\bin\\Debug\\Hotel.db");
        }
        public EditBookingTab(int bookingID, int roomID, string custName, string roomType, int noOfGuest, string custSex, string contactNumber, DateTime birthdate, DateTime checkInDate, DateTime checkOutDate)
        {
            InitializeComponent();

            // Store bookingID
            this.bookingID = bookingID;

            // Set form fields
            textBox2.Text = custName;
            textBox4.Text = roomID.ToString();
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

                // Retrieve CustID and Old RoomID based on BookingID
                string getCustIDQuery = "SELECT CustID, RoomID FROM Booking WHERE BookingID = @BookingID";
                int custID;
                int oldRoomID;
                using (SQLiteCommand getCustIDCmd = new SQLiteCommand(getCustIDQuery, sqlConn))
                {
                    getCustIDCmd.Parameters.AddWithValue("@BookingID", bookingID);
                    using (SQLiteDataReader reader = getCustIDCmd.ExecuteReader())
                    {
                        reader.Read();
                        custID = Convert.ToInt32(reader["CustID"]);
                        oldRoomID = Convert.ToInt32(reader["RoomID"]);
                    }
                }

                // Update Booking details
                string updateBookingQuery = "UPDATE Booking SET RoomID = @RoomID, CustName = @CustName, RoomType = @RoomType, NoOfGuest = @NoOfGuest, CustSex = @CustSex, ContactNumber = @ContactNumber, Birthdate = @Birthdate, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate WHERE BookingID = @BookingID";

                using (SQLiteCommand updateBookingCmd = new SQLiteCommand(updateBookingQuery, sqlConn))
                {
                    updateBookingCmd.Parameters.AddWithValue("@RoomID", int.Parse(textBox4.Text));
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

                // Retrieve the new RoomID
                int newRoomID = int.Parse(textBox4.Text);

                // Update Room details: change the RoomID in the Room table while retaining other details
                string updateRoomQuery = "UPDATE Room SET RoomID = @NewRoomID WHERE RoomID = @OldRoomID";
                using (SQLiteCommand updateRoomCmd = new SQLiteCommand(updateRoomQuery, sqlConn))
                {
                    updateRoomCmd.Parameters.AddWithValue("@NewRoomID", newRoomID);
                    updateRoomCmd.Parameters.AddWithValue("@OldRoomID", oldRoomID);
                    updateRoomCmd.ExecuteNonQuery();
                }

                // Update Guest details
                string updateGuestQuery = "UPDATE Guest SET RoomID = @RoomID WHERE CustID = @CustID";
                using (SQLiteCommand updateGuestCmd = new SQLiteCommand(updateGuestQuery, sqlConn))
                {
                    updateGuestCmd.Parameters.AddWithValue("@RoomID", newRoomID);
                    updateGuestCmd.Parameters.AddWithValue("@CustID", custID);
                    updateGuestCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Booking, Room, and Guest updated successfully.");
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBookingTab_Load(object sender, EventArgs e)
        {

        }
    }
}
