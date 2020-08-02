using VotingApplication.Library.DAL;
using VotingApplication.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VotingApplication.Library.BLL
{
    public class VoterManager
    {
        private VoterGateway voterGateway = null;
        private int numberOfVoteCastByVoter;

        public VoterManager()
        {
            voterGateway=new VoterGateway();
            numberOfVoteCastByVoter = 0;
        }

        public string SaveVoter(Voter voter)
        {
            return voterGateway.Save(voter);
        }

        public Voter SelectVoter(string voterId)
        {
            return voterGateway.Select(voterId);
        }

        public bool DeleteVoter(string voterId)
        {
            return voterGateway.Delete(voterId);
        }

        public string Vote(string competitorId)
        {
            if (numberOfVoteCastByVoter < 3)
            {
                numberOfVoteCastByVoter++;
                return voterGateway.Vote(competitorId);
            }
            return "Not Saved.";
        }

        public string DeleteVote(string competitorId)
        {
            return voterGateway.DeleteVote(competitorId);
        }

        public string UpdateVoterAfterVote(string voterId)
        {
            return voterGateway.UpdateVoterAfterVote(voterId);
        }

        public string InitializeVoter(string voterId)
        {
            return voterGateway.InitializeVoter(voterId);
        }

        public bool CheckNumberOfVoteCastByVoter()
        {
            if (numberOfVoteCastByVoter <= 3)
            {
                return true;
            }
            return false;
        }
    }
}
