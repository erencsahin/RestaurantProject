namespace restaurantProject
{
    partial class RestaurantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantForm));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1082, 755);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(119, 303);
            button1.Name = "button1";
            button1.Size = new Size(218, 122);
            button1.TabIndex = 1;
            button1.Text = "Yemek Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(525, 324);
            button2.Name = "button2";
            button2.Size = new Size(218, 122);
            button2.TabIndex = 2;
            button2.Text = "Yemek Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(147, 562);
            button4.Name = "button4";
            button4.Size = new Size(218, 122);
            button4.TabIndex = 4;
            button4.Text = "Siparişleri Yazdır";
            button4.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            backButton.BackColor = Color.SteelBlue;
            backButton.FlatAppearance.BorderColor = Color.SteelBlue;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Location = new Point(976, 712);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // RestaurantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 753);
            Controls.Add(backButton);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RestaurantForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restaurant";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button backButton;
    }
}