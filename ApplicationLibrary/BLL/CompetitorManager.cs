using VotingApplication.Library.DAL;
using VotingApplication.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VotingApplication.Library.BLL
{
    public class CompetitorManager
    {
        private CompetitorGateway competitorGateway = null;

        public CompetitorManager()
        {
            competitorGateway = new CompetitorGateway();
        }

        public int FindNumberOfCustingVote(string competitorId)
        {
            return competitorGateway.FindNumberOfCustingVote(competitorId);
        }

        public List<Competitor> GetCompetitor()
        {
            return competitorGateway.GetCompetitor();
        }
    }
}
