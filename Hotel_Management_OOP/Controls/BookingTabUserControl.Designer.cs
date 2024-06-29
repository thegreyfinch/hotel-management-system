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
            dataGridViewBooking = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            BookingdatetextBox8 = new TextBox();
            BStatustextBox7 = new TextBox();
            PricetextBox6 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            CheckouttextBox5 = new TextBox();
            CheckintextBox4 = new TextBox();
            RoomIDtextBox3 = new TextBox();
            CustIDextBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BookingIDtextBox1 = new TextBox();
            SaveBookingBtn = new Button();
            RemoveBookingBtn = new Button();
            AddBookingBtn = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label20 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooking).BeginInit();
            SuspendLayout();
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
            dataGridViewBooking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, Column6, Column7, Column8 });
            dataGridViewBooking.Location = new Point(29, 82);
            dataGridViewBooking.Name = "dataGridViewBooking";
            dataGridViewBooking.RowHeadersWidth = 56;
            dataGridViewBooking.Size = new Size(1593, 238);
            dataGridViewBooking.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Booking_ID";
            dataGridViewTextBoxColumn4.MinimumWidth = 7;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Customer_ID";
            dataGridViewTextBoxColumn5.MinimumWidth = 7;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Room_ID";
            dataGridViewTextBoxColumn6.MinimumWidth = 7;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Check-in";
            dataGridViewTextBoxColumn7.MinimumWidth = 7;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Check-out";
            dataGridViewTextBoxColumn8.MinimumWidth = 7;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Column6
            // 
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 7;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Booking_Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Booking_Date";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // BookingdatetextBox8
            // 
            BookingdatetextBox8.BorderStyle = BorderStyle.FixedSingle;
            BookingdatetextBox8.Cursor = Cursors.IBeam;
            BookingdatetextBox8.Location = new Point(824, 439);
            BookingdatetextBox8.Name = "BookingdatetextBox8";
            BookingdatetextBox8.Size = new Size(423, 29);
            BookingdatetextBox8.TabIndex = 41;
            // 
            // BStatustextBox7
            // 
            BStatustextBox7.BorderStyle = BorderStyle.FixedSingle;
            BStatustextBox7.Cursor = Cursors.IBeam;
            BStatustextBox7.Location = new Point(824, 395);
            BStatustextBox7.Name = "BStatustextBox7";
            BStatustextBox7.Size = new Size(423, 29);
            BStatustextBox7.TabIndex = 40;
            // 
            // PricetextBox6
            // 
            PricetextBox6.BorderStyle = BorderStyle.FixedSingle;
            PricetextBox6.Cursor = Cursors.IBeam;
            PricetextBox6.Location = new Point(824, 350);
            PricetextBox6.Name = "PricetextBox6";
            PricetextBox6.Size = new Size(423, 29);
            PricetextBox6.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(682, 442);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 38;
            label9.Text = "Booking Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(682, 396);
            label8.Name = "label8";
            label8.Size = new Size(116, 21);
            label8.TabIndex = 37;
            label8.Text = "Booking Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(682, 352);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 36;
            label7.Text = "Price:";
            // 
            // CheckouttextBox5
            // 
            CheckouttextBox5.BorderStyle = BorderStyle.FixedSingle;
            CheckouttextBox5.Cursor = Cursors.IBeam;
            CheckouttextBox5.Location = new Point(152, 538);
            CheckouttextBox5.Name = "CheckouttextBox5";
            CheckouttextBox5.Size = new Size(423, 29);
            CheckouttextBox5.TabIndex = 35;
            // 
            // CheckintextBox4
            // 
            CheckintextBox4.BorderStyle = BorderStyle.FixedSingle;
            CheckintextBox4.Cursor = Cursors.IBeam;
            CheckintextBox4.Location = new Point(152, 493);
            CheckintextBox4.Name = "CheckintextBox4";
            CheckintextBox4.Size = new Size(423, 29);
            CheckintextBox4.TabIndex = 34;
            // 
            // RoomIDtextBox3
            // 
            RoomIDtextBox3.BorderStyle = BorderStyle.FixedSingle;
            RoomIDtextBox3.Cursor = Cursors.IBeam;
            RoomIDtextBox3.Location = new Point(152, 445);
            RoomIDtextBox3.Name = "RoomIDtextBox3";
            RoomIDtextBox3.Size = new Size(423, 29);
            RoomIDtextBox3.TabIndex = 33;
            // 
            // CustIDextBox2
            // 
            CustIDextBox2.BorderStyle = BorderStyle.FixedSingle;
            CustIDextBox2.Cursor = Cursors.IBeam;
            CustIDextBox2.Location = new Point(152, 395);
            CustIDextBox2.Name = "CustIDextBox2";
            CustIDextBox2.Size = new Size(423, 29);
            CustIDextBox2.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 540);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 31;
            label6.Text = "Check-out:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 495);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 30;
            label5.Text = "Check-in:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 445);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 29;
            label4.Text = "Room ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 401);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 28;
            label3.Text = "Cutomer ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 352);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 27;
            label2.Text = "Booking ID:";
            // 
            // BookingIDtextBox1
            // 
            BookingIDtextBox1.BorderStyle = BorderStyle.FixedSingle;
            BookingIDtextBox1.Cursor = Cursors.IBeam;
            BookingIDtextBox1.Location = new Point(152, 349);
            BookingIDtextBox1.Name = "BookingIDtextBox1";
            BookingIDtextBox1.Size = new Size(423, 29);
            BookingIDtextBox1.TabIndex = 26;
            // 
            // SaveBookingBtn
            // 
            SaveBookingBtn.BackColor = Color.FromArgb(125, 157, 66);
            SaveBookingBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBookingBtn.ForeColor = Color.White;
            SaveBookingBtn.Location = new Point(1389, 485);
            SaveBookingBtn.Name = "SaveBookingBtn";
            SaveBookingBtn.Size = new Size(191, 59);
            SaveBookingBtn.TabIndex = 43;
            SaveBookingBtn.Text = "Save";
            SaveBookingBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveBookingBtn
            // 
            RemoveBookingBtn.BackColor = Color.Maroon;
            RemoveBookingBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveBookingBtn.ForeColor = Color.White;
            RemoveBookingBtn.Location = new Point(1389, 409);
            RemoveBookingBtn.Name = "RemoveBookingBtn";
            RemoveBookingBtn.Size = new Size(191, 59);
            RemoveBookingBtn.TabIndex = 44;
            RemoveBookingBtn.Text = "Remove... -";
            RemoveBookingBtn.UseVisualStyleBackColor = false;
            // 
            // AddBookingBtn
            // 
            AddBookingBtn.BackColor = Color.Coral;
            AddBookingBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBookingBtn.ForeColor = Color.White;
            AddBookingBtn.Location = new Point(1389, 336);
            AddBookingBtn.Name = "AddBookingBtn";
            AddBookingBtn.Size = new Size(193, 59);
            AddBookingBtn.TabIndex = 42;
            AddBookingBtn.Text = "Add... +";
            AddBookingBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            textBox1.Location = new Point(1126, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 45;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1445, 21);
            button2.Name = "button2";
            button2.Size = new Size(84, 36);
            button2.TabIndex = 46;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(72, 34, 22);
            label20.Location = new Point(29, 27);
            label20.Name = "label20";
            label20.Size = new Size(143, 34);
            label20.TabIndex = 47;
            label20.Text = "Bookings";
            // 
            // BookingTabUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(label20);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(SaveBookingBtn);
            Controls.Add(RemoveBookingBtn);
            Controls.Add(AddBookingBtn);
            Controls.Add(BookingdatetextBox8);
            Controls.Add(BStatustextBox7);
            Controls.Add(PricetextBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(CheckouttextBox5);
            Controls.Add(CheckintextBox4);
            Controls.Add(RoomIDtextBox3);
            Controls.Add(CustIDextBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BookingIDtextBox1);
            Controls.Add(dataGridViewBooking);
            Name = "BookingTabUserControl";
            Size = new Size(1638, 641);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBooking;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox BookingdatetextBox8;
        private TextBox BStatustextBox7;
        private TextBox PricetextBox6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox CheckouttextBox5;
        private TextBox CheckintextBox4;
        private TextBox RoomIDtextBox3;
        private TextBox CustIDextBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox BookingIDtextBox1;
        private Button SaveBookingBtn;
        private Button RemoveBookingBtn;
        private Button AddBookingBtn;
        private TextBox textBox1;
        private Button button2;
        private Label label20;
    }
}
