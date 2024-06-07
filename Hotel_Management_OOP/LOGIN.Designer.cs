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
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            username = new Label();
            title = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(username);
            panel1.Controls.Add(title);
            panel1.Location = new Point(518, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 715);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(141, 550);
            button1.Name = "button1";
            button1.Size = new Size(436, 62);
            button1.TabIndex = 7;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small Semibol", 11F);
            label3.ForeColor = Color.FromArgb(67, 114, 86);
            label3.Location = new Point(401, 458);
            label3.Name = "label3";
            label3.Size = new Size(176, 27);
            label3.TabIndex = 6;
            label3.Text = "Forgot Password?";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(141, 390);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(436, 31);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small Semibol", 10F);
            label2.Location = new Point(141, 349);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 8F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(141, 275);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 3;
            label1.Text = "Username is case sensitive.";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(141, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 31);
            textBox1.TabIndex = 2;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI Variable Small Semibol", 10F);
            username.Location = new Point(141, 184);
            username.Name = "username";
            username.Size = new Size(100, 26);
            username.TabIndex = 1;
            username.Text = "Username";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Variable Text Semibold", 20F);
            title.ForeColor = Color.FromArgb(67, 114, 86);
            title.Location = new Point(141, 49);
            title.Name = "title";
            title.Size = new Size(429, 49);
            title.TabIndex = 0;
            title.Text = "Welcome to Flora Suites";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 715);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1216, 716);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Login";
            ShowIcon = false;
            Text = "Flora Suite (Login)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
