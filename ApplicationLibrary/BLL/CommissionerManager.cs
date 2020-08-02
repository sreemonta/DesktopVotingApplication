using VotingApplication.Library.DAL;
using VotingApplication.Library.Models;
using System;
using System.Collections.Generic;

namespace VotingApplication.Library.BLL
{
    public class CommissionerManager
    {
        private CommissionerGateway commissionerGateway = null;

        public CommissionerManager()
        {
            commissionerGateway = new CommissionerGateway();
        }

        public string SaveCommissioner(Commissioner commissioner)
        {
            return commissionerGateway.Save(commissioner);
        }

        public Commissioner SelectCommissioner(string id)
        {
            return commissionerGateway.Select(id);
        }

        public bool DeleteCommissioner(string id)
        {
            return commissionerGateway.Delete(id);
        }

        public List<Competitor> GetVoteResult()
        {
            int Max = 0, initWinCount = 0;
            List<Competitor> competitors = new List<Competitor>();
            competitors = commissionerGateway.GetVoteResult();

            for (int i = 0; i < competitors.Count; i++)
            {
                if (competitors[Max].NoOfVote > competitors[i].NoOfVote)
                {
                    competitors[Max].Status = "Winner";
                }
                else if(competitors[Max].NoOfVote < competitors[i].NoOfVote)
                {
                    competitors[i].Status = "Winner";
                    Max = i;
                }
                else if(competitors[Max].NoOfVote == competitors[i].NoOfVote)
                {
                    competitors[Max].Status = "Winner";
                    competitors[i].Status = "Winner";
                    if (i > Max)
                    {
                        Max = i;
                    }
                    
                }
            }

            for (int j = 0; j < competitors.Count; j++)
            {
                if (competitors[j].Status == "Winner")
                {
                    initWinCount += 1;
                }
                else if (competitors[j].Status == null)
                {
                    competitors[j].Status = "--";
                }
            }

            if (initWinCount > 1)
            {
                foreach (var item in competitors)
                {
                    if (item.Status == "Winner")
                    {
                        item.Status = "Tie";
                    }
                }
            }

            return competitors;
        }
    }
}