using System;  // Using System namespace for basic functionalities
using System.Collections.Generic;  // Using System.Collections.Generic namespace for collections like List
using System.ComponentModel;  // Using System.ComponentModel namespace for component model functionalities
using System.Data;  // Using System.Data namespace for data functionalities
using System.Drawing;  // Using System.Drawing namespace for graphical functionalities
using System.Linq;  // Using System.Linq namespace for LINQ functionalities
using System.Text;  // Using System.Text namespace for text-related functionalities
using System.Threading.Tasks;  // Using System.Threading.Tasks namespace for task-based asynchronous programming
using System.Windows.Forms;  // Using System.Windows.Forms namespace for Windows Forms applications
using System.Data.SQLite;  // Using System.Data.SQLite namespace for SQLite database functionalities
using System.IO;  // Using System.IO namespace for file input/output functionalities

using Microsoft.VisualBasic.ApplicationServices;  // Using Microsoft.VisualBasic.ApplicationServices namespace for VB application services
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;  // Using static import for specific VisualStyleElement
using static System.Windows.Forms.VisualStyles.VisualStyleElement;  // Using static import for VisualStyleElement

namespace Hotel_Management_OOP
{
    public partial class SettingsUserControl : UserControl
    {
        string path = "FloraSuitesLoginDB.db";  // Database file path
        string cs = @"URI=file:" + Application.StartupPath + "\\FloraSuitesLoginDB.db";  // Connection string for SQLite

        public SettingsUserControl()
        {
            InitializeComponent();  // Initialize the component
            InitializeDataGridView();  // Initialize the DataGridView control
            InitializeComboBox();  // Initialize the ComboBox control
            try
            {
                Create_db();  // Ensure database and tables are created before loading data
                LoadExistingUsers().ConfigureAwait(false);  // Load existing users asynchronously
                LoadUserRoles();  // Load user roles into ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during initialization: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
            }
        }

