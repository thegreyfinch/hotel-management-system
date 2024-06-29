namespace Hotel_Management_OOP.Controls
{
    partial class RoomsTabUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridViewRooms = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            PricePerNight = new DataGridViewTextBoxColumn();
            PriceperNighttextBox4 = new TextBox();
            RoomStattextBox5 = new TextBox();
            RoomTypetextBox7 = new TextBox();
            label12 = new Label();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            RoomIdtextBox8 = new TextBox();
            SaveRoomBtn = new Button();
            RemoveRoombtn = new Button();
            AddRoomBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1482, 20);
            button2.Name = "button2";
            button2.Size = new Size(84, 36);
            button2.TabIndex = 50;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            textBox1.Location = new Point(1163, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 49;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRooms.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, PricePerNight });
            dataGridViewRooms.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewRooms.Location = new Point(20, 79);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowHeadersWidth = 56;
            dataGridViewRooms.Size = new Size(1607, 326);
            dataGridViewRooms.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Room ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 7;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            dataGridViewTextBoxColumn2.MinimumWidth = 7;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Room Status";
            dataGridViewTextBoxColumn3.MinimumWidth = 7;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // PricePerNight
            // 
            PricePerNight.HeaderText = "Price Per Night";
            PricePerNight.MinimumWidth = 6;
            PricePerNight.Name = "PricePerNight";
            // 
            // PriceperNighttextBox4
            // 
            PriceperNighttextBox4.BorderStyle = BorderStyle.FixedSingle;
            PriceperNighttextBox4.Cursor = Cursors.IBeam;
            PriceperNighttextBox4.Location = new Point(186, 571);
            PriceperNighttextBox4.Name = "PriceperNighttextBox4";
            PriceperNighttextBox4.Size = new Size(393, 29);
            PriceperNighttextBox4.TabIndex = 60;
            // 
            // RoomStattextBox5
            // 
            RoomStattextBox5.BorderStyle = BorderStyle.FixedSingle;
            RoomStattextBox5.Cursor = Cursors.IBeam;
            RoomStattextBox5.Location = new Point(186, 523);
            RoomStattextBox5.Name = "RoomStattextBox5";
            RoomStattextBox5.Size = new Size(393, 29);
            RoomStattextBox5.TabIndex = 59;
            // 
            // RoomTypetextBox7
            // 
            RoomTypetextBox7.BorderStyle = BorderStyle.FixedSingle;
            RoomTypetextBox7.Cursor = Cursors.IBeam;
            RoomTypetextBox7.Location = new Point(186, 473);
            RoomTypetextBox7.Name = "RoomTypetextBox7";
            RoomTypetextBox7.Size = new Size(393, 29);
            RoomTypetextBox7.TabIndex = 58;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 611);
            label12.Name = "label12";
            label12.Size = new Size(0, 21);
            label12.TabIndex = 57;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(33, 573);
            label16.Name = "label16";
            label16.Size = new Size(117, 21);
            label16.TabIndex = 56;
            label16.Text = "Price per Night:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(33, 523);
            label18.Name = "label18";
            label18.Size = new Size(101, 21);
            label18.TabIndex = 55;
            label18.Text = "Room Status:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(33, 479);
            label19.Name = "label19";
            label19.Size = new Size(91, 21);
            label19.TabIndex = 54;
            label19.Text = "Room Type:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(33, 430);
            label20.Name = "label20";
            label20.Size = new Size(72, 21);
            label20.TabIndex = 53;
            label20.Text = "Room Id:";
            // 
            // RoomIdtextBox8
            // 
            RoomIdtextBox8.BorderStyle = BorderStyle.FixedSingle;
            RoomIdtextBox8.Cursor = Cursors.IBeam;
            RoomIdtextBox8.Location = new Point(186, 427);
            RoomIdtextBox8.Name = "RoomIdtextBox8";
            RoomIdtextBox8.Size = new Size(393, 29);
            RoomIdtextBox8.TabIndex = 52;
            // 
            // SaveRoomBtn
            // 
            SaveRoomBtn.BackColor = Color.FromArgb(125, 157, 66);
            SaveRoomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveRoomBtn.ForeColor = Color.White;
            SaveRoomBtn.Location = new Point(1375, 559);
            SaveRoomBtn.Name = "SaveRoomBtn";
            SaveRoomBtn.Size = new Size(193, 59);
            SaveRoomBtn.TabIndex = 62;
            SaveRoomBtn.Text = "Save";
            SaveRoomBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveRoombtn
            // 
            RemoveRoombtn.BackColor = Color.Maroon;
            RemoveRoombtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveRoombtn.ForeColor = Color.White;
            RemoveRoombtn.Location = new Point(1375, 491);
            RemoveRoombtn.Name = "RemoveRoombtn";
            RemoveRoombtn.Size = new Size(191, 59);
            RemoveRoombtn.TabIndex = 63;
            RemoveRoombtn.Text = "Remove... -";
            RemoveRoombtn.UseVisualStyleBackColor = false;
            // 
            // AddRoomBtn
            // 
            AddRoomBtn.BackColor = Color.Coral;
            AddRoomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddRoomBtn.ForeColor = Color.White;
            AddRoomBtn.Location = new Point(1375, 421);
            AddRoomBtn.Name = "AddRoomBtn";
            AddRoomBtn.Size = new Size(193, 59);
            AddRoomBtn.TabIndex = 61;
            AddRoomBtn.Text = "Add... +";
            AddRoomBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(72, 34, 22);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 34);
            label1.TabIndex = 64;
            label1.Text = "Rooms";
            // 
            // RoomsTabUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(label1);
            Controls.Add(SaveRoomBtn);
            Controls.Add(RemoveRoombtn);
            Controls.Add(AddRoomBtn);
            Controls.Add(PriceperNighttextBox4);
            Controls.Add(RoomStattextBox5);
            Controls.Add(RoomTypetextBox7);
            Controls.Add(label12);
            Controls.Add(label16);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(RoomIdtextBox8);
            Controls.Add(dataGridViewRooms);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Name = "RoomsTabUserControl";
            Size = new Size(1638, 641);
            Load += RoomsTabUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridViewRooms;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn PricePerNight;
        private TextBox PriceperNighttextBox4;
        private TextBox RoomStattextBox5;
        private TextBox RoomTypetextBox7;
        private Label label12;
        private Label label16;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox RoomIdtextBox8;
        private Button SaveRoomBtn;
        private Button RemoveRoombtn;
        private Button AddRoomBtn;
        private Label label1;
    }
}
