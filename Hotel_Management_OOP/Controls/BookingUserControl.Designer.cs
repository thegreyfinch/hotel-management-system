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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingUserControl));
            panel2 = new Panel();
            tabControl1 = new TabControl();
            Guests = new TabPage();
            Rooms = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            Booking = new TabPage();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(1638, 745);
            panel2.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Booking);
            tabControl1.Controls.Add(Guests);
            tabControl1.Controls.Add(Rooms);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(65, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1638, 745);
            tabControl1.TabIndex = 6;
            // 
            // Guests
            // 
            Guests.Location = new Point(4, 34);
            Guests.Name = "Guests";
            Guests.Padding = new Padding(3);
            Guests.Size = new Size(1630, 707);
            Guests.TabIndex = 1;
            Guests.Text = "Guests";
            Guests.UseVisualStyleBackColor = true;
            // 
            // Rooms
            // 
            Rooms.Location = new Point(4, 34);
            Rooms.Name = "Rooms";
            Rooms.Padding = new Padding(3);
            Rooms.Size = new Size(1630, 707);
            Rooms.TabIndex = 2;
            Rooms.Text = "Rooms";
            Rooms.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
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
            // Booking
            // 
            Booking.BackColor = Color.Snow;
            Booking.Location = new Point(4, 34);
            Booking.Name = "Booking";
            Booking.Padding = new Padding(3);
            Booking.Size = new Size(1630, 707);
            Booking.TabIndex = 0;
            Booking.Text = "Booking";
            Booking.Click += Booking_Click;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TabControl tabControl1;
        private TabPage Guests;
        private TabPage Rooms;
        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox3;
        private TabPage Booking;
    }
}
