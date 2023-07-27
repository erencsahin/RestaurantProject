namespace restaurantProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            restButton = new Button();
            menuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1083, 755);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // restButton
            // 
            restButton.BackColor = SystemColors.ActiveCaptionText;
            restButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            restButton.ForeColor = SystemColors.ControlLightLight;
            restButton.Location = new Point(168, 612);
            restButton.Name = "restButton";
            restButton.Size = new Size(244, 103);
            restButton.TabIndex = 1;
            restButton.Text = "Restoran İşlemleri";
            restButton.UseVisualStyleBackColor = false;
            restButton.Click += restButton_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = SystemColors.ActiveCaptionText;
            menuButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton.ForeColor = Color.White;
            menuButton.Location = new Point(675, 612);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(244, 103);
            menuButton.TabIndex = 2;
            menuButton.Text = "Menü";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 753);
            Controls.Add(menuButton);
            Controls.Add(restButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button restButton;
        private Button menuButton;
    }
}