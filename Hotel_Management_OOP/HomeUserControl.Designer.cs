namespace Hotel_Management_OOP
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            panel1 = new Panel();
            label1 = new Label();
            button11 = new Button();
            button10 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1629, 174);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 95);
            label1.Name = "label1";
            label1.Size = new Size(184, 39);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // button11
            // 
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.Location = new Point(1468, 112);
            button11.Name = "button11";
            button11.Size = new Size(140, 48);
            button11.TabIndex = 8;
            button11.Text = "Log Out";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1468, 24);
            button10.Name = "button10";
            button10.Size = new Size(140, 66);
            button10.TabIndex = 7;
            button10.Text = "User Profile";
            button10.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Location = new Point(2, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(1629, 818);
            panel2.TabIndex = 9;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomeUserControl";
            Size = new Size(1634, 1000);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button11;
        private Button button10;
        private Panel panel2;
    }
}
