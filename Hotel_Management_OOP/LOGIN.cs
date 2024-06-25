using System.Data.SQLite;
namespace Hotel_Management_OOP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (passtextBox.PasswordChar == '*')
            {
                pictureBox2.BringToFront();
                passtextBox.PasswordChar = '\0';

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (passtextBox.PasswordChar == '\0')
            {
                pictureBox3.BringToFront();
                passtextBox.PasswordChar = '*';

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Username = UsernametextBox.Text;
            var Password = passtextBox.Text;
            // conditions

            //Empty Fields
            if (UsernametextBox.Text == "" || passtextBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {//Database List of Approved Users
                using (UserDataContext context = new UserDataContext())
                {
                    bool userfound = context.Users.Any(User => User.Username == Username && User.Password == Password);

                    if (userfound)
                    {
                        //Close();
                        SuccessfulLogin();

                    }


                    else
                    {
                        MessageBox.Show("User Not Found!", "Error Message", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Close();
                    }
                }
            }
        }

        public void SuccessfulLogin()
        {
            this.Hide();
            MessageBox.Show("Successful Login!", "Information Message", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            SplashScreen form = new SplashScreen();
            form.ShowDialog();
        }
    }
}
