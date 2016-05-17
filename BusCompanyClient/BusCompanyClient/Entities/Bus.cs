using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BusCompanyClient
{
    public class Bus
    {
        private int myID;
        private string myDepartureTime;
        private string myArrivalTime;
        private string myWeekDay;
        private string myDate;
        private int myWeekNumber;
        private int myPrice;
        private int mySeats;
        private string myFromDestination;
        private string myToDestination;

        public Bus(int aID, string aDepartureTime, string aArrivalTime, string aWeekDay, string aDate,
            int aWeekNumber, int aPrice, int aSeats, string aFromDestination, string aToDestination)
        {
            myID = aID;
            myDepartureTime = aDepartureTime;
            myArrivalTime = aArrivalTime;
            myWeekDay = aWeekDay;
            myDate = aDate;
            myWeekNumber = aWeekNumber;
            myPrice = aPrice;
            mySeats = aSeats;
            myFromDestination = aFromDestination;
            myToDestination = aToDestination;
        }

        public static Bus AssignBus(MySqlDataReader aReader)
        {
            Bus aBus = new Bus(aReader.GetInt32(0), aReader.GetString(0), aReader.GetString(1), aReader.GetString(2),
                aReader.GetString(3), aReader.GetInt32(1), aReader.GetInt32(2), aReader.GetInt32(3), 
                aReader.GetString(4), aReader.GetString(5));
            
            return aBus;
        }
    }
}
