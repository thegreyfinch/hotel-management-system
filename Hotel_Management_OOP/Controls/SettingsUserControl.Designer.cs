namespace Hotel_Management_OOP
{
    partial class SettingsUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUserControl));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            textBox2 = new TextBox();
            showHidePassword2 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            textBox3 = new TextBox();
            UserIDtextbox = new TextBox();
            label7 = new Label();
            userRoleComboBox = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            DeleteUser_btn = new Button();
            EditUser_btn = new Button();
            dataGridView1 = new DataGridView();
            AddUser_btn = new Button();
            PasswordtextBox = new TextBox();
            showHidePassword1 = new PictureBox();
            passlabel = new Label();
            usernamelabel = new Label();
            label3 = new Label();
            UsernametextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showHidePassword2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showHidePassword1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 174);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 88);
            label1.Name = "label1";
            label1.Size = new Size(192, 39);
            label1.TabIndex = 0;
            label1.Text = "SETTINGS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(showHidePassword2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(UserIDtextbox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(userRoleComboBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(DeleteUser_btn);
            panel2.Controls.Add(EditUser_btn);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(AddUser_btn);
            panel2.Controls.Add(PasswordtextBox);
            panel2.Controls.Add(showHidePassword1);
            panel2.Controls.Add(passlabel);
            panel2.Controls.Add(usernamelabel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(UsernametextBox);
            panel2.Location = new Point(0, 188);
            panel2.Name = "panel2";
            panel2.Size = new Size(1679, 752);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(72, 34, 22);
            label8.Location = new Point(73, 347);
            label8.Name = "label8";
            label8.Size = new Size(190, 34);
            label8.TabIndex = 30;
            label8.Text = "Update User";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(246, 521);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 33);
            comboBox1.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(84, 532);
            label9.Name = "label9";
            label9.Size = new Size(147, 24);
            label9.TabIndex = 28;
            label9.Text = "New User Role:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(246, 469);
            textBox2.MaxLength = 20;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 26);
            textBox2.TabIndex = 27;
            textBox2.UseSystemPasswordChar = true;
            // 
            // showHidePassword2
            // 
            showHidePassword2.Location = new Point(510, 468);
            showHidePassword2.Margin = new Padding(4, 4, 4, 4);
            showHidePassword2.Name = "showHidePassword2";
            showHidePassword2.Size = new Size(31, 34);
            showHidePassword2.SizeMode = PictureBoxSizeMode.Zoom;
            showHidePassword2.TabIndex = 0;
            showHidePassword2.TabStop = false;
            showHidePassword2.Click += showHidePassword2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(84, 475);
            label10.Name = "label10";
            label10.Size = new Size(146, 24);
            label10.TabIndex = 26;
            label10.Text = "New Password:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(84, 417);
            label11.Name = "label11";
            label11.Size = new Size(152, 24);
            label11.TabIndex = 25;
            label11.Text = "New Username:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(246, 412);
            textBox3.MaxLength = 20;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 26);
            textBox3.TabIndex = 24;
            // 
            // UserIDtextbox
            // 
            UserIDtextbox.BackColor = Color.White;
            UserIDtextbox.BorderStyle = BorderStyle.FixedSingle;
            UserIDtextbox.Font = new Font("Microsoft Sans Serif", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserIDtextbox.Location = new Point(246, 81);
            UserIDtextbox.MaxLength = 20;
            UserIDtextbox.Name = "UserIDtextbox";
            UserIDtextbox.Size = new Size(263, 26);
            UserIDtextbox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(85, 87);
            label7.Name = "label7";
            label7.Size = new Size(84, 24);
            label7.TabIndex = 22;
            label7.Text = "User ID:";
            // 
            // userRoleComboBox
            // 
            userRoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userRoleComboBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userRoleComboBox.FormattingEnabled = true;
            userRoleComboBox.Location = new Point(246, 235);
            userRoleComboBox.Name = "userRoleComboBox";
            userRoleComboBox.Size = new Size(261, 33);
            userRoleComboBox.TabIndex = 21;
            userRoleComboBox.SelectedIndexChanged += userRoleComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 246);
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
            label4.Location = new Point(639, 27);
            label4.Name = "label4";
            label4.Size = new Size(213, 34);
            label4.TabIndex = 19;
            label4.Text = "Existing Users";
            // 
            // DeleteUser_btn
            // 
            DeleteUser_btn.BackColor = Color.Maroon;
            DeleteUser_btn.Cursor = Cursors.Hand;
            DeleteUser_btn.Font = new Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteUser_btn.ForeColor = Color.White;
            DeleteUser_btn.Location = new Point(901, 515);
            DeleteUser_btn.Name = "DeleteUser_btn";
            DeleteUser_btn.Size = new Size(150, 50);
            DeleteUser_btn.TabIndex = 18;
            DeleteUser_btn.Text = "DELETE";
            DeleteUser_btn.UseVisualStyleBackColor = false;
            DeleteUser_btn.Click += button2_Click;
            // 
            // EditUser_btn
            // 
            EditUser_btn.BackColor = Color.Olive;
            EditUser_btn.Cursor = Cursors.Hand;
            EditUser_btn.Font = new Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditUser_btn.ForeColor = Color.White;
            EditUser_btn.Location = new Point(303, 564);
            EditUser_btn.Name = "EditUser_btn";
            EditUser_btn.Size = new Size(150, 50);
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
            dataGridView1.Location = new Point(639, 81);
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
            AddUser_btn.Font = new Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUser_btn.ForeColor = Color.White;
            AddUser_btn.Location = new Point(303, 279);
            AddUser_btn.Name = "AddUser_btn";
            AddUser_btn.Size = new Size(150, 50);
            AddUser_btn.TabIndex = 15;
            AddUser_btn.Text = "ADD";
            AddUser_btn.UseVisualStyleBackColor = false;
            AddUser_btn.Click += buttonLogin_Click;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.BackColor = Color.White;
            PasswordtextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordtextBox.Font = new Font("Microsoft Sans Serif", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordtextBox.Location = new Point(246, 183);
            PasswordtextBox.MaxLength = 20;
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(263, 26);
            PasswordtextBox.TabIndex = 14;
            PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // showHidePassword1
            // 
            showHidePassword1.Location = new Point(510, 182);
            showHidePassword1.Margin = new Padding(4, 4, 4, 4);
            showHidePassword1.Name = "showHidePassword1";
            showHidePassword1.Size = new Size(31, 34);
            showHidePassword1.SizeMode = PictureBoxSizeMode.Zoom;
            showHidePassword1.TabIndex = 0;
            showHidePassword1.TabStop = false;
            showHidePassword1.Click += showHidePassword1_Click;
            // 
            // passlabel
            // 
            passlabel.AutoSize = true;
            passlabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passlabel.Location = new Point(85, 190);
            passlabel.Name = "passlabel";
            passlabel.Size = new Size(101, 24);
            passlabel.TabIndex = 13;
            passlabel.Text = "Password:";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelabel.Location = new Point(85, 132);
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
            label3.Location = new Point(85, 27);
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
            UsernametextBox.Font = new Font("Microsoft Sans Serif", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernametextBox.Location = new Point(246, 126);
            UsernametextBox.MaxLength = 20;
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(263, 26);
            UsernametextBox.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)showHidePassword2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showHidePassword1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddUser_btn;
        private System.Windows.Forms.Button DeleteUser_btn;
        private System.Windows.Forms.Button EditUser_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserIDtextbox;
        private System.Windows.Forms.Label label7;
        private ComboBox comboBox1;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private Label label11;
        private TextBox textBox3;
        private Label label8;
        private Label label2;
        private Label label5;
        private PictureBox showHidePassword1;
        private PictureBox showHidePassword2;
    }
}