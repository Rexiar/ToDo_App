namespace ToDo_App
{
    partial class Form1
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.testCheckBox = new System.Windows.Forms.CheckedListBox();
            this.WhatIsChecked = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(90, 332);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(548, 54);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.Text = "Nama Aktivitas";
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(635, 332);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "button1";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(214, 332);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // testCheckBox
            // 
            this.testCheckBox.FormattingEnabled = true;
            this.testCheckBox.Location = new System.Drawing.Point(71, 54);
            this.testCheckBox.Name = "testCheckBox";
            this.testCheckBox.Size = new System.Drawing.Size(204, 199);
            this.testCheckBox.TabIndex = 5;
            this.testCheckBox.SelectedIndexChanged += new System.EventHandler(this.testCheckBox_SelectedIndexChanged);
            // 
            // WhatIsChecked
            // 
            this.WhatIsChecked.Location = new System.Drawing.Point(113, 398);
            this.WhatIsChecked.Margin = new System.Windows.Forms.Padding(2);
            this.WhatIsChecked.Name = "WhatIsChecked";
            this.WhatIsChecked.Size = new System.Drawing.Size(98, 19);
            this.WhatIsChecked.TabIndex = 6;
            this.WhatIsChecked.Text = "WhatIsChecked";
            this.WhatIsChecked.UseVisualStyleBackColor = true;
            this.WhatIsChecked.Click += new System.EventHandler(this.WhatIsChecked_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(296, 57);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "descriptionLabel";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(536, 118);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(127, 123);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.Text = "Deskripsi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.WhatIsChecked);
            this.Controls.Add(this.testCheckBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.refreshButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckedListBox testCheckBox;
        private System.Windows.Forms.Button WhatIsChecked;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}

