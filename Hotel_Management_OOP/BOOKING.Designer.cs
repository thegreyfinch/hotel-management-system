namespace Hotel_Management_OOP
{
    partial class BOOKING
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            NoGuests = new DataGridViewTextBoxColumn();
            RoomID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            CheckinDate = new DataGridViewTextBoxColumn();
            CheckOutDate = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 564);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 225);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(125, 157, 66);
            label1.Location = new Point(13, 172);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 1;
            label1.Text = "4 Days(s), $100.0";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(72, 34, 22);
            button1.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(902, 156);
            button1.Name = "button1";
            button1.Size = new Size(392, 66);
            button1.TabIndex = 0;
            button1.Text = "ADD BOOKING";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 182);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(72, 34, 22);
            label5.Location = new Point(13, 12);
            label5.Name = "label5";
            label5.Size = new Size(180, 27);
            label5.TabIndex = 11;
            label5.Text = "BOOKING DETAILS";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(250, 204, 166);
            comboBox2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            comboBox2.ForeColor = Color.FromArgb(72, 34, 22);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBox2.Location = new Point(657, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(288, 28);
            comboBox2.TabIndex = 10;
            comboBox2.Text = "Room Type ID (All)";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label4.ForeColor = Color.FromArgb(72, 34, 22);
            label4.Location = new Point(3, 91);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 9;
            label4.Text = "Available Rooms";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.FromArgb(72, 34, 22);
            dateTimePicker2.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            dateTimePicker2.Location = new Point(608, 34);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(254, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label3.ForeColor = Color.FromArgb(72, 34, 22);
            label3.Location = new Point(409, 78);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 7;
            label3.Text = "Check-out Date:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(250, 204, 166);
            comboBox1.Font = new Font("Segoe UI Variable Text", 8.861538F);
            comboBox1.ForeColor = Color.FromArgb(72, 34, 22);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBox1.Location = new Point(409, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 28);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Status (All)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(72, 34, 22);
            dateTimePicker1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            dateTimePicker1.Location = new Point(312, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(296, 122);
            button2.Name = "button2";
            button2.Size = new Size(84, 36);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            textBox1.Location = new Point(0, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label2.ForeColor = Color.FromArgb(72, 34, 22);
            label2.Location = new Point(312, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Check-in Date";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(250, 204, 166);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text Semibold", 8.861538F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, NoGuests, RoomID, Column2, Column4, CheckinDate, CheckOutDate, Column3 });
            dataGridView1.GridColor = Color.FromArgb(72, 34, 22);
            dataGridView1.Location = new Point(12, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 56;
            dataGridView1.Size = new Size(1297, 340);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label6.ForeColor = Color.FromArgb(72, 34, 22);
            label6.Location = new Point(409, 49);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 12;
            label6.Text = "Check-in Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label7.ForeColor = Color.FromArgb(72, 34, 22);
            label7.Location = new Point(16, 76);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 13;
            label7.Text = "Room:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label8.ForeColor = Color.FromArgb(72, 34, 22);
            label8.Location = new Point(16, 49);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 14;
            label8.Text = "Customer Name:";
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            // 
            // NoGuests
            // 
            NoGuests.HeaderText = "Number of Guests";
            NoGuests.MinimumWidth = 6;
            NoGuests.Name = "NoGuests";
            // 
            // RoomID
            // 
            RoomID.HeaderText = "Room Number";
            RoomID.MinimumWidth = 6;
            RoomID.Name = "RoomID";
            // 
            // Column2
            // 
            Column2.HeaderText = "Room Type";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 7;
            Column4.Name = "Column4";
            // 
            // CheckinDate
            // 
            CheckinDate.HeaderText = "Check-in Date";
            CheckinDate.MinimumWidth = 6;
            CheckinDate.Name = "CheckinDate";
            // 
            // CheckOutDate
            // 
            CheckOutDate.HeaderText = "Check-out Date";
            CheckOutDate.MinimumWidth = 6;
            CheckOutDate.Name = "CheckOutDate";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cost";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label9.ForeColor = Color.FromArgb(72, 34, 22);
            label9.Location = new Point(16, 102);
            label9.Name = "label9";
            label9.Size = new Size(136, 20);
            label9.TabIndex = 15;
            label9.Text = "Number of Guests:";
            // 
            // BOOKING
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1321, 801);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BOOKING";
            ShowIcon = false;
            Text = "Add Booking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn NoGuests;
        private DataGridViewTextBoxColumn RoomID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn CheckinDate;
        private DataGridViewTextBoxColumn CheckOutDate;
        private DataGridViewTextBoxColumn Column3;
    }
}