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
    public partial class RoomsTabUserControl : UserControl
    {
        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;
        public RoomsTabUserControl()
        {
            InitializeComponent();
            SetConnectDB();
            UpdateDataGridView();
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
                sqlConn.Open();
                string CommandText = "SELECT * FROM Room";
                DB = new SQLiteDataAdapter(CommandText, sqlConn);
                DS.Reset();
                DB.Fill(DS);
                sqlDT = DS.Tables[0];
                dataGridViewRooms.DataSource = sqlDT;
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

        private void RoomsTabUserControl_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}