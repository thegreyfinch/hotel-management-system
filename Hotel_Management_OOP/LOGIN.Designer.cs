namespace Hotel_Management_OOP
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            title = new Label();
            buttonLogin = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            username = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(title);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(username);
            panel1.Location = new Point(47, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 484);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(423, 268);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(423, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(132, 417);
            label5.Name = "label5";
            label5.Size = new Size(240, 28);
            label5.TabIndex = 2;
            label5.Text = "Continue as Administrator";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(67, 114, 86);
            title.Location = new Point(31, 41);
            title.Name = "title";
            title.Size = new Size(122, 35);
            title.TabIndex = 0;
            title.Text = "Log In ";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Salmon;
            buttonLogin.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(117, 333);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(266, 62);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(31, 268);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(396, 30);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small Semibol", 10F);
            label2.Location = new Point(31, 227);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 8F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(31, 186);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 3;
            label1.Text = "Username is case sensitive.";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(31, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 30);
            textBox1.TabIndex = 2;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI Variable Small Semibol", 10F);
            username.Location = new Point(31, 106);
            username.Name = "username";
            username.Size = new Size(90, 22);
            username.TabIndex = 1;
            username.Text = "Username";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(644, 129);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(387, 325);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1153, 584);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flora Suite (Login)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label title;
        private TextBox textBox1;
        private Label username;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Button buttonLogin;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox4;
    }
}
