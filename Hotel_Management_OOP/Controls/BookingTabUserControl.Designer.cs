namespace Hotel_Management_OOP.Controls
{
    partial class BookingTabUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label20 = new Label();
            label2 = new Label();
            dataGridViewBooking = new DataGridView();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            label9 = new Label();
            comboBox5 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            dateTimePicker3 = new DateTimePicker();
            textBox6 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            textBox2 = new TextBox();
            label19 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label22 = new Label();
            SaveBBtn = new Button();
            AddBbtn = new Button();
            EditBBtn = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooking).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(72, 34, 22);
            label20.Location = new Point(23, 23);
            label20.Name = "label20";
            label20.Size = new Size(143, 34);
            label20.TabIndex = 55;
            label20.Text = "Bookings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label2.ForeColor = Color.FromArgb(72, 34, 22);
            label2.Location = new Point(439, 81);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 54;
            // 
            // dataGridViewBooking
            // 
            dataGridViewBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooking.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooking.Location = new Point(23, 122);
            dataGridViewBooking.Name = "dataGridViewBooking";
            dataGridViewBooking.RowHeadersWidth = 56;
            dataGridViewBooking.Size = new Size(1593, 240);
            dataGridViewBooking.TabIndex = 51;
            dataGridViewBooking.CellContentClick += dataGridViewBooking_CellContentClick;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(250, 204, 166);
            comboBox2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            comboBox2.ForeColor = Color.FromArgb(72, 34, 22);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBox2.Location = new Point(1063, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(288, 28);
            comboBox2.TabIndex = 52;
            comboBox2.Text = "Room Type (All)";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            textBox4.Location = new Point(36, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 27);
            textBox4.TabIndex = 49;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(72, 34, 22);
            button3.Font = new Font("Segoe UI Variable Text", 8.861538F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(325, 73);
            button3.Name = "button3";
            button3.Size = new Size(84, 36);
            button3.TabIndex = 48;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(250, 204, 166);
            comboBox1.Font = new Font("Segoe UI Variable Text", 8.861538F);
            comboBox1.ForeColor = Color.FromArgb(72, 34, 22);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBox1.Location = new Point(1376, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 28);
            comboBox1.TabIndex = 50;
            comboBox1.Text = "Status (All)";
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBox5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label22);
            panel2.Location = new Point(23, 384);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 226);
            panel2.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label9.ForeColor = Color.FromArgb(72, 34, 22);
            label9.Location = new Point(625, 132);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 34;
            label9.Text = "PHP0.00";
            label9.Click += label9_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Cash", "Card" });
            comboBox5.Location = new Point(625, 91);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(281, 29);
            comboBox5.TabIndex = 33;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label8.ForeColor = Color.FromArgb(72, 34, 22);
            label8.Location = new Point(495, 132);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 31;
            label8.Text = "Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label7.ForeColor = Color.FromArgb(72, 34, 22);
            label7.Location = new Point(495, 91);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 30;
            label7.Text = "Payment Method:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Male", "Female" });
            comboBox3.Location = new Point(149, 169);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(281, 29);
            comboBox3.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label5.ForeColor = Color.FromArgb(72, 34, 22);
            label5.Location = new Point(7, 172);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 27;
            label5.Text = "Sex:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarForeColor = Color.FromArgb(72, 34, 22);
            dateTimePicker3.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            dateTimePicker3.Location = new Point(149, 88);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(281, 27);
            dateTimePicker3.TabIndex = 26;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(149, 128);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(281, 29);
            textBox6.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label4.ForeColor = Color.FromArgb(72, 34, 22);
            label4.Location = new Point(7, 133);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 23;
            label4.Text = "Contact Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label3.ForeColor = Color.FromArgb(72, 34, 22);
            label3.Location = new Point(7, 91);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 22;
            label3.Text = "Birthdate:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(149, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 29);
            textBox3.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label17.ForeColor = Color.FromArgb(72, 34, 22);
            label17.Location = new Point(495, 51);
            label17.Name = "label17";
            label17.Size = new Size(119, 20);
            label17.TabIndex = 18;
            label17.Text = "Check-out Date:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label18.ForeColor = Color.FromArgb(72, 34, 22);
            label18.Location = new Point(7, 48);
            label18.Name = "label18";
            label18.Size = new Size(136, 20);
            label18.TabIndex = 17;
            label18.Text = "Number of Guests:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(149, 7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 29);
            textBox2.TabIndex = 16;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label19.ForeColor = Color.FromArgb(72, 34, 22);
            label19.Location = new Point(7, 8);
            label19.Name = "label19";
            label19.Size = new Size(123, 20);
            label19.TabIndex = 15;
            label19.Text = "Customer Name:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.FromArgb(72, 34, 22);
            dateTimePicker2.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            dateTimePicker2.Location = new Point(625, 49);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(277, 27);
            dateTimePicker2.TabIndex = 8;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged_2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(72, 34, 22);
            dateTimePicker1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            dateTimePicker1.Location = new Point(625, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(277, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_2;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label22.ForeColor = Color.FromArgb(72, 34, 22);
            label22.Location = new Point(495, 12);
            label22.Name = "label22";
            label22.Size = new Size(105, 20);
            label22.TabIndex = 2;
            label22.Text = "Check-in Date";
            // 
            // SaveBBtn
            // 
            SaveBBtn.BackColor = Color.Maroon;
            SaveBBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBBtn.ForeColor = Color.White;
            SaveBBtn.Location = new Point(1406, 383);
            SaveBBtn.Name = "SaveBBtn";
            SaveBBtn.Size = new Size(191, 59);
            SaveBBtn.TabIndex = 66;
            SaveBBtn.Text = "Save";
            SaveBBtn.UseVisualStyleBackColor = false;
            SaveBBtn.Click += SaveGuestBtn_Click;
            // 
            // AddBbtn
            // 
            AddBbtn.BackColor = Color.Coral;
            AddBbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBbtn.ForeColor = Color.White;
            AddBbtn.Location = new Point(952, 383);
            AddBbtn.Name = "AddBbtn";
            AddBbtn.Size = new Size(193, 59);
            AddBbtn.TabIndex = 65;
            AddBbtn.Text = "Add... +";
            AddBbtn.UseVisualStyleBackColor = false;
            AddBbtn.Click += AddGuestbtn_Click;
            // 
            // EditBBtn
            // 
            EditBBtn.BackColor = Color.FromArgb(125, 157, 66);
            EditBBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBBtn.ForeColor = Color.White;
            EditBBtn.Location = new Point(1181, 383);
            EditBBtn.Name = "EditBBtn";
            EditBBtn.Size = new Size(193, 59);
            EditBBtn.TabIndex = 67;
            EditBBtn.Text = "Edit";
            EditBBtn.UseVisualStyleBackColor = false;
            EditBBtn.Click += EditBBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label6.ForeColor = Color.FromArgb(72, 34, 22);
            label6.Location = new Point(712, 80);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 69;
            label6.Text = "Room ID:";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(790, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 29);
            textBox1.TabIndex = 68;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 614);
            panel1.TabIndex = 70;
            panel1.Paint += panel1_Paint;
            // 
            // BookingTabUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(EditBBtn);
            Controls.Add(SaveBBtn);
            Controls.Add(AddBbtn);
            Controls.Add(panel2);
            Controls.Add(label20);
            Controls.Add(label2);
            Controls.Add(dataGridViewBooking);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "BookingTabUserControl";
            Size = new Size(1638, 641);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooking).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label20;
        private Label label2;
        private DataGridView dataGridViewBooking;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private Button button3;
        private ComboBox comboBox1;
        private Panel panel2;
        private ComboBox comboBox3;
        private Label label5;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox6;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private Label label17;
        private Label label18;
        private TextBox textBox2;
        private Label label19;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label22;
        private Button SaveBBtn;
        private Button AddBbtn;
        private Button EditBBtn;
        private Label label6;
        private TextBox textBox1;
        public Panel panel1;
        private Label label9;
        private ComboBox comboBox5;
        private Label label8;
        private Label label7;
    }
}
