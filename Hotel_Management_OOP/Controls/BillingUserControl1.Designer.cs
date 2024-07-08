namespace Hotel_Management_OOP
{
    partial class BillingUserControl1
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingUserControl1));
            panel1 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label20 = new Label();
            comboBox1 = new ComboBox();
            panel7 = new Panel();
            label3 = new Label();
            RoomIDtxtbox = new TextBox();
            comboBox3 = new ComboBox();
            label5 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label19 = new Label();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            BillDateCreated = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            paymentDate = new DataGridViewTextBoxColumn();
            comboBox2 = new ComboBox();
            EditBBtn = new Button();
            SaveBBtn = new Button();
            AddBbtn = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1634, 1000);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(1634, 823);
            panel3.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Controls.Add(EditBBtn);
            panel6.Controls.Add(SaveBBtn);
            panel6.Controls.Add(AddBbtn);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(dataGridView2);
            panel6.Location = new Point(5, 92);
            panel6.Name = "panel6";
            panel6.Size = new Size(1629, 731);
            panel6.TabIndex = 11;
            panel6.Paint += panel6_Paint;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView2.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(72, 34, 22);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.6F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, BillDateCreated, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn2, Column1, paymentDate });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.6F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.Location = new Point(13, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 56;
            dataGridView2.Size = new Size(1594, 468);
            dataGridView2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 34, 22);
            button2.Font = new Font("Segoe UI Variable Text", 8.861538F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1496, 31);
            button2.Name = "button2";
            button2.Size = new Size(106, 36);
            button2.TabIndex = 9;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            textBox1.Location = new Point(1200, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label20);
            panel5.Location = new Point(2, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1653, 86);
            panel5.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 95);
            label1.Name = "label1";
            label1.Size = new Size(397, 39);
            label1.TabIndex = 0;
            label1.Text = "BILLING AND INVOICE";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1634, 174);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1634, 174);
            panel4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 94);
            label2.Name = "label2";
            label2.Size = new Size(438, 39);
            label2.TabIndex = 0;
            label2.Text = "BILLING AND INVOICING";
            label2.Click += label2_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(72, 34, 22);
            label20.Location = new Point(34, 26);
            label20.Name = "label20";
            label20.Size = new Size(102, 34);
            label20.TabIndex = 56;
            label20.Text = "Billing";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(250, 204, 166);
            comboBox1.Font = new Font("Segoe UI Variable Text", 8.861538F);
            comboBox1.ForeColor = Color.FromArgb(72, 34, 22);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Paid", "Pending" });
            comboBox1.Location = new Point(922, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 28);
            comboBox1.TabIndex = 66;
            comboBox1.Text = " Payment Status";
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBox2);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(RoomIDtxtbox);
            panel7.Controls.Add(comboBox3);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(dateTimePicker3);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(textBox2);
            panel7.Controls.Add(label19);
            panel7.Location = new Point(13, 500);
            panel7.Name = "panel7";
            panel7.Size = new Size(802, 218);
            panel7.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label3.ForeColor = Color.FromArgb(72, 34, 22);
            label3.Location = new Point(7, 173);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 56;
            label3.Text = "Amount:";
            // 
            // RoomIDtxtbox
            // 
            RoomIDtxtbox.Location = new Point(149, 169);
            RoomIDtxtbox.Name = "RoomIDtxtbox";
            RoomIDtxtbox.Size = new Size(281, 29);
            RoomIDtxtbox.TabIndex = 55;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Paid", "Pending" });
            comboBox3.Location = new Point(149, 49);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(281, 29);
            comboBox3.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label5.ForeColor = Color.FromArgb(72, 34, 22);
            label5.Location = new Point(7, 49);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 27;
            label5.Text = "Payment Status:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarForeColor = Color.FromArgb(72, 34, 22);
            dateTimePicker3.Font = new Font("Segoe UI Variable Text Light", 8.861538F);
            dateTimePicker3.Location = new Point(149, 88);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(281, 27);
            dateTimePicker3.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label4.ForeColor = Color.FromArgb(72, 34, 22);
            label4.Location = new Point(7, 133);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 23;
            label4.Text = "Payment Method:";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label6.ForeColor = Color.FromArgb(72, 34, 22);
            label6.Location = new Point(7, 91);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 22;
            label6.Text = "Payment Date:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 29);
            textBox2.TabIndex = 16;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Variable Text Semibold", 9F);
            label19.ForeColor = Color.FromArgb(72, 34, 22);
            label19.Location = new Point(7, 8);
            label19.Name = "label19";
            label19.Size = new Size(89, 20);
            label19.TabIndex = 15;
            label19.Text = "Booking ID:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Bill ID";
            dataGridViewTextBoxColumn4.MaxInputLength = 12;
            dataGridViewTextBoxColumn4.MinimumWidth = 7;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // BillDateCreated
            // 
            BillDateCreated.HeaderText = "Date Created";
            BillDateCreated.MinimumWidth = 6;
            BillDateCreated.Name = "BillDateCreated";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 200F;
            dataGridViewTextBoxColumn1.HeaderText = "Booking ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 7;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.FillWeight = 200F;
            dataGridViewTextBoxColumn6.HeaderText = "Payment Status";
            dataGridViewTextBoxColumn6.MinimumWidth = 7;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Amount";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column1
            // 
            Column1.HeaderText = "Payment Method";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // paymentDate
            // 
            paymentDate.HeaderText = "Payment Date";
            paymentDate.MinimumWidth = 6;
            paymentDate.Name = "paymentDate";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Cash", "Card", "Other" });
            comboBox2.Location = new Point(149, 129);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(281, 29);
            comboBox2.TabIndex = 57;
            // 
            // EditBBtn
            // 
            EditBBtn.BackColor = Color.FromArgb(125, 157, 66);
            EditBBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBBtn.ForeColor = Color.White;
            EditBBtn.Location = new Point(1173, 542);
            EditBBtn.Name = "EditBBtn";
            EditBBtn.Size = new Size(193, 59);
            EditBBtn.TabIndex = 70;
            EditBBtn.Text = "Edit";
            EditBBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBBtn
            // 
            SaveBBtn.BackColor = Color.Maroon;
            SaveBBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBBtn.ForeColor = Color.White;
            SaveBBtn.Location = new Point(1398, 542);
            SaveBBtn.Name = "SaveBBtn";
            SaveBBtn.Size = new Size(191, 59);
            SaveBBtn.TabIndex = 69;
            SaveBBtn.Text = "Save";
            SaveBBtn.UseVisualStyleBackColor = false;
            // 
            // AddBbtn
            // 
            AddBbtn.BackColor = Color.Coral;
            AddBbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBbtn.ForeColor = Color.White;
            AddBbtn.Location = new Point(944, 542);
            AddBbtn.Name = "AddBbtn";
            AddBbtn.Size = new Size(193, 59);
            AddBbtn.TabIndex = 68;
            AddBbtn.Text = "Add... +";
            AddBbtn.UseVisualStyleBackColor = false;
            // 
            // BillingUserControl1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(panel1);
            Name = "BillingUserControl1";
            Size = new Size(1634, 1000);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView2;
        private Panel panel3;
        private TextBox textBox1;
        private Button button2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Label label20;
        private ComboBox comboBox1;
        private Panel panel7;
        private Label label3;
        private TextBox RoomIDtxtbox;
        private ComboBox comboBox3;
        private Label label5;
        private DateTimePicker dateTimePicker3;
        private Label label4;
        private Label label6;
        private TextBox textBox2;
        private Label label19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn BillDateCreated;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn paymentDate;
        private ComboBox comboBox2;
        private Button EditBBtn;
        private Button SaveBBtn;
        private Button AddBbtn;
    }
}
