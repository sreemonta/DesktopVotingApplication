using System;
using System.Configuration;
using System.Data.SqlClient;

namespace VotingApplication.Library.Connection
{
    public class DBConnector
    {
        
        private string connectionString = @"server=SREE-PC\MSSQL16; Integrated Security = SSPI; database = VotingSystemDB";
        private SqlConnection sqlConn;

        public SqlCommand CreateSqlCommand(string commandString)
        {
            try
            {
                sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();
                return new SqlCommand(commandString, sqlConn);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void CloseConnection()
        {
            sqlConn.Close();
        }
    }
}
