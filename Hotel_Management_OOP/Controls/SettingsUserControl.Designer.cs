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
            comboBox1 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            buttonLogin = new Button();
            textBox1 = new TextBox();
            passlabel = new Label();
            usernamelabel = new Label();
            label3 = new Label();
            UsernametextBox = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            UserRole = new DataGridViewTextBoxColumn();
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
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(passlabel);
            panel2.Controls.Add(usernamelabel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(UsernametextBox);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(1638, 752);
            panel2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Receptionist", "Manager", "Admin" });
            comboBox1.Location = new Point(534, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 33);
            comboBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(396, 217);
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
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(588, 433);
            button2.Name = "button2";
            button2.Size = new Size(150, 51);
            button2.TabIndex = 18;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Olive;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(588, 363);
            button1.Name = "button1";
            button1.Size = new Size(150, 51);
            button1.TabIndex = 17;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(250, 204, 166);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Username, Password, UserRole });
            dataGridView1.Location = new Point(838, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(526, 379);
            dataGridView1.TabIndex = 16;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkSalmon;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Segoe UI Variable Small", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(588, 289);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 51);
            buttonLogin.TabIndex = 15;
            buttonLogin.Text = "ADD";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(532, 163);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 30);
            textBox1.TabIndex = 14;
            // 
            // passlabel
            // 
            passlabel.AutoSize = true;
            passlabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passlabel.Location = new Point(396, 163);
            passlabel.Name = "passlabel";
            passlabel.Size = new Size(101, 24);
            passlabel.TabIndex = 13;
            passlabel.Text = "Password:";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelabel.Location = new Point(396, 111);
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
            label3.Location = new Point(396, 32);
            label3.Name = "label3";
            label3.Size = new Size(167, 34);
            label3.TabIndex = 11;
            label3.Text = "Add a User";
            // 
            // UsernametextBox
            // 
            UsernametextBox.BackColor = Color.White;
            UsernametextBox.BorderStyle = BorderStyle.FixedSingle;
            UsernametextBox.Font = new Font("Segoe UI Variable Small Light", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernametextBox.Location = new Point(532, 105);
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
            // UserRole
            // 
            UserRole.HeaderText = "Role";
            UserRole.MinimumWidth = 6;
            UserRole.Name = "UserRole";
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
        private TextBox textBox1;
        private Label passlabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private Button buttonLogin;
        private Button button2;
        private Button button1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
        private DataGridViewTextBoxColumn UserRole;
    }
}
