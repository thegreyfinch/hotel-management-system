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
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 688);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 18F);
            label1.ForeColor = Color.FromArgb(125, 157, 66);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(265, 44);
            label1.TabIndex = 1;
            label1.Text = "4 Days(s), $100.0";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(72, 34, 22);
            button1.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(905, 32);
            button1.Name = "button1";
            button1.Size = new Size(392, 66);
            button1.TabIndex = 0;
            button1.Text = "ADD BOOKING";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(radioButton1);
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
            label5.Location = new Point(3, 1);
            label5.Name = "label5";
            label5.Size = new Size(215, 30);
            label5.TabIndex = 11;
            label5.Text = "Customer: John Doe";
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
            comboBox2.Size = new Size(288, 29);
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
            label4.Size = new Size(137, 22);
            label4.TabIndex = 9;
            label4.Text = "Available Rooms";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.FromArgb(72, 34, 22);
            dateTimePicker2.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            dateTimePicker2.Location = new Point(608, 34);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(254, 29);
            dateTimePicker2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label3.ForeColor = Color.FromArgb(72, 34, 22);
            label3.Location = new Point(608, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 22);
            label3.TabIndex = 7;
            label3.Text = "Check-out Date";
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
            comboBox1.Size = new Size(199, 29);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Status (All)";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.FromArgb(72, 34, 22);
            radioButton1.Location = new Point(999, 128);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 25);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Check in";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(72, 34, 22);
            dateTimePicker1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            dateTimePicker1.Location = new Point(312, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 29);
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
            textBox1.Size = new Size(290, 29);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label2.ForeColor = Color.FromArgb(72, 34, 22);
            label2.Location = new Point(312, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 2;
            label2.Text = "Check-in Date";
            // 
            // dataGridView1
            // 
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.GridColor = Color.FromArgb(72, 34, 22);
            dataGridView1.Location = new Point(12, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 56;
            dataGridView1.Size = new Size(1297, 402);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            Column1.Width = 400;
            // 
            // Column2
            // 
            Column2.HeaderText = "Room Type";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.Width = 239;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cost";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            Column3.Width = 300;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 7;
            Column4.Name = "Column4";
            Column4.Width = 300;
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
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}