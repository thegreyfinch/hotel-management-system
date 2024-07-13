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

namespace Hotel_Management_OOP
{
    public partial class BillingUserControl : UserControl
    {
        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;
        public BillingUserControl()
        {
            InitializeComponent();
            SetConnectDB();
            UpdateDataGridView();
        }
        private void SetConnectDB()

        {
            sqlConn = new SQLiteConnection("Data Source = C:\\Users\\Cheryl Jeanne\\Downloads\\OfficialSystem\\Hotel_Management_OOP\\bin\\Debug\\Hotel.db");
        }

        public void UpdateDataGridView()
        {

            try
            {
                SetConnectDB();
                sqlConn.Open();
                sqlCmd = sqlConn.CreateCommand();
                string CommandText = "SELECT PaymentStatus, PaymentMethod, Amount FROM Payment";
                DB = new SQLiteDataAdapter(CommandText, sqlConn);
                DS.Reset();
                DB.Fill(DS);
                sqlDT = DS.Tables[0];
                sqlConn.Close();
                dataGridViewGuests.DataSource = sqlDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dataGridViewGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
