namespace PL
{
    partial class UserRewardsForm
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
            this.components = new System.ComponentModel.Container();
            this.UserRewards_dataGridView = new System.Windows.Forms.DataGridView();
            this.UserRewardsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRewardToUser_menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UserRewards_dataGridView)).BeginInit();
            this.UserRewardsMenu.SuspendLayout();
            this.AddRewardToUser_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserRewards_dataGridView
            // 
            this.UserRewards_dataGridView.AllowUserToAddRows = false;
            this.UserRewards_dataGridView.AllowUserToDeleteRows = false;
            this.UserRewards_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserRewards_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserRewards_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.UserRewards_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserRewards_dataGridView.Location = new System.Drawing.Point(0, 27);
            this.UserRewards_dataGridView.Name = "UserRewards_dataGridView";
            this.UserRewards_dataGridView.Size = new System.Drawing.Size(404, 140);
            this.UserRewards_dataGridView.TabIndex = 0;
            this.UserRewards_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // UserRewardsMenu
            // 
            this.UserRewardsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRewardToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.UserRewardsMenu.Name = "UserRewardsMenu";
            this.UserRewardsMenu.Size = new System.Drawing.Size(166, 48);
            // 
            // addNewRewardToolStripMenuItem
            // 
            this.addNewRewardToolStripMenuItem.Name = "addNewRewardToolStripMenuItem";
            this.addNewRewardToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addNewRewardToolStripMenuItem.Text = "Add new rewards";
            this.addNewRewardToolStripMenuItem.Click += new System.EventHandler(this.addNewRewardToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // AddRewardToUser_menuStrip
            // 
            this.AddRewardToUser_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.AddRewardToUser_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddRewardToUser_menuStrip.Name = "AddRewardToUser_menuStrip";
            this.AddRewardToUser_menuStrip.Size = new System.Drawing.Size(404, 24);
            this.AddRewardToUser_menuStrip.TabIndex = 1;
            this.AddRewardToUser_menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 20);
            this.toolStripMenuItem1.Text = "Add new rewards";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.addNewRewardToolStripMenuItem_Click);
            // 
            // UserRewardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 167);
            this.Controls.Add(this.AddRewardToUser_menuStrip);
            this.Controls.Add(this.UserRewards_dataGridView);
            this.MainMenuStrip = this.AddRewardToUser_menuStrip;
            this.Name = "UserRewardsForm";
            this.Text = "UserRewardsForm";
            ((System.ComponentModel.ISupportInitialize)(this.UserRewards_dataGridView)).EndInit();
            this.UserRewardsMenu.ResumeLayout(false);
            this.AddRewardToUser_menuStrip.ResumeLayout(false);
            this.AddRewardToUser_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView UserRewards_dataGridView;
        private System.Windows.Forms.ContextMenuStrip UserRewardsMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip AddRewardToUser_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewRewardToolStripMenuItem;
    }
}