        private void CreateRolesTable()
        {
            try
            {
                using (var sqlite = new SQLiteConnection(cs))  // Create a new SQLite connection
                {
                    sqlite.Open();  // Open the SQLite connection
                    string createTableSql = "CREATE TABLE IF NOT EXISTS UserRoles(RoleID INTEGER PRIMARY KEY AUTOINCREMENT, RoleName varchar(20))";  // SQL statement to create UserRoles table
                    SQLiteCommand createTableCmd = new SQLiteCommand(createTableSql, sqlite);  // Create a new SQLite command
                    createTableCmd.ExecuteNonQuery();  // Execute the command

                    // Insert default roles if the table is empty
                    string checkRolesSql = "SELECT COUNT(*) FROM UserRoles";  // SQL statement to check if roles exist
                    SQLiteCommand checkRolesCmd = new SQLiteCommand(checkRolesSql, sqlite);  // Create a new SQLite command
                    long roleCount = (long)checkRolesCmd.ExecuteScalar();  // Execute the command and get the role count

                    if (roleCount == 0)
                    {
                        string insertRolesSql = "INSERT INTO UserRoles(RoleName) VALUES ('Receptionist'), ('Manager'), ('Admin')";  // SQL statement to insert default roles
                        SQLiteCommand insertRolesCmd = new SQLiteCommand(insertRolesSql, sqlite);  // Create a new SQLite command
                        insertRolesCmd.ExecuteNonQuery();  // Execute the command
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error creating roles table: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
            }
        }

        private void Create_db()
        {
            try
            {
                if (!System.IO.File.Exists(path))  // Check if the database file exists
                {
                    SQLiteConnection.CreateFile(path);  // Create a new SQLite database file
                }

                using (var sqlite = new SQLiteConnection(cs))  // Create a new SQLite connection
                {
                    sqlite.Open();  // Open the SQLite connection

                    // Create the Users table if it doesn't exist
                    string createTableSql = "CREATE TABLE IF NOT EXISTS Users(UserID varchar(12), Username varchar(20), Password varchar(20), UserType varchar(15))";  // SQL statement to create Users table
                    SQLiteCommand createTableCmd = new SQLiteCommand(createTableSql, sqlite);  // Create a new SQLite command
                    createTableCmd.ExecuteNonQuery();  // Execute the command
                }

                // Create roles table
                CreateRolesTable();  // Call method to create roles table
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error creating database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
            }
        }

        private async Task data_show()
        {
            try
            {
                using (var con = new SQLiteConnection(cs))  // Create a new SQLite connection
                {
                    await con.OpenAsync();  // Open the SQLite connection asynchronously

                    string stm = "SELECT * FROM Users";  // SQL statement to select user data
                    using (var cmd = new SQLiteCommand(stm, con))  // Create a new SQLite command
                    {
                        using (var dr = await cmd.ExecuteReaderAsync())  // Execute the command and get the data reader asynchronously
                        {
                            while (await dr.ReadAsync())  // Read data asynchronously
                            {
                                //string userID = dr.IsDBNull(0) ? string.Empty : dr.GetString(0);  // Get UserID or empty string if null
                                int userID = dr.GetInt32(0); // Assuming userID is stored as an integer in the database
                                string username = dr.IsDBNull(1) ? string.Empty : dr.GetString(1);  // Get Username or empty string if null
                                string password = dr.IsDBNull(2) ? string.Empty : dr.GetString(2);  // Get Password or empty string if null
                                string userType = dr.IsDBNull(3) ? string.Empty : dr.GetString(3);  // Get UserType or empty string if null
                                string userIDString = userID.ToString();

                                this.BeginInvoke((Action)(() =>  // Invoke UI update on the main thread
                                {
                                    dataGridView1.Rows.Add(userIDString, username, password, userType);  // Add data to DataGridView
                                }));
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
            }
        }

        private async void SettingsUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                Create_db();  // Ensure database and tables are created before loading data
                await LoadExistingUsers();  // Load existing users asynchronously
                LoadUserRoles();  // Load user roles into ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during initialization: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
            }
        }

        private async Task LoadExistingUsers()
        {
            dataGridView1.Rows.Clear();  // Clear existing rows in DataGridView
            await data_show();  // Show user data asynchronously
        }

        private void LoadUserRoles()
        {
            try
            {
                List<string> roles = new List<string>();  // Create a list to store roles

                using (var con = new SQLiteConnection(cs))  // Create a new SQLite connection
                {
                    con.Open();  // Open the SQLite connection
                    string stm = "SELECT RoleName FROM UserRoles";  // SQL statement to select role names
                    using (var cmd = new SQLiteCommand(stm, con))  // Create a new SQLite command
                    {
                        using (var dr = cmd.ExecuteReader())  // Execute the command and get the data reader
                        {
                            while (dr.Read())  // Read data
                            {
                                roles.Add(dr.GetString(0));  // Add role name to the list
                            }
                        }
                    }
                }

                userRoleComboBox.Items.Clear();  // Clear existing items in userRoleComboBox
                comboBox1.Items.Clear();  // Clear existing items in comboBox1

                foreach (string role in roles)  // Loop through roles
                {
                    userRoleComboBox.Items.Add(role);  // Add role to userRoleComboBox
                    comboBox1.Items.Add(role);  // Add role to comboBox1
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error loading user roles: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string userId = UserIDtextbox.Text;  // Get UserID from textBox
            string username = UsernametextBox.Text;  // Get Username from textBox
            string password = PasswordtextBox.Text;  // Get Password from textBox
            string userRole = userRoleComboBox.SelectedItem?.ToString();  // Get selected UserRole

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(userRole))
            {
                MessageBox.Show("All fields (UserID, Username, Password, User Role) must be filled out.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Display input error message
                return;
            }

            bool userExists = await Task.Run(() => CheckIfUserExists(userId, username));  // Check if user exists asynchronously
            if (userExists)
            {
                MessageBox.Show("UserID and Username must be unique.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Display uniqueness error message
                return;
            }

            await Task.Run(async () =>
            {
                try
                {
                    using (var con = new SQLiteConnection(cs))  // Create a new SQLite connection
                    {
                        await con.OpenAsync();  // Open the SQLite connection asynchronously
                        using (var cmd = new SQLiteCommand(con))  // Create a new SQLite command
                        {
                            cmd.CommandText = "INSERT INTO Users(UserID, Username, Password, UserType) VALUES(@userid, @username, @password, @usertype)";  // SQL statement to insert user data
                            cmd.Parameters.AddWithValue("@userid", userId);  // Add UserID parameter
                            cmd.Parameters.AddWithValue("@username", username);  // Add Username parameter
                            cmd.Parameters.AddWithValue("@password", password);  // Add Password parameter
                            cmd.Parameters.AddWithValue("@usertype", userRole);  // Add UserRole parameter

                            await cmd.ExecuteNonQueryAsync();  // Execute the command asynchronously

                            this.BeginInvoke((Action)(() =>  // Invoke UI update on the main thread
                            {
                                dataGridView1.Rows.Add(userId, username, password, userRole);  // Add data to DataGridView
                            }));
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show($"Cannot insert data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
                }
            });
        }

        private bool CheckIfUserExists(string userId, string username)
        {
            try
            {
                using (var con = new SQLiteConnection(cs))  // Create a new SQLite connection
                {
                    con.Open();  // Open the SQLite connection
                    string query = "SELECT COUNT(*) FROM Users WHERE UserID = @userid OR Username = @username";  // SQL statement to check if user exists
                    using (var cmd = new SQLiteCommand(query, con))  // Create a new SQLite command
                    {
                        cmd.Parameters.AddWithValue("@userid", userId);  // Add UserID parameter
                        cmd.Parameters.AddWithValue("@username", username);  // Add Username parameter
                        long count = (long)cmd.ExecuteScalar();  // Execute the command and get the count
                        return count > 0;  // Return true if user exists, otherwise false
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error checking user existence: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
                return false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "No row selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Display no row selected message
                return;
            }

            string newUsername = textBox3.Text;  // Get new Username from textBox
            string newPassword = textBox2.Text;  // Get new Password from textBox
            string newUserRole = comboBox1.SelectedItem?.ToString();  // Get selected new UserRole

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(newUserRole))
            {
                MessageBox.Show("All fields (New Username, New Password, New User Role) must be filled out.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Display input error message
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];  // Get selected row
            string userId = selectedRow.Cells["UserID"].Value?.ToString() ?? string.Empty;  // Get UserID from selected row

            bool userExists = await Task.Run(() => CheckIfUsernameExistsForOtherUsers(userId, newUsername));  // Check if username exists for other users asynchronously
            if (userExists)
            {
                MessageBox.Show("New Username must be unique.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Display uniqueness error message
                return;
            }

            await Task.Run(async () =>
            {
                try
                {
                    using (var con = new SQLiteConnection(cs))  // Create a new SQLite connection
                    {
                        await con.OpenAsync();  // Open the SQLite connection asynchronously
                        using (var cmd = new SQLiteCommand(con))  // Create a new SQLite command
                        {
                            cmd.CommandText = "UPDATE Users SET Username = @username, Password = @password, UserType = @usertype WHERE UserID = @userid";  // SQL statement to update user data
                            cmd.Prepare();  // Prepare the command

                            cmd.Parameters.AddWithValue("@userid", userId);  // Add UserID parameter
                            cmd.Parameters.AddWithValue("@username", newUsername);  // Add new Username parameter
                            cmd.Parameters.AddWithValue("@password", newPassword);  // Add new Password parameter
                            cmd.Parameters.AddWithValue("@usertype", newUserRole);  // Add new UserRole parameter

                            await cmd.ExecuteNonQueryAsync();  // Execute the command asynchronously

                            this.BeginInvoke((Action)(async () =>  // Invoke UI update on the main thread
                            {
                                dataGridView1.Rows.Clear();  // Clear existing rows in DataGridView
                                await LoadExistingUsers();  // Load existing users asynchronously
                            }));
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show($"Cannot update data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
                }
            });
        }

        private bool CheckIfUsernameExistsForOtherUsers(string userId, string username)
        {
            try
            {
                using (var con = new SQLiteConnection(cs))  // Create a new SQLite connection
                {
                    con.Open();  // Open the SQLite connection
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND UserID != @userid";  // SQL statement to check if username exists for other users
                    using (var cmd = new SQLiteCommand(query, con))  // Create a new SQLite command
                    {
                        cmd.Parameters.AddWithValue("@userid", userId);  // Add UserID parameter
                        cmd.Parameters.AddWithValue("@username", username);  // Add Username parameter
                        long count = (long)cmd.ExecuteScalar();  // Execute the command and get the count
                        return count > 0;  // Return true if username exists for other users, otherwise false
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error checking username existence: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Display error message
                return false;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No row selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string userId = selectedRow.Cells["UserID"].Value?.ToString() ?? string.Empty;

            await Task.Run(async () =>
            {
                try
                {
                    using (var con = new SQLiteConnection(cs))
                    {
                        await con.OpenAsync();
                        using (var cmd = new SQLiteCommand(con))
                        {
                            cmd.CommandText = "DELETE FROM Users WHERE UserID = @userid";
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@userid", userId);
                            await cmd.ExecuteNonQueryAsync();

                            this.BeginInvoke((Action)(async () =>
                            {
                                dataGridView1.Rows.Clear();
                                await LoadExistingUsers();
                            }));
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show($"Cannot delete data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];  // Get the clicked row
                UserIDtextbox.Text = row.Cells["UserID"].Value?.ToString() ?? string.Empty;  // Set UserIDtextbox value
                UsernametextBox.Text = row.Cells["Username"].Value?.ToString() ?? string.Empty;  // Set UsernametextBox value
                PasswordtextBox.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;  // Set PasswordtextBox value
                userRoleComboBox.SelectedItem = row.Cells["UserRole"].Value?.ToString() ?? string.Empty;  // Set userRoleComboBox selected item
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Handle the label click event if needed
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();  // Clear existing columns in DataGridView

            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",  // Set header text
                DataPropertyName = "UserID",  // Set data property name
                Name = "UserID"  // Set column name
            };
            dataGridView1.Columns.Add(userIdColumn);  // Add column to DataGridView

            DataGridViewTextBoxColumn usernameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Username",  // Set header text
                DataPropertyName = "Username",  // Set data property name
                Name = "Username"  // Set column name
            };
            dataGridView1.Columns.Add(usernameColumn);  // Add column to DataGridView

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Password",  // Set header text
                DataPropertyName = "Password",  // Set data property name
                Name = "Password"  // Set column name
            };
            dataGridView1.Columns.Add(passwordColumn);  // Add column to DataGridView

            DataGridViewTextBoxColumn userRoleColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User Role",  // Set header text
                DataPropertyName = "UserRole",  // Set data property name
                Name = "UserRole"  // Set column name
            };
            dataGridView1.Columns.Add(userRoleColumn);  // Add column to DataGridView
        }

        private void InitializeComboBox()
        {
            userRoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;  // Set ComboBox style to DropDownList
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Handle the button click event if needed
        }

        private void userRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the ComboBox selected index changed event if needed
        }

        private void showHidePassword1_Click(object sender, EventArgs e)
        {
            if (PasswordtextBox.UseSystemPasswordChar)  // Check if password character is being used
            {
                PasswordtextBox.UseSystemPasswordChar = false;  // Show password
                showHidePassword1.Image = Properties.Resources.eye_open;  // Set eye open icon
            }
            else
            {
                PasswordtextBox.UseSystemPasswordChar = true;  // Hide password
                showHidePassword1.Image = Properties.Resources.eye_closed;  // Set eye closed icon
            }
        }

        private void showHidePassword2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)  // Check if password character is being used
            {
                textBox2.UseSystemPasswordChar = false;  // Show password
                showHidePassword2.Image = Properties.Resources.eye_open;  // Set eye open icon
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;  // Hide password
                showHidePassword2.Image = Properties.Resources.eye_closed;  // Set eye closed icon
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}