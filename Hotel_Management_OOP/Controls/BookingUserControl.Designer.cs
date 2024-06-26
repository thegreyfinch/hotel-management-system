namespace Hotel_Management_OOP
{
    partial class BookingUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingUserControl));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            button1 = new Button();
            tabControl1 = new TabControl();
            Booking = new TabPage();
            dataGridViewBooking = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            button12 = new Button();
            pictureBox4 = new PictureBox();
            Guests = new TabPage();
            dataGridViewGuests = new DataGridView();
            Gn = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Rooms = new TabPage();
            dataGridViewRooms = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            PricePerNight = new DataGridViewTextBoxColumn();
            button5 = new Button();
            guestaddbutton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button11 = new Button();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            Booking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Guests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.LightSalmon;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(tabControl1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(guestaddbutton);
            panel2.Location = new Point(0, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(1638, 818);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1130, 614);
            button1.Name = "button1";
            button1.Size = new Size(191, 59);
            button1.TabIndex = 7;
            button1.Text = "Remove... -";
            button1.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Booking);
            tabControl1.Controls.Add(Guests);
            tabControl1.Controls.Add(Rooms);
            tabControl1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(14, 17);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(65, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1606, 581);
            tabControl1.TabIndex = 6;
            // 
            // Booking
            // 
            Booking.BackColor = Color.FromArgb(64, 0, 0);
            Booking.Controls.Add(dataGridViewBooking);
            Booking.Controls.Add(button12);
            Booking.Controls.Add(pictureBox4);
            Booking.Location = new Point(4, 34);
            Booking.Name = "Booking";
            Booking.Padding = new Padding(3);
            Booking.Size = new Size(1598, 543);
            Booking.TabIndex = 0;
            Booking.Text = "Booking";
            // 
            // dataGridViewBooking
            // 
            dataGridViewBooking.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, Column6, Column7, Column8 });
            dataGridViewBooking.Location = new Point(0, 3);
            dataGridViewBooking.Name = "dataGridViewBooking";
            dataGridViewBooking.RowHeadersWidth = 56;
            dataGridViewBooking.Size = new Size(1595, 540);
            dataGridViewBooking.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Booking_ID";
            dataGridViewTextBoxColumn4.MinimumWidth = 7;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 180;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Customer_ID";
            dataGridViewTextBoxColumn5.MinimumWidth = 7;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 180;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Room_ID";
            dataGridViewTextBoxColumn6.MinimumWidth = 7;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Check-in";
            dataGridViewTextBoxColumn7.MinimumWidth = 7;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 170;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Check-out";
            dataGridViewTextBoxColumn8.MinimumWidth = 7;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 170;
            // 
            // Column6
            // 
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 7;
            Column6.Name = "Column6";
            Column6.Width = 175;
            // 
            // Column7
            // 
            Column7.HeaderText = "Booking_Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Booking_Date";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 170;
            // 
            // button12
            // 
            button12.BackgroundImageLayout = ImageLayout.None;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.Location = new Point(64, 137);
            button12.Name = "button12";
            button12.Size = new Size(158, 72);
            button12.TabIndex = 7;
            button12.Text = "Booking \r\nand Guests";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 176);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // Guests
            // 
            Guests.Controls.Add(dataGridViewGuests);
            Guests.Location = new Point(4, 34);
            Guests.Name = "Guests";
            Guests.Padding = new Padding(3);
            Guests.Size = new Size(1598, 543);
            Guests.TabIndex = 1;
            Guests.Text = "Guests";
            Guests.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGuests
            // 
            dataGridViewGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGuests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewGuests.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGuests.Columns.AddRange(new DataGridViewColumn[] { Gn, Column2, Column3, Column4, Column5, Column1 });
            dataGridViewGuests.Location = new Point(0, 3);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.RowHeadersWidth = 56;
            dataGridViewGuests.Size = new Size(1595, 639);
            dataGridViewGuests.TabIndex = 0;
            // 
            // Gn
            // 
            Gn.FillWeight = 200F;
            Gn.HeaderText = "Full_Name";
            Gn.MinimumWidth = 7;
            Gn.Name = "Gn";
            // 
            // Column2
            // 
            Column2.HeaderText = "Sex";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 250F;
            Column3.HeaderText = "Contact_Number";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 200F;
            Column4.HeaderText = "Age_Category";
            Column4.MinimumWidth = 7;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 200F;
            Column5.HeaderText = "Room_Number";
            Column5.MinimumWidth = 7;
            Column5.Name = "Column5";
            // 
            // Column1
            // 
            Column1.HeaderText = "Status";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Rooms
            // 
            Rooms.Controls.Add(dataGridViewRooms);
            Rooms.Location = new Point(4, 34);
            Rooms.Name = "Rooms";
            Rooms.Padding = new Padding(3);
            Rooms.Size = new Size(1598, 543);
            Rooms.TabIndex = 2;
            Rooms.Text = "Rooms";
            Rooms.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, PricePerNight });
            dataGridViewRooms.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewRooms.Location = new Point(0, 3);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowHeadersWidth = 56;
            dataGridViewRooms.Size = new Size(1598, 642);
            dataGridViewRooms.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Room ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 7;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            dataGridViewTextBoxColumn2.MinimumWidth = 7;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Room Status";
            dataGridViewTextBoxColumn3.MinimumWidth = 7;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 135;
            // 
            // PricePerNight
            // 
            PricePerNight.HeaderText = "Price Per Night";
            PricePerNight.MinimumWidth = 6;
            PricePerNight.Name = "PricePerNight";
            PricePerNight.Width = 125;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(125, 157, 66);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1402, 614);
            button5.Name = "button5";
            button5.Size = new Size(218, 59);
            button5.TabIndex = 5;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = false;
            // 
            // guestaddbutton
            // 
            guestaddbutton.BackColor = Color.Coral;
            guestaddbutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestaddbutton.ForeColor = Color.White;
            guestaddbutton.Location = new Point(852, 614);
            guestaddbutton.Name = "guestaddbutton";
            guestaddbutton.Size = new Size(193, 59);
            guestaddbutton.TabIndex = 4;
            guestaddbutton.Text = "Add... +";
            guestaddbutton.UseVisualStyleBackColor = false;
            guestaddbutton.Click += guestaddbutton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 174);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 94);
            label1.Name = "label1";
            label1.Size = new Size(420, 39);
            label1.TabIndex = 0;
            label1.Text = "BOOKING AND GUESTS";
            // 
            // button11
            // 
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.Location = new Point(1468, 83);
            button11.Name = "button11";
            button11.Size = new Size(140, 77);
            button11.TabIndex = 8;
            button11.Text = "Log Out";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // BookingUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "BookingUserControl";
            Size = new Size(1638, 925);
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Booking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Guests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            Rooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage Booking;
        private DataGridView dataGridViewBooking;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button button12;
        private PictureBox pictureBox4;
        private TabPage Guests;
        private DataGridView dataGridViewGuests;
        private DataGridViewTextBoxColumn Gn;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private TabPage Rooms;
        private DataGridView dataGridViewRooms;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn PricePerNight;
        private Button button5;
        private Button guestaddbutton;
        private Panel panel1;
        private Label label1;
        private Button button11;
    }
}
