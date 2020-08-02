using System;
using System.Configuration;
using System.Data.SqlClient;

namespace VotingApplication.Library.Models
{
    public class Voter
    {
        private string nationalId;
        private string name;
        private string voteCast;

       
        public Voter(string nationalId, string name, string voteCast)
        {
            this.nationalId = nationalId;
            this.Name = name;
            this.voteCast = voteCast;
        }

        public Voter()
        {
            
        }

        public string VoteCast
        {
            get { return voteCast; }
            set { voteCast = value; }
        }

        public string NationalId
        {
            get { return nationalId; }
            set { nationalId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}