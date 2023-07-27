namespace restaurantProject
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            pictureBox1 = new PictureBox();
            backButton = new Button();
            comboBoxMainMeal = new ComboBox();
            comboBoxSoup = new ComboBox();
            comboBoxSalad = new ComboBox();
            comboBoxDesert = new ComboBox();
            comboBoxDrink = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(950, 568);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.SteelBlue;
            backButton.FlatAppearance.BorderColor = Color.SteelBlue;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Location = new Point(854, 534);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(82, 22);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            // 
            // comboBoxMainMeal
            // 
            comboBoxMainMeal.BackColor = Color.LightCyan;
            comboBoxMainMeal.FormattingEnabled = true;
            comboBoxMainMeal.Location = new Point(59, 130);
            comboBoxMainMeal.Margin = new Padding(3, 2, 3, 2);
            comboBoxMainMeal.Name = "comboBoxMainMeal";
            comboBoxMainMeal.Size = new Size(175, 23);
            comboBoxMainMeal.TabIndex = 2;
            // 
            // comboBoxSoup
            // 
            comboBoxSoup.BackColor = Color.LightCyan;
            comboBoxSoup.FormattingEnabled = true;
            comboBoxSoup.Location = new Point(59, 407);
            comboBoxSoup.Margin = new Padding(3, 2, 3, 2);
            comboBoxSoup.Name = "comboBoxSoup";
            comboBoxSoup.Size = new Size(175, 23);
            comboBoxSoup.TabIndex = 3;
            // 
            // comboBoxSalad
            // 
            comboBoxSalad.BackColor = Color.LightCyan;
            comboBoxSalad.FormattingEnabled = true;
            comboBoxSalad.Location = new Point(388, 407);
            comboBoxSalad.Margin = new Padding(3, 2, 3, 2);
            comboBoxSalad.Name = "comboBoxSalad";
            comboBoxSalad.Size = new Size(175, 23);
            comboBoxSalad.TabIndex = 4;
            // 
            // comboBoxDesert
            // 
            comboBoxDesert.BackColor = Color.LightCyan;
            comboBoxDesert.FormattingEnabled = true;
            comboBoxDesert.Location = new Point(704, 130);
            comboBoxDesert.Margin = new Padding(3, 2, 3, 2);
            comboBoxDesert.Name = "comboBoxDesert";
            comboBoxDesert.Size = new Size(175, 23);
            comboBoxDesert.TabIndex = 5;
            // 
            // comboBoxDrink
            // 
            comboBoxDrink.BackColor = Color.LightCyan;
            comboBoxDrink.FormattingEnabled = true;
            comboBoxDrink.Location = new Point(704, 407);
            comboBoxDrink.Margin = new Padding(3, 2, 3, 2);
            comboBoxDrink.Name = "comboBoxDrink";
            comboBoxDrink.Size = new Size(175, 23);
            comboBoxDrink.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(402, 237);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(402, 237);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 565);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBoxDrink);
            Controls.Add(comboBoxDesert);
            Controls.Add(comboBoxSalad);
            Controls.Add(comboBoxSoup);
            Controls.Add(comboBoxMainMeal);
            Controls.Add(backButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menü";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backButton;
        private ComboBox comboBoxMainMeal;
        private ComboBox comboBoxSoup;
        private ComboBox comboBoxSalad;
        private ComboBox comboBoxDesert;
        private ComboBox comboBoxDrink;
        private TextBox textBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}