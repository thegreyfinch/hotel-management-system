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
            label20 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Microsoft Sans Serif", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1148, 17);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(107, 26);
            button2.TabIndex = 48;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 8.861538F);
            textBox1.Location = new Point(889, 22);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 21);
            textBox1.TabIndex = 47;
            textBox1.TextChanged += textBox1_TextChanged;
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
            dataGridViewGuests.Location = new Point(21, 55);
            dataGridViewGuests.Margin = new Padding(2);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.RowHeadersWidth = 56;
            dataGridViewGuests.Size = new Size(1234, 306);
            dataGridViewGuests.TabIndex = 49;
            dataGridViewGuests.CellContentClick += dataGridViewGuests_CellContentClick;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(72, 34, 22);
            label20.Location = new Point(21, 17);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(86, 27);
            label20.TabIndex = 65;
            label20.Text = "Guests";
            // 
            // GuestTabUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(label20);
            Controls.Add(dataGridViewGuests);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "GuestTabUserControl";
            Size = new Size(1274, 458);
            Load += GuestTabUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridViewGuests;
        private Label label20;
    }
}
