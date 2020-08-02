using System;
using System.Windows.Forms;
using VotingApplication.Library.BLL;
using VotingApplication.Library.Models;

namespace VotingApplication.UI
{
    public partial class CommissionerLoginUI : Form
    {
        public CommissionerLoginUI()
        {
            InitializeComponent();
            nationalIdTextBox.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (nationalIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter national Id, then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nationalIdTextBox.Clear();
                passwordTextBox.Clear();
                nationalIdTextBox.Focus();
                return;
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter password, then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }

            Commissioner commissioner = new Commissioner();
            CommissionerManager commissionerManager = new CommissionerManager();
            commissioner.Id = nationalIdTextBox.Text;
            commissioner = commissionerManager.SelectCommissioner(commissioner.Id);

            if (commissioner.Id != null && commissioner.Password == passwordTextBox.Text)
            {
                VoteResultUI voteResultUi = new VoteResultUI();
                voteResultUi.MdiParent = this.MdiParent;
                this.Close();
                voteResultUi.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid national Id or password, then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nationalIdTextBox.Clear();
                passwordTextBox.Clear();
                nationalIdTextBox.Focus();
            }
        }
    }
}
