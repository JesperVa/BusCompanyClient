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
