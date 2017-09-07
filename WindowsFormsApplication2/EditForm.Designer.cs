namespace WindowsFormsApplication2
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PasswordEdit1Label = new System.Windows.Forms.Label();
            this.PasswordEdit2Label = new System.Windows.Forms.Label();
            this.PasswordEdit3Label = new System.Windows.Forms.Label();
            this.NameEditLabel = new System.Windows.Forms.Label();
            this.SurnameEditLabel = new System.Windows.Forms.Label();
            this.NameEditBox = new System.Windows.Forms.TextBox();
            this.SurnameEditBox = new System.Windows.Forms.TextBox();
            this.PasswordEdit1Box = new System.Windows.Forms.TextBox();
            this.PasswordEdit2Box = new System.Windows.Forms.TextBox();
            this.PasswordEdit3Box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.Location = new System.Drawing.Point(328, 253);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(91, 33);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(231, 253);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 33);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PasswordEdit1Label
            // 
            this.PasswordEdit1Label.AutoSize = true;
            this.PasswordEdit1Label.BackColor = System.Drawing.Color.Transparent;
            this.PasswordEdit1Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEdit1Label.Location = new System.Drawing.Point(14, 124);
            this.PasswordEdit1Label.Name = "PasswordEdit1Label";
            this.PasswordEdit1Label.Size = new System.Drawing.Size(113, 23);
            this.PasswordEdit1Label.TabIndex = 2;
            this.PasswordEdit1Label.Text = "Old Password";
            // 
            // PasswordEdit2Label
            // 
            this.PasswordEdit2Label.AutoSize = true;
            this.PasswordEdit2Label.BackColor = System.Drawing.Color.Transparent;
            this.PasswordEdit2Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEdit2Label.Location = new System.Drawing.Point(14, 150);
            this.PasswordEdit2Label.Name = "PasswordEdit2Label";
            this.PasswordEdit2Label.Size = new System.Drawing.Size(120, 23);
            this.PasswordEdit2Label.TabIndex = 3;
            this.PasswordEdit2Label.Text = "New Password";
            // 
            // PasswordEdit3Label
            // 
            this.PasswordEdit3Label.AutoSize = true;
            this.PasswordEdit3Label.BackColor = System.Drawing.Color.Transparent;
            this.PasswordEdit3Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEdit3Label.Location = new System.Drawing.Point(14, 177);
            this.PasswordEdit3Label.Name = "PasswordEdit3Label";
            this.PasswordEdit3Label.Size = new System.Drawing.Size(108, 23);
            this.PasswordEdit3Label.TabIndex = 4;
            this.PasswordEdit3Label.Text = "Confirm New";
            // 
            // NameEditLabel
            // 
            this.NameEditLabel.AutoSize = true;
            this.NameEditLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameEditLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameEditLabel.Location = new System.Drawing.Point(14, 42);
            this.NameEditLabel.Name = "NameEditLabel";
            this.NameEditLabel.Size = new System.Drawing.Size(93, 23);
            this.NameEditLabel.TabIndex = 5;
            this.NameEditLabel.Text = "New Name";
            // 
            // SurnameEditLabel
            // 
            this.SurnameEditLabel.AutoSize = true;
            this.SurnameEditLabel.BackColor = System.Drawing.Color.Transparent;
            this.SurnameEditLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameEditLabel.Location = new System.Drawing.Point(14, 74);
            this.SurnameEditLabel.Name = "SurnameEditLabel";
            this.SurnameEditLabel.Size = new System.Drawing.Size(115, 23);
            this.SurnameEditLabel.TabIndex = 6;
            this.SurnameEditLabel.Text = "New Surname";
            // 
            // NameEditBox
            // 
            this.NameEditBox.Location = new System.Drawing.Point(142, 42);
            this.NameEditBox.Name = "NameEditBox";
            this.NameEditBox.Size = new System.Drawing.Size(100, 20);
            this.NameEditBox.TabIndex = 7;
            // 
            // SurnameEditBox
            // 
            this.SurnameEditBox.Location = new System.Drawing.Point(142, 74);
            this.SurnameEditBox.Name = "SurnameEditBox";
            this.SurnameEditBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameEditBox.TabIndex = 8;
            // 
            // PasswordEdit1Box
            // 
            this.PasswordEdit1Box.Location = new System.Drawing.Point(142, 124);
            this.PasswordEdit1Box.Name = "PasswordEdit1Box";
            this.PasswordEdit1Box.PasswordChar = '*';
            this.PasswordEdit1Box.Size = new System.Drawing.Size(100, 20);
            this.PasswordEdit1Box.TabIndex = 9;
            // 
            // PasswordEdit2Box
            // 
            this.PasswordEdit2Box.Location = new System.Drawing.Point(142, 154);
            this.PasswordEdit2Box.Name = "PasswordEdit2Box";
            this.PasswordEdit2Box.PasswordChar = '*';
            this.PasswordEdit2Box.Size = new System.Drawing.Size(100, 20);
            this.PasswordEdit2Box.TabIndex = 10;
            // 
            // PasswordEdit3Box
            // 
            this.PasswordEdit3Box.Location = new System.Drawing.Point(142, 181);
            this.PasswordEdit3Box.Name = "PasswordEdit3Box";
            this.PasswordEdit3Box.PasswordChar = '*';
            this.PasswordEdit3Box.Size = new System.Drawing.Size(100, 20);
            this.PasswordEdit3Box.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(231, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 267);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 313);
            this.Controls.Add(this.PasswordEdit3Box);
            this.Controls.Add(this.PasswordEdit2Box);
            this.Controls.Add(this.PasswordEdit1Box);
            this.Controls.Add(this.SurnameEditBox);
            this.Controls.Add(this.NameEditBox);
            this.Controls.Add(this.SurnameEditLabel);
            this.Controls.Add(this.NameEditLabel);
            this.Controls.Add(this.PasswordEdit3Label);
            this.Controls.Add(this.PasswordEdit2Label);
            this.Controls.Add(this.PasswordEdit1Label);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PasswordEdit1Label;
        private System.Windows.Forms.Label PasswordEdit2Label;
        private System.Windows.Forms.Label PasswordEdit3Label;
        private System.Windows.Forms.Label NameEditLabel;
        private System.Windows.Forms.Label SurnameEditLabel;
        private System.Windows.Forms.TextBox NameEditBox;
        private System.Windows.Forms.TextBox SurnameEditBox;
        private System.Windows.Forms.TextBox PasswordEdit1Box;
        private System.Windows.Forms.TextBox PasswordEdit2Box;
        private System.Windows.Forms.TextBox PasswordEdit3Box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}