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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridViewRooms = new DataGridView();
            EditRoomBtn = new Button();
            AddRoomBtn = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SaveRoombtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1503, 26);
            button2.Name = "button2";
            button2.Size = new Size(105, 36);
            button2.TabIndex = 50;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            textBox1.Location = new Point(1192, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 27);
            textBox1.TabIndex = 49;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRooms.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewRooms.Location = new Point(20, 79);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowHeadersWidth = 56;
            dataGridViewRooms.Size = new Size(1588, 409);
            dataGridViewRooms.TabIndex = 51;
            dataGridViewRooms.CellContentClick += dataGridViewRooms_CellContentClick;
            // 
            // EditRoomBtn
            // 
            EditRoomBtn.BackColor = Color.FromArgb(125, 157, 66);
            EditRoomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditRoomBtn.ForeColor = Color.White;
            EditRoomBtn.Location = new Point(1181, 531);
            EditRoomBtn.Name = "EditRoomBtn";
            EditRoomBtn.Size = new Size(193, 59);
            EditRoomBtn.TabIndex = 62;
            EditRoomBtn.Text = "Edit";
            EditRoomBtn.UseVisualStyleBackColor = false;
            // 
            // AddRoomBtn
            // 
            AddRoomBtn.BackColor = Color.Coral;
            AddRoomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddRoomBtn.ForeColor = Color.White;
            AddRoomBtn.Location = new Point(955, 531);
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
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(250, 204, 166);
            comboBox1.Font = new Font("Segoe UI Variable Text", 8.861538F);
            comboBox1.ForeColor = Color.FromArgb(72, 34, 22);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBox1.Location = new Point(919, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 28);
            comboBox1.TabIndex = 65;
            comboBox1.Text = "Status (All)";
            // 
            // SaveRoombtn
            // 
            SaveRoombtn.BackColor = Color.Maroon;
            SaveRoombtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveRoombtn.ForeColor = Color.White;
            SaveRoombtn.Location = new Point(1402, 531);
            SaveRoombtn.Name = "SaveRoombtn";
            SaveRoombtn.Size = new Size(191, 59);
            SaveRoombtn.TabIndex = 63;
            SaveRoombtn.Text = "Save";
            SaveRoombtn.UseVisualStyleBackColor = false;
            // 
            // RoomsTabUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(EditRoomBtn);
            Controls.Add(SaveRoombtn);
            Controls.Add(AddRoomBtn);
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
        private Button EditRoomBtn;
        private Button AddRoomBtn;
        private Label label1;
        private ComboBox comboBox1;
        private Button SaveRoombtn;
    }
}
