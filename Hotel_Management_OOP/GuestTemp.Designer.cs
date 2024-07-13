namespace Hotel_Management_OOP
{
    partial class GuestTemp
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
            RoomsTabbutton = new Button();
            BookingTabbutton = new Button();
            GuestTabbutton = new Button();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // RoomsTabbutton
            // 
            RoomsTabbutton.BackColor = Color.FromArgb(72, 34, 22);
            RoomsTabbutton.ForeColor = Color.White;
            RoomsTabbutton.Location = new Point(342, 10);
            RoomsTabbutton.Margin = new Padding(2);
            RoomsTabbutton.Name = "RoomsTabbutton";
            RoomsTabbutton.Size = new Size(121, 38);
            RoomsTabbutton.TabIndex = 9;
            RoomsTabbutton.Text = "Rooms Tab";
            RoomsTabbutton.UseVisualStyleBackColor = false;
            RoomsTabbutton.Click += RoomsTabbutton_Click;
            // 
            // BookingTabbutton
            // 
            BookingTabbutton.BackColor = Color.FromArgb(72, 34, 22);
            BookingTabbutton.ForeColor = Color.White;
            BookingTabbutton.Location = new Point(26, 11);
            BookingTabbutton.Margin = new Padding(2);
            BookingTabbutton.Name = "BookingTabbutton";
            BookingTabbutton.Size = new Size(126, 38);
            BookingTabbutton.TabIndex = 7;
            BookingTabbutton.Text = "Booking Tab";
            BookingTabbutton.UseVisualStyleBackColor = false;
            BookingTabbutton.Click += BookingTabbutton_Click;
            // 
            // GuestTabbutton
            // 
            GuestTabbutton.BackColor = Color.FromArgb(72, 34, 22);
            GuestTabbutton.ForeColor = Color.White;
            GuestTabbutton.Location = new Point(188, 11);
            GuestTabbutton.Margin = new Padding(2);
            GuestTabbutton.Name = "GuestTabbutton";
            GuestTabbutton.Size = new Size(121, 38);
            GuestTabbutton.TabIndex = 8;
            GuestTabbutton.Text = "Guests Tab";
            GuestTabbutton.UseVisualStyleBackColor = false;
            GuestTabbutton.Click += GuestTabbutton_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(16, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 660);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(72, 34, 22);
            button1.ForeColor = Color.White;
            button1.Location = new Point(512, 10);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(126, 38);
            button1.TabIndex = 11;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GuestTemp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 739);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(RoomsTabbutton);
            Controls.Add(BookingTabbutton);
            Controls.Add(GuestTabbutton);
            Name = "GuestTemp";
            Text = "GuestTemp";
            ResumeLayout(false);
        }

        #endregion

        private Button RoomsTabbutton;
        private Button BookingTabbutton;
        private Button GuestTabbutton;
        private Panel panel1;
        private Button button1;
    }
}