using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BusCompanyClient
{
    public class Connection
    {
        //Access to the database
        private const string Adress = "ddwap.mah.se";
        private const string RootName = "af8408";
        private const string Password = "Naelnael10";
        private const string Database = "af8408";

        //Variables for the connection and the reader
        public MySqlConnection SQLConnection;
        public MySqlDataReader SQLReader;

        //Constructor
        public Connection()
        {
            EstablishConnection();
        }

        /// <summary>
        /// Tries to establish a connection to the database
        /// </summary>
        private void EstablishConnection()
        {
            try
            {
                SQLConnection = new MySqlConnection
                    ("server=" + Adress + ";uid=" + RootName + ";pwd=" + Password + ";database=" + Database);
                SQLConnection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            SQLConnection.Close();
        }

        /// <summary>
        /// Used when you want to update the database with a question
        /// </summary>
        /// <param name="aQuestion">A valid MySQL question, doesn't need to be pre-prepared</param>
        public void SendSQLQuestion(MySqlCommand aQuestion)
        {
            SQLConnection.Open();
            aQuestion.Prepare();
            SQLReader = aQuestion.ExecuteReader();
            SQLConnection.Close();
            SQLReader.Close();
        }
    }
}
