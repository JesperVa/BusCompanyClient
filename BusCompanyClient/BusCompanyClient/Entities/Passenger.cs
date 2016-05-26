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

        public string PID
        {
            get { return myPID; }
        }
        
        public string Name
        {
            get { return myName; }
        }

        public string Adress
        {
            get { return myAdress; }
        }

        public Passenger(int aPID, string aName, string aAdress)
        {
            myPID = aPID.ToString();
            myName = aName;
            myAdress = aAdress;
        }

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

        public void RegisterPassenger()
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO passengers (PID, Name, Adress) VALUES(@PID, @Name, @Adress)",
                                                Program.myConnection.SQLConnection);
            cmd.Parameters.AddWithValue("@PID", myPID);
            cmd.Parameters.AddWithValue("@Name", myName);
            cmd.Parameters.AddWithValue("@Adress", myAdress);

            Program.myConnection.SendSQLQuestion(cmd);
        }

    }
}
