namespace PL
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersAndRewards_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Users_dataGridView = new System.Windows.Forms.DataGridView();
            this.addUser_menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Rewards_dataGridView = new System.Windows.Forms.DataGridView();
            this.addReward_menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RewardMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_menuStrip.SuspendLayout();
            this.UsersAndRewards_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).BeginInit();
            this.addUser_menuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rewards_dataGridView)).BeginInit();
            this.addReward_menuStrip.SuspendLayout();
            this.UserMenu.SuspendLayout();
            this.RewardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_menuStrip
            // 
            this.Main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.dataSourceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Main_menuStrip.Name = "Main_menuStrip";
            this.Main_menuStrip.Size = new System.Drawing.Size(800, 32);
            this.Main_menuStrip.TabIndex = 0;
            this.Main_menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::PL.Properties.Resources.kisspng_hamburger_button_computer_icons_menu_clip_art_5adcc45cad2da2_9774904315244176287094;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(24, 28);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::PL.Properties.Resources.icons8_обновить_левое_вращение_64;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::PL.Properties.Resources.icons8_удалить_64;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Close";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataSourceToolStripMenuItem
            // 
            this.dataSourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoryToolStripMenuItem,
            this.dataBaseToolStripMenuItem});
            this.dataSourceToolStripMenuItem.Image = global::PL.Properties.Resources.icons8_конфигурация_данных_30;
            this.dataSourceToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.dataSourceToolStripMenuItem.Name = "dataSourceToolStripMenuItem";
            this.dataSourceToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.dataSourceToolStripMenuItem.Text = "Data source";
            // 
            // memoryToolStripMenuItem
            // 
            this.memoryToolStripMenuItem.Image = global::PL.Properties.Resources.icons8_оперативная_память_смартфона_filled_50;
            this.memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
            this.memoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.memoryToolStripMenuItem.Text = "Memory";
            this.memoryToolStripMenuItem.Click += new System.EventHandler(this.memoryToolStripMenuItem_Click);
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.Image = global::PL.Properties.Resources.icons8_база_данных_filled_50;
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataBaseToolStripMenuItem.Text = "Data Base";
            this.dataBaseToolStripMenuItem.Click += new System.EventHandler(this.dataBaseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::PL.Properties.Resources.icons8_о_нас_24;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // UsersAndRewards_tabControl
            // 
            this.UsersAndRewards_tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.UsersAndRewards_tabControl.Controls.Add(this.tabPage1);
            this.UsersAndRewards_tabControl.Controls.Add(this.tabPage2);
            this.UsersAndRewards_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersAndRewards_tabControl.Location = new System.Drawing.Point(0, 32);
            this.UsersAndRewards_tabControl.Multiline = true;
            this.UsersAndRewards_tabControl.Name = "UsersAndRewards_tabControl";
            this.UsersAndRewards_tabControl.Padding = new System.Drawing.Point(6, 8);
            this.UsersAndRewards_tabControl.SelectedIndex = 0;
            this.UsersAndRewards_tabControl.Size = new System.Drawing.Size(800, 321);
            this.UsersAndRewards_tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Users_dataGridView);
            this.tabPage1.Controls.Add(this.addUser_menuStrip);
            this.tabPage1.Location = new System.Drawing.Point(33, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Users_dataGridView
            // 
            this.Users_dataGridView.AllowUserToAddRows = false;
            this.Users_dataGridView.AllowUserToDeleteRows = false;
            this.Users_dataGridView.AllowUserToResizeColumns = false;
            this.Users_dataGridView.AllowUserToResizeRows = false;
            this.Users_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Users_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Users_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dataGridView.Location = new System.Drawing.Point(1, 30);
            this.Users_dataGridView.Name = "Users_dataGridView";
            this.Users_dataGridView.Size = new System.Drawing.Size(760, 280);
            this.Users_dataGridView.TabIndex = 1;
            this.Users_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.Users_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // addUser_menuStrip
            // 
            this.addUser_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.addUser_menuStrip.Location = new System.Drawing.Point(3, 3);
            this.addUser_menuStrip.Name = "addUser_menuStrip";
            this.addUser_menuStrip.Size = new System.Drawing.Size(757, 24);
            this.addUser_menuStrip.TabIndex = 2;
            this.addUser_menuStrip.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItem2.Text = "Add new user";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Rewards_dataGridView);
            this.tabPage2.Controls.Add(this.addReward_menuStrip);
            this.tabPage2.Location = new System.Drawing.Point(33, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rewards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Rewards_dataGridView
            // 
            this.Rewards_dataGridView.AllowUserToAddRows = false;
            this.Rewards_dataGridView.AllowUserToDeleteRows = false;
            this.Rewards_dataGridView.AllowUserToResizeColumns = false;
            this.Rewards_dataGridView.AllowUserToResizeRows = false;
            this.Rewards_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rewards_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Rewards_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Rewards_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rewards_dataGridView.Location = new System.Drawing.Point(1, 30);
            this.Rewards_dataGridView.Name = "Rewards_dataGridView";
            this.Rewards_dataGridView.Size = new System.Drawing.Size(760, 280);
            this.Rewards_dataGridView.TabIndex = 2;
            this.Rewards_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // addReward_menuStrip
            // 
            this.addReward_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.addReward_menuStrip.Location = new System.Drawing.Point(3, 3);
            this.addReward_menuStrip.Name = "addReward_menuStrip";
            this.addReward_menuStrip.Size = new System.Drawing.Size(757, 24);
            this.addReward_menuStrip.TabIndex = 3;
            this.addReward_menuStrip.Text = "menuStrip3";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(105, 20);
            this.toolStripMenuItem3.Text = "Add new reward";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.addNewRewardToolStripMenuItem_Click);
            // 
            // UserMenu
            // 
            this.UserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changeToolStripMenuItem});
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(147, 70);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNewUserToolStripMenuItem.Text = "Add new user";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // RewardMenu
            // 
            this.RewardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRewardToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.changeToolStripMenuItem1});
            this.RewardMenu.Name = "RewardMenu";
            this.RewardMenu.Size = new System.Drawing.Size(161, 70);
            // 
            // addNewRewardToolStripMenuItem
            // 
            this.addNewRewardToolStripMenuItem.Name = "addNewRewardToolStripMenuItem";
            this.addNewRewardToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addNewRewardToolStripMenuItem.Text = "Add new reward";
            this.addNewRewardToolStripMenuItem.Click += new System.EventHandler(this.addNewRewardToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // changeToolStripMenuItem1
            // 
            this.changeToolStripMenuItem1.Name = "changeToolStripMenuItem1";
            this.changeToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.changeToolStripMenuItem1.Text = "Change";
            this.changeToolStripMenuItem1.Click += new System.EventHandler(this.changeToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.UsersAndRewards_tabControl);
            this.Controls.Add(this.Main_menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.addUser_menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users And Rewards";
            this.Main_menuStrip.ResumeLayout(false);
            this.Main_menuStrip.PerformLayout();
            this.UsersAndRewards_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).EndInit();
            this.addUser_menuStrip.ResumeLayout(false);
            this.addUser_menuStrip.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rewards_dataGridView)).EndInit();
            this.addReward_menuStrip.ResumeLayout(false);
            this.addReward_menuStrip.PerformLayout();
            this.UserMenu.ResumeLayout(false);
            this.RewardMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabControl UsersAndRewards_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Users_dataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem dataSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.DataGridView Rewards_dataGridView;
        private System.Windows.Forms.ContextMenuStrip UserMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip RewardMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip addUser_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip addReward_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

