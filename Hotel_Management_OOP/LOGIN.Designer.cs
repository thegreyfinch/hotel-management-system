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
            Logintitle = new Label();
            buttonLogin = new Button();
            passtextBox = new TextBox();
            passlabel = new Label();
            label1 = new Label();
            UsernametextBox = new TextBox();
            usernamelabel = new Label();
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
            panel1.Controls.Add(Logintitle);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(passtextBox);
            panel1.Controls.Add(passlabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UsernametextBox);
            panel1.Controls.Add(usernamelabel);
            panel1.Location = new Point(60, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 448);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(434, 227);
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
            pictureBox2.Location = new Point(434, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox3_Click;
            // 
            // Logintitle
            // 
            Logintitle.AutoSize = true;
            Logintitle.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logintitle.ForeColor = Color.FromArgb(67, 114, 86);
            Logintitle.Location = new Point(31, 41);
            Logintitle.Name = "Logintitle";
            Logintitle.Size = new Size(137, 41);
            Logintitle.TabIndex = 0;
            Logintitle.Text = "Log In ";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Salmon;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(134, 325);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(266, 62);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button1_Click;
            // 
            // passtextBox
            // 
            passtextBox.BackColor = Color.White;
            passtextBox.BorderStyle = BorderStyle.FixedSingle;
            passtextBox.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passtextBox.Location = new Point(131, 227);
            passtextBox.MaxLength = 20;
            passtextBox.Name = "passtextBox";
            passtextBox.PasswordChar = '*';
            passtextBox.Size = new Size(305, 30);
            passtextBox.TabIndex = 5;
            // 
            // passlabel
            // 
            passlabel.AutoSize = true;
            passlabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passlabel.Location = new Point(31, 231);
            passlabel.Name = "passlabel";
            passlabel.Size = new Size(90, 22);
            passlabel.TabIndex = 4;
            passlabel.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 8F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(31, 179);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 3;
            label1.Text = "Username is case sensitive.";
            // 
            // UsernametextBox
            // 
            UsernametextBox.BackColor = Color.White;
            UsernametextBox.BorderStyle = BorderStyle.FixedSingle;
            UsernametextBox.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernametextBox.Location = new Point(131, 133);
            UsernametextBox.MaxLength = 20;
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(347, 30);
            UsernametextBox.TabIndex = 2;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelabel.Location = new Point(31, 136);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(94, 22);
            usernamelabel.TabIndex = 1;
            usernamelabel.Text = "Username:";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(652, 121);
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
            ClientSize = new Size(1153, 573);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flora Suites (Login)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Logintitle;
        private TextBox UsernametextBox;
        private Label usernamelabel;
        private Label label1;
        private Label label3;
        private TextBox passtextBox;
        private Button buttonLogin;
        private Label passlabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
