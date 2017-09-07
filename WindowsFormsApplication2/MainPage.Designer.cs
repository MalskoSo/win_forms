namespace WindowsFormsApplication2
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.AddressRadio = new System.Windows.Forms.RadioButton();
            this.PriceRadio = new System.Windows.Forms.RadioButton();
            this.NameRadio = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.BallanceLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.BookedView = new System.Windows.Forms.ListView();
            this.SearchResultView = new System.Windows.Forms.ListView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.BuyButton = new RoundButton();
            this.SearchButton = new RoundButton();
            this.ReserveButton = new RoundButton();
            this.EditButton = new RoundButton();
            this.AddHotelButton = new RoundButton();
            this.SuspendLayout();
            // 
            // AddressRadio
            // 
            this.AddressRadio.AutoSize = true;
            this.AddressRadio.BackColor = System.Drawing.Color.Transparent;
            this.AddressRadio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressRadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddressRadio.Location = new System.Drawing.Point(565, 89);
            this.AddressRadio.Name = "AddressRadio";
            this.AddressRadio.Size = new System.Drawing.Size(78, 23);
            this.AddressRadio.TabIndex = 37;
            this.AddressRadio.TabStop = true;
            this.AddressRadio.Text = "Address";
            this.AddressRadio.UseVisualStyleBackColor = false;
            // 
            // PriceRadio
            // 
            this.PriceRadio.AutoSize = true;
            this.PriceRadio.BackColor = System.Drawing.Color.Transparent;
            this.PriceRadio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceRadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PriceRadio.Location = new System.Drawing.Point(501, 89);
            this.PriceRadio.Name = "PriceRadio";
            this.PriceRadio.Size = new System.Drawing.Size(58, 23);
            this.PriceRadio.TabIndex = 36;
            this.PriceRadio.TabStop = true;
            this.PriceRadio.Text = "Price";
            this.PriceRadio.UseVisualStyleBackColor = false;
            // 
            // NameRadio
            // 
            this.NameRadio.AutoSize = true;
            this.NameRadio.BackColor = System.Drawing.Color.Transparent;
            this.NameRadio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameRadio.Location = new System.Drawing.Point(433, 89);
            this.NameRadio.Name = "NameRadio";
            this.NameRadio.Size = new System.Drawing.Size(62, 23);
            this.NameRadio.TabIndex = 35;
            this.NameRadio.TabStop = true;
            this.NameRadio.Text = "Name";
            this.NameRadio.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(13, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "Booked Hotels";
            // 
            // BallanceLabel
            // 
            this.BallanceLabel.AutoSize = true;
            this.BallanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.BallanceLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BallanceLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.BallanceLabel.Location = new System.Drawing.Point(109, 89);
            this.BallanceLabel.Name = "BallanceLabel";
            this.BallanceLabel.Size = new System.Drawing.Size(66, 17);
            this.BallanceLabel.TabIndex = 33;
            this.BallanceLabel.Text = "ballance";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SurnameLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.SurnameLabel.Location = new System.Drawing.Point(108, 55);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(70, 17);
            this.SurnameLabel.TabIndex = 32;
            this.SurnameLabel.Text = "surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.NameLabel.Location = new System.Drawing.Point(109, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 17);
            this.NameLabel.TabIndex = 31;
            this.NameLabel.Text = "name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // LogOffButton
            // 
            this.LogOffButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOffButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOffButton.BackgroundImage")));
            this.LogOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOffButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOffButton.Location = new System.Drawing.Point(-7, 351);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(82, 71);
            this.LogOffButton.TabIndex = 26;
            this.LogOffButton.Text = "Log Off";
            this.LogOffButton.UseVisualStyleBackColor = false;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // BookedView
            // 
            this.BookedView.BackColor = System.Drawing.Color.LightBlue;
            this.BookedView.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookedView.Location = new System.Drawing.Point(12, 152);
            this.BookedView.Name = "BookedView";
            this.BookedView.Size = new System.Drawing.Size(249, 193);
            this.BookedView.TabIndex = 21;
            this.BookedView.UseCompatibleStateImageBehavior = false;
            this.BookedView.SelectedIndexChanged += new System.EventHandler(this.BookedView_SelectedIndexChanged);
            // 
            // SearchResultView
            // 
            this.SearchResultView.BackColor = System.Drawing.Color.LightBlue;
            this.SearchResultView.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchResultView.ForeColor = System.Drawing.Color.Black;
            this.SearchResultView.Location = new System.Drawing.Point(267, 152);
            this.SearchResultView.Name = "SearchResultView";
            this.SearchResultView.Size = new System.Drawing.Size(303, 193);
            this.SearchResultView.TabIndex = 20;
            this.SearchResultView.UseCompatibleStateImageBehavior = false;
            this.SearchResultView.SelectedIndexChanged += new System.EventHandler(this.SearchResultView_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.LightBlue;
            this.SearchBox.Location = new System.Drawing.Point(502, 46);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(141, 20);
            this.SearchBox.TabIndex = 19;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.SpringGreen;
            this.BuyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyButton.Location = new System.Drawing.Point(576, 152);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(77, 55);
            this.BuyButton.TabIndex = 42;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.SpringGreen;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(419, 27);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(77, 55);
            this.SearchButton.TabIndex = 41;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReserveButton
            // 
            this.ReserveButton.BackColor = System.Drawing.Color.SpringGreen;
            this.ReserveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReserveButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReserveButton.Location = new System.Drawing.Point(576, 202);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(77, 55);
            this.ReserveButton.TabIndex = 40;
            this.ReserveButton.Text = "Reserve";
            this.ReserveButton.UseVisualStyleBackColor = false;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SpringGreen;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(251, 27);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(77, 55);
            this.EditButton.TabIndex = 39;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddHotelButton
            // 
            this.AddHotelButton.BackColor = System.Drawing.Color.SpringGreen;
            this.AddHotelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddHotelButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddHotelButton.Location = new System.Drawing.Point(576, 254);
            this.AddHotelButton.Name = "AddHotelButton";
            this.AddHotelButton.Size = new System.Drawing.Size(77, 55);
            this.AddHotelButton.TabIndex = 38;
            this.AddHotelButton.Text = "Add";
            this.AddHotelButton.UseVisualStyleBackColor = false;
            this.AddHotelButton.Click += new System.EventHandler(this.AddHotelButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 419);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddHotelButton);
            this.Controls.Add(this.AddressRadio);
            this.Controls.Add(this.PriceRadio);
            this.Controls.Add(this.NameRadio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BallanceLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogOffButton);
            this.Controls.Add(this.BookedView);
            this.Controls.Add(this.SearchResultView);
            this.Controls.Add(this.SearchBox);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AddressRadio;
        private System.Windows.Forms.RadioButton PriceRadio;
        private System.Windows.Forms.RadioButton NameRadio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BallanceLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.ListView BookedView;
        private System.Windows.Forms.ListView SearchResultView;
        private System.Windows.Forms.TextBox SearchBox;
        private RoundButton AddHotelButton;
        private RoundButton EditButton;
        private RoundButton ReserveButton;
        private RoundButton SearchButton;
        private RoundButton BuyButton;
    }
}