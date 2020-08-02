using System;

namespace VotingApplication.Library.Models
{
    public class Commissioner
    {
        private string id;
        private string name;
        private string password;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}