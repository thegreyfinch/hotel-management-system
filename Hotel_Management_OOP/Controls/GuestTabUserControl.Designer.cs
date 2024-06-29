namespace Hotel_Management_OOP.Controls
{
    partial class GuestTabUserControl
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
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridViewGuests = new DataGridView();
            Gn = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            label11 = new Label();
            RoomNumtextBox = new TextBox();
            AgeCattextBox = new TextBox();
            textBox6 = new TextBox();
            SextextBox = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            Sex = new Label();
            label17 = new Label();
            FullNametextBox = new TextBox();
            SaveGuestBtn = new Button();
            RemoveGuestbtn = new Button();
            AddGuestbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(358, 22);
            button2.Name = "button2";
            button2.Size = new Size(84, 36);
            button2.TabIndex = 48;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            textBox1.Location = new Point(39, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 47;
            // 
            // dataGridViewGuests
            // 
            dataGridViewGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGuests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewGuests.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGuests.Columns.AddRange(new DataGridViewColumn[] { Gn, Column2, Column3, Column4, Column5, Column1 });
            dataGridViewGuests.Location = new Point(6, 77);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.RowHeadersWidth = 56;
            dataGridViewGuests.Size = new Size(1624, 329);
            dataGridViewGuests.TabIndex = 49;
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(192, 672);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(393, 29);
            textBox2.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 672);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 60;
            label11.Text = "Status:";
            // 
            // RoomNumtextBox
            // 
            RoomNumtextBox.BorderStyle = BorderStyle.FixedSingle;
            RoomNumtextBox.Cursor = Cursors.IBeam;
            RoomNumtextBox.Location = new Point(192, 624);
            RoomNumtextBox.Name = "RoomNumtextBox";
            RoomNumtextBox.Size = new Size(393, 29);
            RoomNumtextBox.TabIndex = 59;
            // 
            // AgeCattextBox
            // 
            AgeCattextBox.BorderStyle = BorderStyle.FixedSingle;
            AgeCattextBox.Cursor = Cursors.IBeam;
            AgeCattextBox.Location = new Point(192, 579);
            AgeCattextBox.Name = "AgeCattextBox";
            AgeCattextBox.Size = new Size(393, 29);
            AgeCattextBox.TabIndex = 58;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Location = new Point(192, 531);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(393, 29);
            textBox6.TabIndex = 57;
            // 
            // SextextBox
            // 
            SextextBox.BorderStyle = BorderStyle.FixedSingle;
            SextextBox.Cursor = Cursors.IBeam;
            SextextBox.Location = new Point(192, 481);
            SextextBox.Name = "SextextBox";
            SextextBox.Size = new Size(393, 29);
            SextextBox.TabIndex = 56;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(39, 626);
            label13.Name = "label13";
            label13.Size = new Size(117, 21);
            label13.TabIndex = 55;
            label13.Text = "Room Number:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(39, 581);
            label14.Name = "label14";
            label14.Size = new Size(107, 21);
            label14.TabIndex = 54;
            label14.Text = "Age Category:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(39, 531);
            label15.Name = "label15";
            label15.Size = new Size(128, 21);
            label15.TabIndex = 53;
            label15.Text = "Contact Number:";
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.Location = new Point(39, 487);
            Sex.Name = "Sex";
            Sex.Size = new Size(37, 21);
            Sex.TabIndex = 52;
            Sex.Text = "Sex:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(39, 438);
            label17.Name = "label17";
            label17.Size = new Size(84, 21);
            label17.TabIndex = 51;
            label17.Text = "Full Name:";
            // 
            // FullNametextBox
            // 
            FullNametextBox.BorderStyle = BorderStyle.FixedSingle;
            FullNametextBox.Cursor = Cursors.IBeam;
            FullNametextBox.Location = new Point(192, 435);
            FullNametextBox.Name = "FullNametextBox";
            FullNametextBox.Size = new Size(393, 29);
            FullNametextBox.TabIndex = 50;
            // 
            // SaveGuestBtn
            // 
            SaveGuestBtn.BackColor = Color.FromArgb(125, 157, 66);
            SaveGuestBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveGuestBtn.ForeColor = Color.White;
            SaveGuestBtn.Location = new Point(1362, 630);
            SaveGuestBtn.Name = "SaveGuestBtn";
            SaveGuestBtn.Size = new Size(191, 59);
            SaveGuestBtn.TabIndex = 63;
            SaveGuestBtn.Text = "Save";
            SaveGuestBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveGuestbtn
            // 
            RemoveGuestbtn.BackColor = Color.Maroon;
            RemoveGuestbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveGuestbtn.ForeColor = Color.White;
            RemoveGuestbtn.Location = new Point(1362, 543);
            RemoveGuestbtn.Name = "RemoveGuestbtn";
            RemoveGuestbtn.Size = new Size(191, 59);
            RemoveGuestbtn.TabIndex = 64;
            RemoveGuestbtn.Text = "Remove... -";
            RemoveGuestbtn.UseVisualStyleBackColor = false;
            // 
            // AddGuestbtn
            // 
            AddGuestbtn.BackColor = Color.Coral;
            AddGuestbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddGuestbtn.ForeColor = Color.White;
            AddGuestbtn.Location = new Point(1360, 455);
            AddGuestbtn.Name = "AddGuestbtn";
            AddGuestbtn.Size = new Size(193, 59);
            AddGuestbtn.TabIndex = 62;
            AddGuestbtn.Text = "Add... +";
            AddGuestbtn.UseVisualStyleBackColor = false;
            // 
            // GuestTabUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveGuestBtn);
            Controls.Add(RemoveGuestbtn);
            Controls.Add(AddGuestbtn);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(RoomNumtextBox);
            Controls.Add(AgeCattextBox);
            Controls.Add(textBox6);
            Controls.Add(SextextBox);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(Sex);
            Controls.Add(label17);
            Controls.Add(FullNametextBox);
            Controls.Add(dataGridViewGuests);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Name = "GuestTabUserControl";
            Size = new Size(1638, 745);
            Load += GuestTabUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridViewGuests;
        private DataGridViewTextBoxColumn Gn;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBox2;
        private Label label11;
        private TextBox RoomNumtextBox;
        private TextBox AgeCattextBox;
        private TextBox textBox6;
        private TextBox SextextBox;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label Sex;
        private Label label17;
        private TextBox FullNametextBox;
        private Button SaveGuestBtn;
        private Button RemoveGuestbtn;
        private Button AddGuestbtn;
    }
}
