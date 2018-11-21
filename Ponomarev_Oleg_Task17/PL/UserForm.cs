using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PL
{
    public partial class UserForm : Form
    {
        public Common.Users GetUser() => user;
        private Common.Users user;
        public IEnumerable<int> GetRewards() => rewardsIds;
        private IEnumerable<int> rewardsIds = new List<int>();
        private int UserID;

        public UserForm()
        {
            InitializeComponent();
            this.Text = "Create User";
        }

        public UserForm(Common.Users user)
        {
            InitializeComponent();
            if (user != null)
            {
                UserID = user.ID;
                FirstName_textBox.Text = user.FirstName;
                LastName_textbox.Text = user.LastName;
                birthdate_MaskedTextBox.Text = user.Birthday.ToString();
            }
            this.Text = "Change User";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstName_textBox != null && birthdate_MaskedTextBox != null && birthdate_MaskedTextBox.ValidateText() != null)
            {
                user = new Common.Users()
                {
                    ID = UserID,
                    FirstName = FirstName_textBox.Text,
                    LastName = LastName_textbox.Text,
                    Birthday = (DateTime)birthdate_MaskedTextBox.ValidateText(),
                };
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect values");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("Insert IDs of rewards\nFormat:\n1,2,3..", "Rewards");
            rewardsIds = Regex.Matches(result, @"\d+").Cast<Match>().Select(x => Int32.Parse(x.Value)).ToList();
            Rewards_maskedTextBox.Text = result;

        }
    }
}
