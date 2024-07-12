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
            SaveGuestBtn = new Button();
            RemoveGuestbtn = new Button();
            AddGuestbtn = new Button();
            label20 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1185, 27);
            button2.Name = "button2";
            button2.Size = new Size(138, 36);
            button2.TabIndex = 48;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            textBox1.Location = new Point(852, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 27);
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
            dataGridViewGuests.Location = new Point(27, 77);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.RowHeadersWidth = 56;
            dataGridViewGuests.Size = new Size(1586, 428);
            dataGridViewGuests.TabIndex = 49;
            dataGridViewGuests.CellContentClick += dataGridViewGuests_CellContentClick;
            // 
            // SaveGuestBtn
            // 
            SaveGuestBtn.BackColor = Color.FromArgb(125, 157, 66);
            SaveGuestBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveGuestBtn.ForeColor = Color.White;
            SaveGuestBtn.Location = new Point(1158, 539);
            SaveGuestBtn.Name = "SaveGuestBtn";
            SaveGuestBtn.Size = new Size(191, 59);
            SaveGuestBtn.TabIndex = 63;
            SaveGuestBtn.Text = "Edit";
            SaveGuestBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveGuestbtn
            // 
            RemoveGuestbtn.BackColor = Color.Maroon;
            RemoveGuestbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveGuestbtn.ForeColor = Color.White;
            RemoveGuestbtn.Location = new Point(1388, 539);
            RemoveGuestbtn.Name = "RemoveGuestbtn";
            RemoveGuestbtn.Size = new Size(191, 59);
            RemoveGuestbtn.TabIndex = 64;
            RemoveGuestbtn.Text = "Save";
            RemoveGuestbtn.UseVisualStyleBackColor = false;
            // 
            // AddGuestbtn
            // 
            AddGuestbtn.BackColor = Color.Coral;
            AddGuestbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddGuestbtn.ForeColor = Color.White;
            AddGuestbtn.Location = new Point(924, 539);
            AddGuestbtn.Name = "AddGuestbtn";
            AddGuestbtn.Size = new Size(193, 59);
            AddGuestbtn.TabIndex = 62;
            AddGuestbtn.Text = "Add... +";
            AddGuestbtn.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(72, 34, 22);
            label20.Location = new Point(27, 24);
            label20.Name = "label20";
            label20.Size = new Size(111, 34);
            label20.TabIndex = 65;
            label20.Text = "Guests";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(250, 204, 166);
            comboBox1.Font = new Font("Segoe UI Variable Text", 8.861538F);
            comboBox1.ForeColor = Color.FromArgb(72, 34, 22);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Checked-In", "Checked-Out", "Cancelled", "Extended", "Reserved" });
            comboBox1.Location = new Point(1360, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 28);
            comboBox1.TabIndex = 66;
            comboBox1.Text = "Status (All)";
            // 
            // GuestTabUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(comboBox1);
            Controls.Add(label20);
            Controls.Add(SaveGuestBtn);
            Controls.Add(RemoveGuestbtn);
            Controls.Add(AddGuestbtn);
            Controls.Add(dataGridViewGuests);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Name = "GuestTabUserControl";
            Size = new Size(1638, 641);
            Load += GuestTabUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridViewGuests;
        private Button SaveGuestBtn;
        private Button RemoveGuestbtn;
        private Button AddGuestbtn;
        private Label label20;
        private ComboBox comboBox1;
    }
}
