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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridViewRooms = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Microsoft Sans Serif", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1503, 27);
            button2.Name = "button2";
            button2.Size = new Size(105, 36);
            button2.TabIndex = 50;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 8.861538F);
            textBox1.Location = new Point(1192, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 24);
            textBox1.TabIndex = 49;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRooms.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewRooms.Location = new Point(21, 78);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowHeadersWidth = 56;
            dataGridViewRooms.Size = new Size(1588, 409);
            dataGridViewRooms.TabIndex = 51;
            dataGridViewRooms.CellContentClick += dataGridViewRooms_CellContentClick;
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
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1192, 556);
            button1.Name = "button1";
            button1.Size = new Size(407, 50);
            button1.TabIndex = 72;
            button1.Text = "Import Room Information";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RoomsTabUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(button1);
            Controls.Add(label1);
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
        private Label label1;
        private Button button1;
    }
}
