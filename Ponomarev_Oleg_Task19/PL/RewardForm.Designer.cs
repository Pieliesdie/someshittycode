namespace PL
{
    partial class RewardForm
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
            this.decription_richtextBox = new System.Windows.Forms.RichTextBox();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decription_richtextBox
            // 
            this.decription_richtextBox.Location = new System.Drawing.Point(22, 74);
            this.decription_richtextBox.Name = "decription_richtextBox";
            this.decription_richtextBox.Size = new System.Drawing.Size(333, 80);
            this.decription_richtextBox.TabIndex = 0;
            this.decription_richtextBox.Text = "";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(22, 28);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(333, 20);
            this.title_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decription";
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(22, 175);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(75, 23);
            this.Ok_button.TabIndex = 4;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(280, 175);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // RewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 222);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.decription_richtextBox);
            this.Name = "RewardForm";
            this.Text = "RewardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox decription_richtextBox;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}