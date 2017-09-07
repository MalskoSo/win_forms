namespace WindowsFormsApplication2
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.PetsBox = new System.Windows.Forms.ComboBox();
            this.NamePetsBox = new System.Windows.Forms.TextBox();
            this.BreedPetsBox = new System.Windows.Forms.TextBox();
            this.NamePetsLabel = new System.Windows.Forms.Label();
            this.BreedPetsLabel = new System.Windows.Forms.Label();
            this.MassPetsLabel = new System.Windows.Forms.Label();
            this.SizePetsLabel = new System.Windows.Forms.Label();
            this.SizePetsBox = new System.Windows.Forms.ComboBox();
            this.MassPetsBox = new System.Windows.Forms.ComboBox();
            this.AutoBox = new System.Windows.Forms.ComboBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.SizeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(164, 69);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(164, 43);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 6;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(117, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(164, 121);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '$';
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(164, 95);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(117, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Login";
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(164, 173);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(100, 20);
            this.MoneyBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(115, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Money";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(120, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(120, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pets";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(164, 199);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(100, 20);
            this.AgeBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(120, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(114, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Auto";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.BackgroundImage")));
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeButton.Location = new System.Drawing.Point(12, 7);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(46, 42);
            this.HomeButton.TabIndex = 23;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.White;
            this.RegisterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.BackgroundImage")));
            this.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(459, 259);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(67, 61);
            this.RegisterButton.TabIndex = 24;
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // SexBox
            // 
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexBox.Location = new System.Drawing.Point(164, 146);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(100, 21);
            this.SexBox.TabIndex = 25;
            this.SexBox.SelectedIndexChanged += new System.EventHandler(this.SexBox_SelectedIndexChanged);
            // 
            // PetsBox
            // 
            this.PetsBox.FormattingEnabled = true;
            this.PetsBox.Items.AddRange(new object[] {
            "Yes",
            "No\t"});
            this.PetsBox.Location = new System.Drawing.Point(164, 225);
            this.PetsBox.Name = "PetsBox";
            this.PetsBox.Size = new System.Drawing.Size(100, 21);
            this.PetsBox.TabIndex = 26;
            this.PetsBox.SelectedIndexChanged += new System.EventHandler(this.PetsBox_SelectedIndexChanged);
            // 
            // NamePetsBox
            // 
            this.NamePetsBox.Location = new System.Drawing.Point(380, 146);
            this.NamePetsBox.Name = "NamePetsBox";
            this.NamePetsBox.Size = new System.Drawing.Size(100, 20);
            this.NamePetsBox.TabIndex = 27;
            this.NamePetsBox.Visible = false;
            this.NamePetsBox.TextChanged += new System.EventHandler(this.NamePetsBox_TextChanged);
            // 
            // BreedPetsBox
            // 
            this.BreedPetsBox.Location = new System.Drawing.Point(380, 171);
            this.BreedPetsBox.Name = "BreedPetsBox";
            this.BreedPetsBox.Size = new System.Drawing.Size(100, 20);
            this.BreedPetsBox.TabIndex = 28;
            this.BreedPetsBox.Visible = false;
            // 
            // NamePetsLabel
            // 
            this.NamePetsLabel.AutoSize = true;
            this.NamePetsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NamePetsLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePetsLabel.ForeColor = System.Drawing.Color.White;
            this.NamePetsLabel.Location = new System.Drawing.Point(296, 148);
            this.NamePetsLabel.Name = "NamePetsLabel";
            this.NamePetsLabel.Size = new System.Drawing.Size(78, 19);
            this.NamePetsLabel.TabIndex = 31;
            this.NamePetsLabel.Text = "Pet\'s name";
            this.NamePetsLabel.Visible = false;
            // 
            // BreedPetsLabel
            // 
            this.BreedPetsLabel.AutoSize = true;
            this.BreedPetsLabel.BackColor = System.Drawing.Color.Transparent;
            this.BreedPetsLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BreedPetsLabel.ForeColor = System.Drawing.Color.White;
            this.BreedPetsLabel.Location = new System.Drawing.Point(291, 171);
            this.BreedPetsLabel.Name = "BreedPetsLabel";
            this.BreedPetsLabel.Size = new System.Drawing.Size(83, 19);
            this.BreedPetsLabel.TabIndex = 32;
            this.BreedPetsLabel.Text = "Pet\'s breed";
            this.BreedPetsLabel.Visible = false;
            // 
            // MassPetsLabel
            // 
            this.MassPetsLabel.AutoSize = true;
            this.MassPetsLabel.BackColor = System.Drawing.Color.Transparent;
            this.MassPetsLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MassPetsLabel.ForeColor = System.Drawing.Color.White;
            this.MassPetsLabel.Location = new System.Drawing.Point(298, 221);
            this.MassPetsLabel.Name = "MassPetsLabel";
            this.MassPetsLabel.Size = new System.Drawing.Size(76, 19);
            this.MassPetsLabel.TabIndex = 34;
            this.MassPetsLabel.Text = "Pet\'s mass";
            this.MassPetsLabel.Visible = false;
            // 
            // SizePetsLabel
            // 
            this.SizePetsLabel.AutoSize = true;
            this.SizePetsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizePetsLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizePetsLabel.ForeColor = System.Drawing.Color.White;
            this.SizePetsLabel.Location = new System.Drawing.Point(303, 195);
            this.SizePetsLabel.Name = "SizePetsLabel";
            this.SizePetsLabel.Size = new System.Drawing.Size(71, 19);
            this.SizePetsLabel.TabIndex = 33;
            this.SizePetsLabel.Text = "Pet\'s size";
            this.SizePetsLabel.Visible = false;
            // 
            // SizePetsBox
            // 
            this.SizePetsBox.FormattingEnabled = true;
            this.SizePetsBox.Items.AddRange(new object[] {
            "1-10cm",
            "11-70cm",
            "71-200cm",
            "2m+ "});
            this.SizePetsBox.Location = new System.Drawing.Point(380, 196);
            this.SizePetsBox.Name = "SizePetsBox";
            this.SizePetsBox.Size = new System.Drawing.Size(101, 21);
            this.SizePetsBox.TabIndex = 35;
            this.SizePetsBox.Visible = false;
            // 
            // MassPetsBox
            // 
            this.MassPetsBox.FormattingEnabled = true;
            this.MassPetsBox.Items.AddRange(new object[] {
            "less than 1 kg",
            "1-5 kg",
            "6-20 kg ",
            "21-50 kg",
            "51+ kg",
            ""});
            this.MassPetsBox.Location = new System.Drawing.Point(380, 222);
            this.MassPetsBox.Name = "MassPetsBox";
            this.MassPetsBox.Size = new System.Drawing.Size(100, 21);
            this.MassPetsBox.TabIndex = 36;
            this.MassPetsBox.Visible = false;
            // 
            // AutoBox
            // 
            this.AutoBox.FormattingEnabled = true;
            this.AutoBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.AutoBox.Location = new System.Drawing.Point(164, 253);
            this.AutoBox.Name = "AutoBox";
            this.AutoBox.Size = new System.Drawing.Size(100, 21);
            this.AutoBox.TabIndex = 37;
            this.AutoBox.SelectedIndexChanged += new System.EventHandler(this.AutoBox_SelectedIndexChanged);
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrandLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandLabel.ForeColor = System.Drawing.Color.Transparent;
            this.BrandLabel.Location = new System.Drawing.Point(329, 85);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(45, 19);
            this.BrandLabel.TabIndex = 38;
            this.BrandLabel.Text = "Brand";
            this.BrandLabel.Visible = false;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SizeLabel.Location = new System.Drawing.Point(338, 109);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(36, 19);
            this.SizeLabel.TabIndex = 39;
            this.SizeLabel.Text = "Size";
            this.SizeLabel.Visible = false;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(380, 83);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(100, 20);
            this.BrandBox.TabIndex = 40;
            this.BrandBox.Visible = false;
            // 
            // SizeBox
            // 
            this.SizeBox.FormattingEnabled = true;
            this.SizeBox.Items.AddRange(new object[] {
            "Smart",
            "Jeep",
            "Cabriolet",
            "Sedan",
            "Pickup",
            "Truck",
            "Limousine",
            "Submarine",
            "Motorcycle",
            "Whirlybird"});
            this.SizeBox.Location = new System.Drawing.Point(380, 109);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(100, 21);
            this.SizeBox.TabIndex = 41;
            this.SizeBox.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 332);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.AutoBox);
            this.Controls.Add(this.MassPetsBox);
            this.Controls.Add(this.SizePetsBox);
            this.Controls.Add(this.MassPetsLabel);
            this.Controls.Add(this.SizePetsLabel);
            this.Controls.Add(this.BreedPetsLabel);
            this.Controls.Add(this.NamePetsLabel);
            this.Controls.Add(this.BreedPetsBox);
            this.Controls.Add(this.NamePetsBox);
            this.Controls.Add(this.PetsBox);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.ComboBox PetsBox;
        private System.Windows.Forms.TextBox NamePetsBox;
        private System.Windows.Forms.TextBox BreedPetsBox;
        private System.Windows.Forms.Label NamePetsLabel;
        private System.Windows.Forms.Label BreedPetsLabel;
        private System.Windows.Forms.Label MassPetsLabel;
        private System.Windows.Forms.Label SizePetsLabel;
        private System.Windows.Forms.ComboBox SizePetsBox;
        private System.Windows.Forms.ComboBox MassPetsBox;
        private System.Windows.Forms.ComboBox AutoBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.ComboBox SizeBox;
    }
}