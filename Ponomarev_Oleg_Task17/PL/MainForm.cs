using BLL;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class MainForm : Form
    {       
        IData _memory;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddRewardsButtons()
        {
            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();
            ButtonColumn.Text = "Open";
            ButtonColumn.Name = "Rewards";
            ButtonColumn.HeaderText = "Rewards";
            ButtonColumn.UseColumnTextForButtonValue = true;
            ButtonColumn.FlatStyle = FlatStyle.Popup;
            Users_dataGridView.Columns.Add(ButtonColumn);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memoryToolStripMenuItem.Checked == false)
            {
                memoryToolStripMenuItem.Checked = true;
                dataBaseToolStripMenuItem.Checked = false;
                _memory = new UsersAndRewardsDataProvider(UsersAndRewardsDataProvider.MemoryType.Memory);
                UpdateTables();
            }
        }

        public void UpdateTables()
        {
            if (_memory != null)
            {
                Users_dataGridView.Columns.Clear();
                var users = _memory.GetUsers();
                var rewards = _memory.GetRewards();
                Users_dataGridView.DataSource = users;
                Rewards_dataGridView.DataSource = rewards;
                AddRewardsButtons();
            }
        }

        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataBaseToolStripMenuItem.Checked == false)
            {
                dataBaseToolStripMenuItem.Checked = true;
                memoryToolStripMenuItem.Checked = false;
                _memory = new UsersAndRewardsDataProvider(UsersAndRewardsDataProvider.MemoryType.DataBase);
                UpdateTables();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                UserRewardsForm rewardsForm = new UserRewardsForm((int)Users_dataGridView.Rows[e.RowIndex].Cells[0].Value,_memory);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UserMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Users_dataGridView.SelectedRows != null)
            {
                _memory.DeleteUser((int)Users_dataGridView.SelectedRows[0].Cells[0].Value);
            }
            UpdateTables();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_memory == null)
            {
                MessageBox.Show("choose data source");
            }
            else
            {
                UserForm form = new UserForm();
                if(form.ShowDialog() == DialogResult.OK)
                {                    
                   _memory.AddUser(form.GetUser(), form.GetRewards());
                }
                UpdateTables();
            }
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = new Common.Users()
            {
                ID = (int)Users_dataGridView.SelectedRows[0].Cells[0].Value,
                FirstName = (string)Users_dataGridView.SelectedRows[0].Cells[1].Value,
                LastName = (string)Users_dataGridView.SelectedRows[0].Cells[2].Value,
                Birthday = DateTime.Parse(Users_dataGridView.SelectedRows[0].Cells[3].Value.ToString())
            };
            UserForm form = new UserForm(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _memory.UpdateUser(form.GetUser());
            }
            UpdateTables();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RewardMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void addNewRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_memory == null)
            {
                MessageBox.Show("choose data source");
            }
            else
            {
                var form = new RewardForm();
                if(form.ShowDialog() == DialogResult.OK)
                {
                    _memory.AddReward(form.GetReward());
                    UpdateTables();
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Rewards_dataGridView.SelectedRows != null)
            {
                _memory.DeleteReward((int)Rewards_dataGridView.SelectedRows[0].Cells[0].Value);
            }
            UpdateTables();
        }

        private void changeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var reward = new Common.Rewards()
            {
                ID = (int)Rewards_dataGridView.SelectedRows[0].Cells[0].Value,
                Title = (string)Rewards_dataGridView.SelectedRows[0].Cells[1].Value,
                Decription = (string)Rewards_dataGridView.SelectedRows[0].Cells[2].Value,
            };
            var form = new RewardForm(reward);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _memory.UpdateReward(form.GetReward());
                UpdateTables();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_memory != null)
            {
                UpdateTables();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RSREU,2018");
        }
    }
}
