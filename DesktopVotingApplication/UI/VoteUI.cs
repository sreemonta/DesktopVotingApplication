using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using VotingApplication.Library.BLL;
using VotingApplication.Library.Models;

namespace VotingApplication.UI
{
    public partial class VoteUI : Form
    {
        private CompetitorManager competitorManager = null;
        private List<Competitor> competitors = null;
        private VoterManager voterManager = null;
        private string voterNationalId;

        public VoteUI()
        {
            InitializeComponent();
            competitorManager = new CompetitorManager();
            competitors = competitorManager.GetCompetitor();
            PopulateCheckListBox(competitors);
        }

        public string VoterNationalId
        {
            get { return voterNationalId; }
            set { voterNationalId = value; }
        }

        private void PopulateCheckListBox(List<Competitor> competitors)
        {
            foreach (Competitor competitor in competitors)
            {
                competitorCheckedListBox.Items.Add(competitor.Name);
            }
        }

        private void competitorCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (competitorCheckedListBox.CheckedItems.Count >= 3)
            {
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show("You can't give vote, more than 3 competitor.", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void castButton_Click(object sender, EventArgs e)
        {
            if (competitorCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please check at least one competitor, then try again.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            foreach (string competitorName in competitorCheckedListBox.CheckedItems)
            {
                voterManager = new VoterManager();
                Competitor competitor = competitors.Find(delegate(Competitor competitorObj)
                {
                    return competitorObj.Name == competitorName;
                });
                voterManager.Vote(competitor.Id);
            }
            voterManager.UpdateVoterAfterVote(voterNationalId);
            this.Close();
            MessageBox.Show("Your vote casted successfully.", "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
    }
}
