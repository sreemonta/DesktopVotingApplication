using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VotingApplication.UI
{
    public partial class VotingSystemUI : Form
    {
        public VotingSystemUI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, want to exit?", "Voting System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void voterLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoterLoginUI voterLoginUi = new VoterLoginUI();
            voterLoginUi.MdiParent = this;
            voterLoginUi.Show();
        }

        private void commissionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommissionerLoginUI commissionerLoginUi = new CommissionerLoginUI();
            commissionerLoginUi.MdiParent = this;
            commissionerLoginUi.Show();
        }
    }
}
