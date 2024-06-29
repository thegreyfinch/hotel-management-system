namespace Hotel_Management_OOP
{
    partial class SettingsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUserControl));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            UserIDtextbox = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            DeleteUser_btn = new Button();
            EditUser_btn = new Button();
            dataGridView1 = new DataGridView();
            AddUser_btn = new Button();
            PasswordtextBox = new TextBox();
            passlabel = new Label();
            usernamelabel = new Label();
            label3 = new Label();
            UsernametextBox = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            UserRoletextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 174);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 88);
            label1.Name = "label1";
            label1.Size = new Size(192, 39);
            label1.TabIndex = 0;
            label1.Text = "SETTINGS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(UserRoletextBox);
            panel2.Controls.Add(UserIDtextbox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(DeleteUser_btn);
            panel2.Controls.Add(EditUser_btn);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(AddUser_btn);
            panel2.Controls.Add(PasswordtextBox);
            panel2.Controls.Add(passlabel);
            panel2.Controls.Add(usernamelabel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(UsernametextBox);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(1638, 752);
            panel2.TabIndex = 10;
            // 
            // UserIDtextbox
            // 
            UserIDtextbox.BackColor = Color.White;
            UserIDtextbox.BorderStyle = BorderStyle.FixedSingle;
            UserIDtextbox.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserIDtextbox.Location = new Point(532, 81);
            UserIDtextbox.MaxLength = 20;
            UserIDtextbox.Name = "UserIDtextbox";
            UserIDtextbox.Size = new Size(263, 30);
            UserIDtextbox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(396, 87);
            label7.Name = "label7";
            label7.Size = new Size(84, 24);
            label7.TabIndex = 22;
            label7.Text = "User ID:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Receptionist", "Manager", "Admin" });
            comboBox1.Location = new Point(532, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 33);
            comboBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(396, 238);
            label6.Name = "label6";
            label6.Size = new Size(102, 24);
            label6.TabIndex = 20;
            label6.Text = "User Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(72, 34, 22);
            label4.Location = new Point(838, 27);
            label4.Name = "label4";
            label4.Size = new Size(213, 34);
            label4.TabIndex = 19;
            label4.Text = "Existing Users";
            // 
            // DeleteUser_btn
            // 
            DeleteUser_btn.BackColor = Color.Maroon;
            DeleteUser_btn.Cursor = Cursors.Hand;
            DeleteUser_btn.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteUser_btn.ForeColor = Color.White;
            DeleteUser_btn.Location = new Point(588, 458);
            DeleteUser_btn.Name = "DeleteUser_btn";
            DeleteUser_btn.Size = new Size(150, 51);
            DeleteUser_btn.TabIndex = 18;
            DeleteUser_btn.Text = "DELETE";
            DeleteUser_btn.UseVisualStyleBackColor = false;
            DeleteUser_btn.Click += button2_Click;
            // 
            // EditUser_btn
            // 
            EditUser_btn.BackColor = Color.Olive;
            EditUser_btn.Cursor = Cursors.Hand;
            EditUser_btn.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditUser_btn.ForeColor = Color.White;
            EditUser_btn.Location = new Point(588, 388);
            EditUser_btn.Name = "EditUser_btn";
            EditUser_btn.Size = new Size(150, 51);
            EditUser_btn.TabIndex = 17;
            EditUser_btn.Text = "EDIT";
            EditUser_btn.UseVisualStyleBackColor = false;
            EditUser_btn.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(250, 204, 166);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(838, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(656, 428);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddUser_btn
            // 
            AddUser_btn.BackColor = Color.DarkSalmon;
            AddUser_btn.Cursor = Cursors.Hand;
            AddUser_btn.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUser_btn.ForeColor = Color.White;
            AddUser_btn.Location = new Point(588, 314);
            AddUser_btn.Name = "AddUser_btn";
            AddUser_btn.Size = new Size(150, 51);
            AddUser_btn.TabIndex = 15;
            AddUser_btn.Text = "ADD";
            AddUser_btn.UseVisualStyleBackColor = false;
            AddUser_btn.Click += buttonLogin_Click;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.BackColor = Color.White;
            PasswordtextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordtextBox.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordtextBox.Location = new Point(532, 184);
            PasswordtextBox.MaxLength = 20;
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(263, 30);
            PasswordtextBox.TabIndex = 14;
            // 
            // passlabel
            // 
            passlabel.AutoSize = true;
            passlabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passlabel.Location = new Point(396, 184);
            passlabel.Name = "passlabel";
            passlabel.Size = new Size(101, 24);
            passlabel.TabIndex = 13;
            passlabel.Text = "Password:";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelabel.Location = new Point(396, 132);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(107, 24);
            usernamelabel.TabIndex = 12;
            usernamelabel.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(72, 34, 22);
            label3.Location = new Point(396, 27);
            label3.Name = "label3";
            label3.Size = new Size(167, 34);
            label3.TabIndex = 11;
            label3.Text = "Add a User";
            label3.Click += label3_Click;
            // 
            // UsernametextBox
            // 
            UsernametextBox.BackColor = Color.White;
            UsernametextBox.BorderStyle = BorderStyle.FixedSingle;
            UsernametextBox.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernametextBox.Location = new Point(532, 126);
            UsernametextBox.MaxLength = 20;
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(263, 30);
            UsernametextBox.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(25, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 261);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(72, 34, 22);
            label2.Location = new Point(89, 200);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 10;
            label2.Text = "[UserRole]";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(89, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(72, 34, 22);
            label5.Location = new Point(56, 152);
            label5.Name = "label5";
            label5.Size = new Size(184, 34);
            label5.TabIndex = 8;
            label5.Text = "[Username]";
            // 
            // UserRoletextBox
            // 
            UserRoletextBox.BackColor = Color.White;
            UserRoletextBox.BorderStyle = BorderStyle.FixedSingle;
            UserRoletextBox.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserRoletextBox.Location = new Point(532, 238);
            UserRoletextBox.MaxLength = 20;
            UserRoletextBox.Name = "UserRoletextBox";
            UserRoletextBox.Size = new Size(263, 30);
            UserRoletextBox.TabIndex = 24;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SettingsUserControl";
            Size = new Size(1638, 925);
            Load += SettingsUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox UsernametextBox;
        private Label label3;
        private Label usernamelabel;
        private TextBox PasswordtextBox;
        private Label passlabel;
        private DataGridView dataGridView1;
        private Button AddUser_btn;
        private Button DeleteUser_btn;
        private Button EditUser_btn;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox UserIDtextbox;
        private Label label7;
        private TextBox UserRoletextBox;
    }
}
