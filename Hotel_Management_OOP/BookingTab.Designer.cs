namespace Hotel_Management_OOP
{
    partial class BookingTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingTab));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button11 = new Button();
            button10 = new Button();
            panel2 = new Panel();
            button9 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button12 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button11
            // 
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.Location = new Point(1468, 112);
            button11.Name = "button11";
            button11.Size = new Size(140, 44);
            button11.TabIndex = 8;
            button11.Text = "Log Out";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1468, 22);
            button10.Name = "button10";
            button10.Size = new Size(140, 59);
            button10.TabIndex = 7;
            button10.Text = "User Profile";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 204, 166);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(269, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(1629, 862);
            panel2.TabIndex = 1;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(125, 157, 66);
            button9.ForeColor = Color.White;
            button9.Location = new Point(824, 54);
            button9.Name = "button9";
            button9.Size = new Size(108, 45);
            button9.TabIndex = 4;
            button9.Text = "Add... +";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.861538F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(13, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 56;
            dataGridView1.Size = new Size(1608, 514);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Booking_ID";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            Column1.Width = 175;
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer_ID";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.Width = 175;
            // 
            // Column3
            // 
            Column3.HeaderText = "Room_ID";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            Column3.Width = 135;
            // 
            // Column4
            // 
            Column4.HeaderText = "Check-in";
            Column4.MinimumWidth = 7;
            Column4.Name = "Column4";
            Column4.Width = 145;
            // 
            // Column5
            // 
            Column5.HeaderText = "Check-out";
            Column5.MinimumWidth = 7;
            Column5.Name = "Column5";
            Column5.Width = 145;
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
            Column8.Width = 125;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Salmon;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button12);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(2, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(261, 1027);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Variable Small Semibol", 14F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(42, 754);
            button3.Name = "button3";
            button3.Size = new Size(175, 100);
            button3.TabIndex = 12;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(108, 256);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Variable Small Semibol", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(42, 599);
            button2.Name = "button2";
            button2.Size = new Size(175, 100);
            button2.TabIndex = 8;
            button2.Text = "Billing and Invoicing";
            button2.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImageLayout = ImageLayout.None;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Variable Small Semibol", 14F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.Location = new Point(59, 434);
            button12.Name = "button12";
            button12.Size = new Size(158, 78);
            button12.TabIndex = 7;
            button12.Text = "Booking \r\nand Guests";
            button12.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Variable Small Semibol", 14F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(71, 306);
            button4.Name = "button4";
            button4.Size = new Size(109, 51);
            button4.TabIndex = 4;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Location = new Point(269, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1629, 159);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Display Semib", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 87);
            label1.Name = "label1";
            label1.Size = new Size(147, 46);
            label1.TabIndex = 0;
            label1.Text = "Booking";
            label1.Click += label1_Click;
            // 
            // BookingTab
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BookingTab";
            ShowIcon = false;
            Text = "Booking Draft";
            Load += HOME_DRAFT_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label2;
        private Label label3;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button2;
        private Button button12;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}