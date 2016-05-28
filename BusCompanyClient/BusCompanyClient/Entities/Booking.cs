using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BusCompanyClient
{
    class Booking
    {
        int myBusID;
        Passenger myPassenger;

        /// <summary>
        /// Constructor that will find the passenger from the database and take out all the nessecary information from it using a string
        /// </summary>
        /// <param name="aPassenger">A string of the passengers name</param>
        /// <param name="aBusID">The bus ID</param>
        public Booking(string aPassenger, int aBusID)
        {
            myBusID = aBusID;
            Program.myConnection.SQLConnection.Open();
            try
            {
                MySqlCommand question = new MySqlCommand("SELECT * FROM passengers WHERE name=@aName", Program.myConnection.SQLConnection);
                question.Parameters.AddWithValue("@aName", aPassenger);
                question.Prepare();
                Program.myConnection.SQLReader = question.ExecuteReader();
                Program.myConnection.SQLReader.Read();
                myPassenger = new Passenger(Program.myConnection.SQLReader.GetInt32(0), Program.myConnection.SQLReader.GetString(1),
                                            Program.myConnection.SQLReader.GetString(2));
                Program.myConnection.SQLConnection.Close();
                Program.myConnection.SQLReader.Close();
            }
            catch (MySqlException e)
            {
                //TODO: Insert error shit
                string test = e.Message;
            }
        }

        /// <summary>
        /// Constructor that takes an already initalized passenger
        /// </summary>
        /// <param name="aPassenger">A passenger</param>
        /// <param name="aBusID">A busID</param>
        public Booking(Passenger aPassenger, int aBusID)
        {
            myBusID = aBusID;
            myPassenger = aPassenger;
        }

        /// <summary>
        /// Method used for registering a booking by sending the information to the database
        /// </summary>
        public void RegisterBooking()
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO bookedtrip (PassengerID, BusID) VALUES(@Passenger, @BusID)",
                                                Program.myConnection.SQLConnection);
            cmd.Parameters.AddWithValue("@BusID", myBusID);
            cmd.Parameters.AddWithValue("@Passenger", myPassenger.PID);

            Program.myConnection.SendSQLQuestion(cmd);
        }
    }
}
