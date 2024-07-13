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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.Kernel.Font;
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
            sqlConn = new SQLiteConnection("Data Source = C:\\Users\\Cheryl Jeanne\\Downloads\\OfficialSystem\\Hotel_Management_OOP\\bin\\Debug\\Hotel.db");
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
            UpdateStandardRoom();
            UpdateDeluxeRoom();
            UpdateSuiteRoom();
            UpdateElderly();
            UpdateYoung();
            UpdateChild();
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

        private void UpdateStandardRoom()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Room WHERE RoomType = 'Standard'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int standardRooms = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label23.Text = $"{standardRooms}";
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

        private void UpdateDeluxeRoom()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Room WHERE RoomType = 'Deluxe'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int deluxeRooms = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label12.Text = $"{deluxeRooms}";
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

        private void UpdateSuiteRoom()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Room WHERE RoomType = 'Suite'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int suiteRooms = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label11.Text = $"{suiteRooms}";
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

        private void UpdateElderly()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Guest WHERE AgeCategory = 'Elderly'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int elderly = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label26.Text = $"{elderly}";
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

        private void UpdateYoung()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Guest WHERE AgeCategory = 'Young'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int young = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label28.Text = $"{young}";
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

        private void UpdateChild()
        {
            try
            {
                sqlConn.Open();
                string query = "SELECT COUNT(*) FROM Guest WHERE AgeCategory = 'Child'";
                sqlCmd = new SQLiteCommand(query, sqlConn);
                int child = Convert.ToInt32(sqlCmd.ExecuteScalar());
                label30.Text = $"{child}";
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerateReport()
        {
            // Define the file path for the report
            string filePath = @"C:\\Users\\Cheryl Jeanne\\Downloads\\OfficialSystem\\Hotel_Management_OOP\\Reports\\report.pdf";

            //string filePath = @"C:\Users\QCU\Downloads\CloneOfficial2\Hotel_Management_OOP\Reports\report.pdf";

            using (var pdfWriter = new PdfWriter(filePath))
            using (var pdfDocument = new PdfDocument(pdfWriter))
            using (var document = new Document(pdfDocument))
            {
                // Add a title to the document
                document.Add(new Paragraph("Hotel Report")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                    .SetFontSize(20)
                    .SetTextAlignment(TextAlignment.CENTER));

                // Add occupancy rate
                document.Add(new Paragraph($"Occupancy Rate: {label14.Text}")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                    .SetFontSize(12));

                // Add male and female population
                document.Add(new Paragraph($"Male Guests: {label16.Text}")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                    .SetFontSize(12));
                document.Add(new Paragraph($"Female Guests: {label18.Text}")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                    .SetFontSize(12));
                // Add room stats for Standard room tyoe
                document.Add(new Paragraph($"Number of Occupied Standard Rooms: {label23.Text}")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                    .SetFontSize(12));
                // Add room stats for Deluxe room tyoe
                document.Add(new Paragraph($"Number of Occupied Deluxe Rooms: {label12.Text}")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                    .SetFontSize(12));
                // Add room stats for Suite room tyoe
                document.Add(new Paragraph($"Number of Occupied Suite Rooms: {label11.Text}")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                    .SetFontSize(12));
                // Add total revenue
                document.Add(new Paragraph($"Total Revenue: {label8.Text}")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                    .SetFontSize(12));
            }

            MessageBox.Show("Report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
