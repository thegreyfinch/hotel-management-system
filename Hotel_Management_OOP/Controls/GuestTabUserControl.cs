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
//using Microsoft.Data.Sqlite;

namespace Hotel_Management_OOP.Controls
{
    public partial class GuestTabUserControl : UserControl
    {
        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;

        public GuestTabUserControl()
        {
            InitializeComponent();
            SetConnectDB();
            UpdateDataGridView();
            BookingTabUserControl BookingTab = new BookingTabUserControl();
            // Subscribe to BookingUpdated event
            BookingTab.BookingUpdated += BookingTabUserControl_BookingUpdated;
        }

        private void BookingTabUserControl_BookingUpdated(object sender, EventArgs e)
        {
            UpdateDataGridView(); // Update data grid view when booking is updated
        }

        // Method to connect app to database
        private void SetConnectDB()

        {
            sqlConn = new SQLiteConnection("Data Source = C:\\Users\\QCU\\Downloads\\CloneOfficial2\\Hotel_Management_OOP\\bin\\Debug\\Hotel.db");
        }


        // Method to update DataGridView with filtered data
        public void UpdateDataGridView(string searchKeyword = "")
        {
            try
            {
                sqlConn.Open();
                string CommandText = "SELECT CustID, CustName, CustSex, ContactNumber, AgeCategory, RoomID, Status FROM Guest";

                // Check if the searchKeyword is exactly "Male" with a capital 'M'
                if (searchKeyword.Trim().Equals("Male"))
                {
                    CommandText += " WHERE CustSex = 'Male'";
                }
                else if (!string.IsNullOrEmpty(searchKeyword))
                {
                    CommandText += " WHERE ";

                    // Build dynamic OR conditions for all fields
                    CommandText += $"CustID LIKE '%{searchKeyword}%' OR ";
                    CommandText += $"CustName LIKE '%{searchKeyword}%' OR ";
                    CommandText += $"CustSex LIKE '%{searchKeyword}%' OR ";
                    CommandText += $"ContactNumber LIKE '%{searchKeyword}%' OR ";
                    CommandText += $"AgeCategory LIKE '%{searchKeyword}%' OR ";
                    CommandText += $"RoomID LIKE '%{searchKeyword}%' OR ";
                    CommandText += $"Status LIKE '%{searchKeyword}%'";
                }

                DB = new SQLiteDataAdapter(CommandText, sqlConn);
                DS.Reset();
                DB.Fill(DS);
                sqlDT = DS.Tables[0];
                dataGridViewGuests.DataSource = sqlDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }



        private void GuestTabUserControl_Load(object sender, EventArgs e)
        {


        }

        private void dataGridViewGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();

            // Check if the text box is empty
            if (string.IsNullOrEmpty(keyword))
            {
                UpdateDataGridView(); // Reload original data
            }
            else
            {
                UpdateDataGridView(keyword); // Update DataGridView with filtered data based on keyword
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();
            UpdateDataGridView(keyword); // Update DataGridView with filtered data based on keyword
        }
    }
}