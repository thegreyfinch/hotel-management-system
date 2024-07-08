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
using System.IO;

using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace Hotel_Management_OOP
{
    public partial class SettingsUserControl : UserControl
    {
        // path of database
        string path = "FloraSuitesLoginDB.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\FloraSuitesLoginDB.db"; //database create debug folder

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;



        // private UserDataContext? dbContext;
        public SettingsUserControl()
        {
            InitializeComponent();
        }


        //create db and table
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table Users(UserID varchar(12), Username varchar(20), Password varchar(20), UserType varchar(15)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database cannot be created");
                return;
            }
        }

        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM Users";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SettingsUserControl_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        // Add User -- Inser to DB
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO Users(UserID,Username,Password,UserType) VALUES(@userid,@username,@password,@usertype";

                string USERID = UserIDtextbox.Text;
                string USERNAME = UsernametextBox.Text;
                string PASSWORD = PasswordtextBox.Text;
                string USERTYPE = comboBox1.Text;

                cmd.Parameters.AddWithValue("@userid", USERID);
                cmd.Parameters.AddWithValue("@username", USERNAME);
                cmd.Parameters.AddWithValue("@password", PASSWORD);
                cmd.Parameters.AddWithValue("@usertype", USERTYPE);

                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "User Id";
                dataGridView1.Columns[1].Name = "Username";
                dataGridView1.Columns[2].Name = "Password";
                dataGridView1.Columns[3].Name = "User Type";
                string[] row = new string[] { USERID, USERNAME, PASSWORD, USERTYPE };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot insert data");
                return;
            }


        }
        //Edit data

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var CMD = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE Users Set userid=@UserId where username =@Username";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@userid", UserIDtextbox.Text);
                cmd.Parameters.AddWithValue("@username", UsernametextBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordtextBox.Text);
                cmd.Parameters.AddWithValue("@usertype", comboBox1.Text);


                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();

            }
            catch (Exception)
            {
                Console.WriteLine("Cannot Update Data");
                return;
            }
        }

        //Delete
        private void button2_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var CMD = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM Users WHERE userid =@userid";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@userid", UserIDtextbox.Text);
                cmd.Parameters.AddWithValue("@username", UsernametextBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordtextBox.Text);
                cmd.Parameters.AddWithValue("@usertype", comboBox1.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();

            }
            catch (Exception)
            {
                Console.WriteLine("Cannot Delete Data");
                return;
            }
        }

        /*private void dataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                name_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                id_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();

            }
        }*/
        private void label3_Click(object sender, EventArgs e)
        {

        }


        /*
       protected override void OnLoad(EventArgs e)
       {
           base.OnLoad(e);

           //loading of database objects
           this.dbContext = new UserDataContext();

           //this.dbContext.Database.EnsureDeleted();
           this.dbContext.Database.EnsureCreated();

           this.dbContext.Users.Load();

           this.usersBindingSource.DataSource = this.dbContext.Users.Local.ToBindingList();

       }

       protected override void OnClosing(CancelEventArgs e)
       {
           base.OnClosing(e);

           this.dbContext?.Dispose();
           this.dbContext = null;
       }
*/
        /* private void data_show()
         {
             var con = new SQLiteConnection(cs);
             con.Open();

             string stm = "SELECT * FROM test";
             var cmd = new SQLiteCommand(stm, con);
             dr = cmd.ExecuteReader();

             while (dr.Read())
             {
                 dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
             }
         }
         private void dataGridView1_SelectionChanged(object sender, EventArgs e)
         {

             if (this.dbContext != null)
             {
                 var user = (User)this.dataGridView1.CurrentRow.DataBoundItem;

                 if (user != null)
                 {
                     //this.dbContext.Entry(user).Collection(e => e.Username).Load();
                 }
             }
         }*/
    }
}
