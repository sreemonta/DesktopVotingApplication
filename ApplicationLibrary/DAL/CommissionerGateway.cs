using VotingApplication.Library.Connection;
using VotingApplication.Library.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VotingApplication.Library.DAL
{
    public class CommissionerGateway
    {
        private DBConnector dbconnector = null;

        public CommissionerGateway()
        {
            dbconnector = new DBConnector();
        }

        public string Save(Commissioner commissioner)
        {
            try
            {
                string commandString = "Insert Into Commissioner(CommissionerID, CommissionerName, Password) VALUES ('" + commissioner.Id +
                                       "','" + commissioner.Name + "','" + commissioner.Password + "')";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                int affectedRows = myCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    return "Saved";
                }
                else
                {
                    return "Not saved.";
                }
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

        public Commissioner Select(string Id)
        {
            try
            {
                string commandString = "Select * From Commissioner Where CommissionerID ='" + Id + "'";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                SqlDataReader reader = myCommand.ExecuteReader();

                Commissioner commissioner = new Commissioner();
                while (reader.Read())
                {
                    commissioner.Id = reader[0].ToString();
                    commissioner.Name = reader[1].ToString();
                    commissioner.Password = reader[2].ToString();
                }
                return commissioner;
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

        public bool Delete(string id)
        {
            try
            {
                string commandString = "Delete From Commissioner Where CommissionerID ='" + id + "'";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                int affectedRows = myCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                    return true;
                else
                    return false;
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

        public List<Competitor> GetVoteResult()
        {
            try
            {
                
                string commandString = @"Select TVR.CompetitorName, TVR.NoOfVote From VoteResult TVR " +
                    " Inner Join Competitor TC On TVR.CompetitorID = TC.CompetitorID " +
                    " Order By NoOfVote Desc";

                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                SqlDataReader reader = myCommand.ExecuteReader();

                List<Competitor> competitors = new List<Competitor>();
                Competitor competitor = null;

                while (reader.Read())
                {
                    competitor = new Competitor();
                    competitor.Name = reader[0].ToString();
                    competitor.NoOfVote = Convert.ToInt32(reader[1]);
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
