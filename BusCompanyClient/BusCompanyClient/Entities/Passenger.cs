using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompanyClient
{
    public class Passenger
    {
        private string myPID;
        private string myName;
        private string myAdress;

        public Passenger(string aPID, string aName, string aAdress)
        {
            myPID = aPID;
            myName = aName;
            myAdress = aAdress;
        }

        public static Passenger AssignPassenger(MySqlDataReader aReader)
        {
            Passenger passenger = new Passenger(aReader.GetString(0), aReader.GetString(1), aReader.GetString(2)); 

            return passenger;
        }

    }
}
