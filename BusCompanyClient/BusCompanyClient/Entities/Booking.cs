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

        public Booking(Passenger aPassenger, int aBusID)
        {
            myBusID = aBusID;
            myPassenger = aPassenger;
        }

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
