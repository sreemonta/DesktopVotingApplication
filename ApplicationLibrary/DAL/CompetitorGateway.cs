using VotingApplication.Library.Connection;
using VotingApplication.Library.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace VotingApplication.Library.DAL
{
    public class CompetitorGateway
    {
        private DBConnector dbconnector = null;

        public CompetitorGateway()
        {
            dbconnector = new DBConnector();
        }

        public int FindNumberOfCustingVote(string competitorId)
        {
            try
            {
                string commandString = "Select * From VoteResult Where CompetitorID ='" + competitorId + "'";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                SqlDataReader reader = myCommand.ExecuteReader();

                Competitor competitor = new Competitor();
                if (reader.Read())
                {
                    competitor.NoOfVote = Convert.ToInt32(reader[1]);
                }
                else
                {
                    competitor.NoOfVote = 0;
                }
                return competitor.NoOfVote;
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                dbconnector.CloseConnection();
            }
        }

        public List<Competitor> GetCompetitor()
        {
            try
            {
                string commandString = @"Select * From Competitor";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                SqlDataReader reader = myCommand.ExecuteReader();

                List<Competitor> competitors = new List<Competitor>();
                Competitor competitor = null;
                while (reader.Read())
                {
                    competitor = new Competitor();
                    competitor.Id = reader[0].ToString();
                    competitor.Name = reader[1].ToString();
                    competitors.Add(competitor);
                }
                return competitors;
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                dbconnector.CloseConnection();
            }
        }
    }
}
