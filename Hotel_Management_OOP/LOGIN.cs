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
            if (textBox2.PasswordChar == '*')
            {
                pictureBox2.BringToFront();
                textBox2.PasswordChar = '\0';

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox3.BringToFront();
                textBox2.PasswordChar = '*';

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // conditions
            var Username = textBox1.Text;
            var Password = textBox2.Text;

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
                    MessageBox.Show("User Not Found!");
                    //Close();
                }
            }         
          
        }

        public void SuccessfulLogin()
        {
            this.Hide();
            MessageBox.Show("Successful Login!");
            
            SplashScreen form = new SplashScreen();
            form.ShowDialog();
        }
    }
}
