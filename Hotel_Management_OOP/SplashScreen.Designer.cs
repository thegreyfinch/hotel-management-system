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
            panelLoad = new Panel();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox4 = new PictureBox();
            BGpictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BGpictureBox1).BeginInit();
            SuspendLayout();
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
            panel2.Location = new Point(158, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 31);
            panel2.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(230, 98);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(387, 298);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // BGpictureBox1
            // 
            BGpictureBox1.Image = (Image)resources.GetObject("BGpictureBox1.Image");
            BGpictureBox1.Location = new Point(-7, -13);
            BGpictureBox1.Name = "BGpictureBox1";
            BGpictureBox1.Size = new Size(864, 579);
            BGpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            BGpictureBox1.TabIndex = 10;
            BGpictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(853, 560);
            Controls.Add(pictureBox4);
            Controls.Add(panel2);
            Controls.Add(BGpictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)BGpictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLoad;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox4;
        private PictureBox BGpictureBox1;
    }
}