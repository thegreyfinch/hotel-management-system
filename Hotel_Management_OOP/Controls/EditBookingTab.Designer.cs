namespace Hotel_Management_OOP.Controls
{
    partial class EditBookingTab
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
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(183, 324);
            comboBox3.Margin = new Padding(2, 2, 2, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(195, 23);
            comboBox3.TabIndex = 68;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBox2.Location = new Point(187, 231);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 23);
            comboBox2.TabIndex = 67;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 351);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 23);
            textBox3.TabIndex = 65;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 296);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 64;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 141);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 63;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(183, 377);
            dateTimePicker3.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(195, 23);
            dateTimePicker3.TabIndex = 62;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(183, 105);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(195, 23);
            dateTimePicker2.TabIndex = 61;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(183, 71);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 60;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(511, 356);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 41);
            button1.TabIndex = 59;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 383);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 58;
            label13.Text = "Birthdate:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 356);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(99, 15);
            label12.TabIndex = 57;
            label12.Text = "Contact Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 356);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 56;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 330);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 55;
            label10.Text = "Customer Sex:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 301);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 54;
            label9.Text = "Customer Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 231);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 53;
            label8.Text = "Room Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 206);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 52;
            label7.Text = "Room ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 135);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 51;
            label6.Text = "Number of Guests:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 105);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 50;
            label5.Text = "Check-out Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 49;
            label4.Text = "Check-in Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 268);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(241, 25);
            label3.TabIndex = 48;
            label3.Text = "Edit Customer Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 173);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 47;
            label2.Text = "Edit Room Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 46;
            label1.Text = "Edit Booking Information";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(187, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 23);
            textBox4.TabIndex = 69;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // EditBookingTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EditBookingTab";
            Size = new Size(692, 439);
            Load += EditBookingTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
    }
}
