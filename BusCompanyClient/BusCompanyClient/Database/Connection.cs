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
        private const string Adress = "ddwap.mah.se";
        private const string RootName = "af8408";
        private const string Password = "Naelnael10";
        private const string Database = "af8408";

        public MySqlConnection SQLConnection;
        public MySqlDataReader SQLReader;

        public Connection()
        {
            EstablishConnection();
        }

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

        public void SendSQLQuestion(MySqlCommand aQuestion)
        {
            //cmd.Parameters.AddWithValue(@var, variablen)
            SQLConnection.Open();
            aQuestion.Prepare();
            SQLReader = aQuestion.ExecuteReader();
            SQLConnection.Close();
            SQLReader.Close();
        }

      /* 
        public Object[] ReadConnectionObjects(string aTable)
        {
            Object[] objects;

            myConnection.Open();
            var cmd = new MySqlCommand("SELECT * FROM " + aTable);
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {

            }

            return objects; 
        }
        */
    }
}
