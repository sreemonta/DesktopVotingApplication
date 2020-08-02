using System;
using System.Configuration;
using System.Data.SqlClient;

namespace VotingApplication.Library.Models
{
    public class Competitor
    {
        private string id;
        private string name;
        private int noOfVote;
        private string status;

        public int NoOfVote
        {
            get { return noOfVote; }
            set { noOfVote = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}