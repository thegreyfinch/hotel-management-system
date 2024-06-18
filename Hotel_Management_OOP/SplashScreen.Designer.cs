namespace Hotel_Management_OOP
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            label1 = new Label();
            panelLoad = new Panel();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(324, 405);
            label1.Name = "label1";
            label1.Size = new Size(199, 46);
            label1.TabIndex = 6;
            label1.Text = "LOADING...";
            // 
            // panelLoad
            // 
            panelLoad.BackColor = Color.Salmon;
            panelLoad.Location = new Point(0, 0);
            panelLoad.Name = "panelLoad";
            panelLoad.Size = new Size(10, 29);
            panelLoad.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panelLoad);
            panel2.Location = new Point(158, 468);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 31);
            panel2.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(522, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 572);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panelLoad;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}