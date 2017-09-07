namespace WindowsFormsApplication2
{
    partial class AddHotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHotelForm));
            this.NameAddLabel = new System.Windows.Forms.Label();
            this.AddressAddLabel = new System.Windows.Forms.Label();
            this.PriceAddLabel = new System.Windows.Forms.Label();
            this.TotalPriceAddLabel = new System.Windows.Forms.Label();
            this.FreeAddLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitAddButton = new System.Windows.Forms.Button();
            this.NameAddBox = new System.Windows.Forms.TextBox();
            this.AddressAddBox = new System.Windows.Forms.TextBox();
            this.PriceAddBox = new System.Windows.Forms.TextBox();
            this.TotalPriceAddBox = new System.Windows.Forms.TextBox();
            this.FreeAddBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameAddLabel
            // 
            this.NameAddLabel.AutoSize = true;
            this.NameAddLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameAddLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAddLabel.Location = new System.Drawing.Point(46, 120);
            this.NameAddLabel.Name = "NameAddLabel";
            this.NameAddLabel.Size = new System.Drawing.Size(53, 23);
            this.NameAddLabel.TabIndex = 0;
            this.NameAddLabel.Text = "Name";
            // 
            // AddressAddLabel
            // 
            this.AddressAddLabel.AutoSize = true;
            this.AddressAddLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressAddLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressAddLabel.Location = new System.Drawing.Point(42, 143);
            this.AddressAddLabel.Name = "AddressAddLabel";
            this.AddressAddLabel.Size = new System.Drawing.Size(73, 23);
            this.AddressAddLabel.TabIndex = 1;
            this.AddressAddLabel.Text = "Address";
            // 
            // PriceAddLabel
            // 
            this.PriceAddLabel.AutoSize = true;
            this.PriceAddLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceAddLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceAddLabel.Location = new System.Drawing.Point(51, 168);
            this.PriceAddLabel.Name = "PriceAddLabel";
            this.PriceAddLabel.Size = new System.Drawing.Size(48, 23);
            this.PriceAddLabel.TabIndex = 2;
            this.PriceAddLabel.Text = "Price";
            // 
            // TotalPriceAddLabel
            // 
            this.TotalPriceAddLabel.AutoSize = true;
            this.TotalPriceAddLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPriceAddLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPriceAddLabel.Location = new System.Drawing.Point(20, 220);
            this.TotalPriceAddLabel.Name = "TotalPriceAddLabel";
            this.TotalPriceAddLabel.Size = new System.Drawing.Size(95, 23);
            this.TotalPriceAddLabel.TabIndex = 4;
            this.TotalPriceAddLabel.Text = "Total Price";
            // 
            // FreeAddLabel
            // 
            this.FreeAddLabel.AutoSize = true;
            this.FreeAddLabel.BackColor = System.Drawing.Color.Transparent;
            this.FreeAddLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeAddLabel.Location = new System.Drawing.Point(53, 193);
            this.FreeAddLabel.Name = "FreeAddLabel";
            this.FreeAddLabel.Size = new System.Drawing.Size(46, 23);
            this.FreeAddLabel.TabIndex = 3;
            this.FreeAddLabel.Text = "Free";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Violet;
            this.AddButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(258, 375);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 37);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitAddButton
            // 
            this.ExitAddButton.BackColor = System.Drawing.Color.Violet;
            this.ExitAddButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitAddButton.Location = new System.Drawing.Point(144, 375);
            this.ExitAddButton.Name = "ExitAddButton";
            this.ExitAddButton.Size = new System.Drawing.Size(88, 37);
            this.ExitAddButton.TabIndex = 7;
            this.ExitAddButton.Text = "Exit";
            this.ExitAddButton.UseVisualStyleBackColor = false;
            this.ExitAddButton.Click += new System.EventHandler(this.ExitAddButton_Click);
            // 
            // NameAddBox
            // 
            this.NameAddBox.Location = new System.Drawing.Point(121, 124);
            this.NameAddBox.Name = "NameAddBox";
            this.NameAddBox.Size = new System.Drawing.Size(100, 20);
            this.NameAddBox.TabIndex = 8;
            // 
            // AddressAddBox
            // 
            this.AddressAddBox.Location = new System.Drawing.Point(121, 147);
            this.AddressAddBox.Name = "AddressAddBox";
            this.AddressAddBox.Size = new System.Drawing.Size(100, 20);
            this.AddressAddBox.TabIndex = 9;
            // 
            // PriceAddBox
            // 
            this.PriceAddBox.Location = new System.Drawing.Point(121, 172);
            this.PriceAddBox.Name = "PriceAddBox";
            this.PriceAddBox.Size = new System.Drawing.Size(100, 20);
            this.PriceAddBox.TabIndex = 10;
            // 
            // TotalPriceAddBox
            // 
            this.TotalPriceAddBox.Location = new System.Drawing.Point(121, 224);
            this.TotalPriceAddBox.Name = "TotalPriceAddBox";
            this.TotalPriceAddBox.Size = new System.Drawing.Size(100, 20);
            this.TotalPriceAddBox.TabIndex = 12;
            // 
            // FreeAddBox
            // 
            this.FreeAddBox.Location = new System.Drawing.Point(121, 197);
            this.FreeAddBox.Name = "FreeAddBox";
            this.FreeAddBox.Size = new System.Drawing.Size(100, 20);
            this.FreeAddBox.TabIndex = 11;
            // 
            // AddHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 442);
            this.Controls.Add(this.TotalPriceAddBox);
            this.Controls.Add(this.FreeAddBox);
            this.Controls.Add(this.PriceAddBox);
            this.Controls.Add(this.AddressAddBox);
            this.Controls.Add(this.NameAddBox);
            this.Controls.Add(this.ExitAddButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TotalPriceAddLabel);
            this.Controls.Add(this.FreeAddLabel);
            this.Controls.Add(this.PriceAddLabel);
            this.Controls.Add(this.AddressAddLabel);
            this.Controls.Add(this.NameAddLabel);
            this.Name = "AddHotelForm";
            this.Text = "AddHotelForm";
            this.Load += new System.EventHandler(this.AddHotelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameAddLabel;
        private System.Windows.Forms.Label AddressAddLabel;
        private System.Windows.Forms.Label PriceAddLabel;
        private System.Windows.Forms.Label TotalPriceAddLabel;
        private System.Windows.Forms.Label FreeAddLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitAddButton;
        private System.Windows.Forms.TextBox NameAddBox;
        private System.Windows.Forms.TextBox AddressAddBox;
        private System.Windows.Forms.TextBox PriceAddBox;
        private System.Windows.Forms.TextBox TotalPriceAddBox;
        private System.Windows.Forms.TextBox FreeAddBox;
    }
}