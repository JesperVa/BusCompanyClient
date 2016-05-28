using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BusCompanyClient
{
    public class Destination
    {
        private string myName;
        private string myCountry;
        private string myCurrency;
        private string myLanguage;

        public string Name
        {
            get { return myName; }
        }

        public Destination(string aName, string aCountry, string aCurrency, string aLanguage)
        {
            myName = aName;
            myCountry = aCountry;
            myCurrency = aCurrency;
            myLanguage = aLanguage;
        }

        public static Destination AssignDestination(MySqlDataReader aReader)
        {
            Destination aDestination = new Destination(aReader.GetString(0), aReader.GetString(1),
                aReader.GetString(2), aReader.GetString(3));

            return aDestination;
        }

        /// <summary>
        /// Used for registering a destination to the database
        /// </summary>
        public void RegisterDestination()
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO destination (Name, Country, Currency, Language) VALUES(@Name, @Country, @Currency, @Language)",
                                              Program.myConnection.SQLConnection);
            cmd.Parameters.AddWithValue("@Name", myName);
            cmd.Parameters.AddWithValue("@Country", myCountry);
            cmd.Parameters.AddWithValue("@Currency", myCurrency);
            cmd.Parameters.AddWithValue("@Language", myLanguage);

            Program.myConnection.SendSQLQuestion(cmd);
        }
    }
}
