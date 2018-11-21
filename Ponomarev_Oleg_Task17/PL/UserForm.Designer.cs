namespace PL
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName_textBox = new System.Windows.Forms.MaskedTextBox();
            this.LastName_textbox = new System.Windows.Forms.MaskedTextBox();
            this.birthdate_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.AddReward_button = new System.Windows.Forms.Button();
            this.Rewards_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Birthdate";
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Location = new System.Drawing.Point(72, 23);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(175, 20);
            this.FirstName_textBox.TabIndex = 4;
            // 
            // LastName_textbox
            // 
            this.LastName_textbox.Location = new System.Drawing.Point(73, 58);
            this.LastName_textbox.Name = "LastName_textbox";
            this.LastName_textbox.Size = new System.Drawing.Size(174, 20);
            this.LastName_textbox.TabIndex = 5;
            // 
            // birthdate_MaskedTextBox
            // 
            this.birthdate_MaskedTextBox.Location = new System.Drawing.Point(73, 92);
            this.birthdate_MaskedTextBox.Mask = "00/00/0000";
            this.birthdate_MaskedTextBox.Name = "birthdate_MaskedTextBox";
            this.birthdate_MaskedTextBox.Size = new System.Drawing.Size(174, 20);
            this.birthdate_MaskedTextBox.TabIndex = 6;
            this.birthdate_MaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthdate_MaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(12, 174);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(75, 23);
            this.Ok_button.TabIndex = 7;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(172, 174);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddReward_button
            // 
            this.AddReward_button.Location = new System.Drawing.Point(12, 119);
            this.AddReward_button.Name = "AddReward_button";
            this.AddReward_button.Size = new System.Drawing.Size(235, 23);
            this.AddReward_button.TabIndex = 9;
            this.AddReward_button.Text = "Add Rewards";
            this.AddReward_button.UseVisualStyleBackColor = true;
            this.AddReward_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rewards_maskedTextBox
            // 
            this.Rewards_maskedTextBox.Enabled = false;
            this.Rewards_maskedTextBox.Location = new System.Drawing.Point(13, 148);
            this.Rewards_maskedTextBox.Name = "Rewards_maskedTextBox";
            this.Rewards_maskedTextBox.ReadOnly = true;
            this.Rewards_maskedTextBox.Size = new System.Drawing.Size(234, 20);
            this.Rewards_maskedTextBox.TabIndex = 10;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 201);
            this.Controls.Add(this.Rewards_maskedTextBox);
            this.Controls.Add(this.AddReward_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.birthdate_MaskedTextBox);
            this.Controls.Add(this.LastName_textbox);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox FirstName_textBox;
        private System.Windows.Forms.MaskedTextBox LastName_textbox;
        private System.Windows.Forms.MaskedTextBox birthdate_MaskedTextBox;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button AddReward_button;
        private System.Windows.Forms.MaskedTextBox Rewards_maskedTextBox;
    }
}