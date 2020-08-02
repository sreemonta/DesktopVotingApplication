using System;
using System.Windows.Forms;
using VotingApplication.Library.BLL;
using VotingApplication.Library.Models;

namespace VotingApplication.UI
{
    public partial class VoterLoginUI : Form
    {
        public VoterLoginUI()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(nationalIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter national Id, then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Voter voter = new Voter();
            VoterManager voterManager = new VoterManager();
            voter.NationalId = nationalIdTextBox.Text;
            voter = voterManager.SelectVoter(voter.NationalId);
            
            if(voter.NationalId != null && voter.VoteCast == "N")
            {
                VoteUI voteUi = new VoteUI();
                voteUi.MdiParent = this.MdiParent;
                voteUi.VoterNationalId = voter.NationalId;
                this.Close();
                voteUi.Show();
            }
            else
            {
                if(voter.VoteCast == "Y")
                    MessageBox.Show("Your vote is already casted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Please enter a valid national Id, then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nationalIdTextBox.Clear();
                nationalIdTextBox.Focus();
            }
        }
    }
}
