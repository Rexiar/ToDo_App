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
            this.activityListBox = new System.Windows.Forms.ListBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.testCheckBox = new System.Windows.Forms.CheckedListBox();
            this.WhatIsChecked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(279, 378);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 28);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "hey :)";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // activityListBox
            // 
            this.activityListBox.FormattingEnabled = true;
            this.activityListBox.ItemHeight = 16;
            this.activityListBox.Location = new System.Drawing.Point(93, 138);
            this.activityListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityListBox.Name = "activityListBox";
            this.activityListBox.Size = new System.Drawing.Size(332, 116);
            this.activityListBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(813, 138);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(132, 22);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.Text = "Nama Aktivitas";
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(847, 409);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 28);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "button1";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(585, 377);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // testCheckBox
            // 
            this.testCheckBox.FormattingEnabled = true;
            this.testCheckBox.Location = new System.Drawing.Point(485, 155);
            this.testCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testCheckBox.Name = "testCheckBox";
            this.testCheckBox.Size = new System.Drawing.Size(159, 106);
            this.testCheckBox.TabIndex = 5;
            this.testCheckBox.SelectedIndexChanged += new System.EventHandler(this.testCheckBox_SelectedIndexChanged);
            // 
            // WhatIsChecked
            // 
            this.WhatIsChecked.Location = new System.Drawing.Point(453, 449);
            this.WhatIsChecked.Name = "WhatIsChecked";
            this.WhatIsChecked.Size = new System.Drawing.Size(130, 23);
            this.WhatIsChecked.TabIndex = 6;
            this.WhatIsChecked.Text = "WhatIsChecked";
            this.WhatIsChecked.UseVisualStyleBackColor = true;
            this.WhatIsChecked.Click += new System.EventHandler(this.WhatIsChecked_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.WhatIsChecked);
            this.Controls.Add(this.testCheckBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.activityListBox);
            this.Controls.Add(this.refreshButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ListBox activityListBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckedListBox testCheckBox;
        private System.Windows.Forms.Button WhatIsChecked;
    }
}

