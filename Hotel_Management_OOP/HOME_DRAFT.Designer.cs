﻿namespace Hotel_Management_OOP
{
    partial class HOME_DRAFT
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
            button11 = new Button();
            button10 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button12 = new Button();
            label3 = new Label();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(143, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 75);
            panel1.TabIndex = 0;
            // 
            // button11
            // 
            button11.Location = new Point(917, 21);
            button11.Name = "button11";
            button11.Size = new Size(93, 33);
            button11.TabIndex = 8;
            button11.Text = "Log Out";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(769, 21);
            button10.Name = "button10";
            button10.Size = new Size(109, 33);
            button10.TabIndex = 7;
            button10.Text = "User Profile";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 21);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 0;
            label2.Text = "insert hotel image";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 204, 166);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(143, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(1032, 610);
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
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(72, 34, 22);
            button8.ForeColor = Color.White;
            button8.Location = new Point(386, 46);
            button8.Name = "button8";
            button8.Size = new Size(156, 53);
            button8.TabIndex = 3;
            button8.Text = "Rooms Tab";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(72, 34, 22);
            button7.ForeColor = Color.White;
            button7.Location = new Point(205, 46);
            button7.Name = "button7";
            button7.Size = new Size(156, 53);
            button7.TabIndex = 2;
            button7.Text = "Guests Tab";
            button7.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(72, 34, 22);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 46);
            button1.Name = "button1";
            button1.Size = new Size(162, 53);
            button1.TabIndex = 1;
            button1.Text = "Booking Tab";
            button1.UseVisualStyleBackColor = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(13, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 56;
            dataGridView1.Size = new Size(1008, 478);
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
            // panel3
            // 
            panel3.BackColor = Color.Salmon;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(143, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(1033, 78);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 17F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(368, 19);
            label1.Name = "label1";
            label1.Size = new Size(296, 41);
            label1.TabIndex = 0;
            label1.Text = "Booking and Guests";
            label1.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Salmon;
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button12);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(2, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(135, 775);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Variable Small Semibol", 9F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(10, 587);
            button5.Name = "button5";
            button5.Size = new Size(109, 58);
            button5.TabIndex = 10;
            button5.Text = "Contacts";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Variable Small Semibol", 9F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(10, 503);
            button3.Name = "button3";
            button3.Size = new Size(109, 53);
            button3.TabIndex = 9;
            button3.Text = "About Us";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Variable Small Semibol", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 396);
            button2.Name = "button2";
            button2.Size = new Size(109, 66);
            button2.TabIndex = 8;
            button2.Text = "Billing and Invoicing";
            button2.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImageLayout = ImageLayout.None;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Variable Small Semibol", 9F);
            button12.ForeColor = Color.White;
            button12.Location = new Point(10, 286);
            button12.Name = "button12";
            button12.Size = new Size(109, 66);
            button12.TabIndex = 7;
            button12.Text = "Booking \r\nand Guests";
            button12.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 54);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 1;
            label3.Text = "insert logo";
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Variable Small Semibol", 9F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(10, 211);
            button4.Name = "button4";
            button4.Size = new Size(109, 33);
            button4.TabIndex = 4;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 107);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // HOME_DRAFT
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 780);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HOME_DRAFT";
            ShowIcon = false;
            Text = "Booking Draft";
            Load += HOME_DRAFT_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label2;
        private Label label3;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button3;
        private Button button2;
        private Button button12;
        private Button button5;
    }
}