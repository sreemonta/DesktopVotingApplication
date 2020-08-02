using VotingApplication.Library.Connection;
using VotingApplication.Library.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace VotingApplication.Library.DAL
{
    public class VoterGateway
    {
        private DBConnector dbconnector = null;

        public VoterGateway()
        {
            dbconnector = new DBConnector();
        }

        public string Save(Voter voter)
        {
            try
            {
                string commandString = "Insert Into Voter(VoterID, VoterName, VoteCast) VALUES ('" + voter.NationalId +
                                       "','" + voter.Name + "','" + voter.VoteCast + "')";
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

        public Voter Select(string voterId)
        {
            try
            {
                string commandString = "Select * From Voter where VoterID ='" + voterId + "'";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                SqlDataReader reader = myCommand.ExecuteReader();

                Voter votarObj = new Voter();
                while (reader.Read())
                {
                    votarObj.NationalId = reader[0].ToString();
                    votarObj.Name = reader[1].ToString();
                    votarObj.VoteCast = reader[2].ToString();
                }
                return votarObj;
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

        public bool Delete(string voterId)
        {
            try
            {
                string commandString = "Delete From Voter Where VoterID ='" + voterId + "'";
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

        public string Vote(string competitorId)
        {
            try
            {
                    string commandString = "Select * From VoteResult Where CompetitorID ='" + competitorId + "'";
                    SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                    SqlDataReader reader = myCommand.ExecuteReader();

                    Competitor competitor = new Competitor();
                    if (reader.Read())
                    {
                        competitor.NoOfVote = Convert.ToInt32(reader[2]);
                    }
                    dbconnector.CloseConnection();

                    commandString = "Update VoteResult Set NoOfVote=" + (competitor.NoOfVote + 1) +
                                    " Where CompetitorID='" + competitorId + "'";
                    myCommand = dbconnector.CreateSqlCommand(commandString);
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

        public string DeleteVote(string competitorId)
        {
            try
            {
                string commandString = "Update VoteResult Set NoOfVote= 0 Where CompetitorID='" + competitorId + "'";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                int affectedRows = myCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    return "Updated";
                }
                else
                {
                    return "Not Updated.";
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

        public string UpdateVoterAfterVote(string voterId)
        {
            try
            {
                string commandString = "Update Voter Set VoteCast= 'Y' Where VoterID='" + voterId + "'";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                myCommand.ExecuteNonQuery();
                dbconnector.CloseConnection();

                commandString = "Select * From Voter Where VoterID ='" + voterId + "'";
                myCommand = dbconnector.CreateSqlCommand(commandString);
                SqlDataReader reader = myCommand.ExecuteReader();

                Voter voter = new Voter();
                if (reader.Read())
                {
                    voter.VoteCast = reader[2].ToString();
                }
                return voter.VoteCast;
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

        public string InitializeVoter(string voterId)
        {
            try
            {
                string commandString = "Update Voter Set VoteCast= 'N' Where VoterID='" + voterId + "'";
                SqlCommand myCommand = dbconnector.CreateSqlCommand(commandString);
                int affectedRows = myCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    return "Updated";
                }
                else
                {
                    return "Not Updated.";
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
    }
}
