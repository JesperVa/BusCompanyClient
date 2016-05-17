using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BusCompanyClient
{
    public class Assigner
    {
        #region Member Variables
        private List<Bus> myBuses;
        private List<Destination> myDestinations;
        private List<Passenger> myPassengers;
        #endregion

        #region Properties
        public List<Bus> Buses
        {
            get { return myBuses; }
        }

        public List<Destination> Destinations
        {
            get { return myDestinations; }
        }

        public List<Passenger> Passengers
        {
            get { return myPassengers; }
        }
        #endregion

        #region Constructors
        public Assigner(Connection aConnection)
        {
            myBuses = new List<Bus>();
            myDestinations = new List<Destination>();
            myPassengers = new List<Passenger>();
            Assign(aConnection);
        }
        #endregion

        #region Private methods
        private void Assign(Connection aConnection)
        {
            aConnection.SQLConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM bus");
            //cmd.Prepare();

            aConnection.SQLReader = cmd.ExecuteReader();

            while (aConnection.SQLReader.Read())
            {
                myBuses.Add(Bus.AssignBus(aConnection.SQLReader));
            }
            aConnection.SQLReader.Close();

            cmd = new MySqlCommand("SELECT * FROM destination");
            //cmd.Prepare();

            aConnection.SQLReader = cmd.ExecuteReader();

            while(aConnection.SQLReader.Read())
            {
                myDestinations.Add(Destination.AssignDestination(aConnection.SQLReader));
            }
            aConnection.SQLReader.Close();
            aConnection.SQLConnection.Close();

            cmd = new MySqlCommand("SELECT * FROM passengers");
            //cmd.Prepare();

            aConnection.SQLReader = cmd.ExecuteReader();

            while(aConnection.SQLReader.Read())
            {
                myPassengers.Add(Passenger.AssignPassenger(aConnection.SQLReader));
            }
            
        }
        #endregion
    }
}
