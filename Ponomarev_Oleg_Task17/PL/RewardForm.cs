using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class RewardForm : Form
    {
        public Rewards GetReward() => reward;
        private Rewards reward;
        private int rewardId;

        public RewardForm()
        {
            InitializeComponent();
            this.Text = "Create Reward";
        }

        public RewardForm(Rewards reward)
        {
            InitializeComponent();
            if (reward != null)
            {
                rewardId = reward.ID;
                title_textBox.Text = reward.Title;
                decription_richtextBox.Text = reward.Decription;
            }
            this.Text = "Change Reward";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(title_textBox.Text)&&title_textBox.Text.Length<50&&decription_richtextBox.Text.Length<150)
            {
                reward = new Rewards()
                {
                    ID= rewardId,
                    Title = title_textBox.Text,
                    Decription = decription_richtextBox.Text
                };
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect values");
            }
        }
    }
}
