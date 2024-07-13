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
            panelMain2 = new Panel();
            RoomsTabbutton = new Button();
            GuestTabbutton = new Button();
            BookingTabbutton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain2
            // 
            panelMain2.AutoScroll = true;
            panelMain2.BackColor = Color.Snow;
            panelMain2.Dock = DockStyle.Bottom;
            panelMain2.Location = new Point(0, 186);
            panelMain2.Margin = new Padding(2, 2, 2, 2);
            panelMain2.Name = "panelMain2";
            panelMain2.Size = new Size(1274, 475);
            panelMain2.TabIndex = 6;
            panelMain2.Paint += panelMain2_Paint;
            // 
            // RoomsTabbutton
            // 
            RoomsTabbutton.BackColor = Color.FromArgb(72, 34, 22);
            RoomsTabbutton.ForeColor = Color.White;
            RoomsTabbutton.Location = new Point(339, 17);
            RoomsTabbutton.Margin = new Padding(2, 2, 2, 2);
            RoomsTabbutton.Name = "RoomsTabbutton";
            RoomsTabbutton.Size = new Size(121, 38);
            RoomsTabbutton.TabIndex = 6;
            RoomsTabbutton.Text = "Rooms Tab";
            RoomsTabbutton.UseVisualStyleBackColor = false;
            RoomsTabbutton.Click += RoomsTabbutton_Click;
            // 
            // GuestTabbutton
            // 
            GuestTabbutton.BackColor = Color.FromArgb(72, 34, 22);
            GuestTabbutton.ForeColor = Color.White;
            GuestTabbutton.Location = new Point(185, 18);
            GuestTabbutton.Margin = new Padding(2, 2, 2, 2);
            GuestTabbutton.Name = "GuestTabbutton";
            GuestTabbutton.Size = new Size(121, 38);
            GuestTabbutton.TabIndex = 5;
            GuestTabbutton.Text = "Guests Tab";
            GuestTabbutton.UseVisualStyleBackColor = false;
            GuestTabbutton.Click += GuestTabbutton_Click;
            // 
            // BookingTabbutton
            // 
            BookingTabbutton.BackColor = Color.FromArgb(72, 34, 22);
            BookingTabbutton.ForeColor = Color.White;
            BookingTabbutton.Location = new Point(23, 18);
            BookingTabbutton.Margin = new Padding(2, 2, 2, 2);
            BookingTabbutton.Name = "BookingTabbutton";
            BookingTabbutton.Size = new Size(126, 38);
            BookingTabbutton.TabIndex = 4;
            BookingTabbutton.Text = "Booking Tab";
            BookingTabbutton.UseVisualStyleBackColor = false;
            BookingTabbutton.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 124);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 32);
            label1.TabIndex = 0;
            label1.Text = "BOOKING AND GUESTS";
            // 
            // panel2
            // 
            panel2.Controls.Add(RoomsTabbutton);
            panel2.Controls.Add(BookingTabbutton);
            panel2.Controls.Add(GuestTabbutton);
            panel2.Location = new Point(2, 126);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1272, 60);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // BookingUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMain2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BookingUserControl";
            Size = new Size(1274, 661);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panelMain2;
        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox3;
        private Button RoomsTabbutton;
        private Button GuestTabbutton;
        private Button BookingTabbutton;
        private Panel panel2;
    }
}
