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
        /// <summary>
        /// List of all the currently existing buses
        /// </summary>
        public List<Bus> Buses
        {
            get { return myBuses; }
        }

        /// <summary>
        /// List of all the currently registered destinations
        /// </summary>
        public List<Destination> Destinations
        {
            get { return myDestinations; }
        }

        /// <summary>
        /// List of all the currently registered passengers
        /// </summary>
        public List<Passenger> Passengers
        {
            get { return myPassengers; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aConnection">A valid SQL connection</param>
        public Assigner(Connection aConnection)
        {
            myBuses = new List<Bus>();
            myDestinations = new List<Destination>();
            myPassengers = new List<Passenger>();
            Assign(aConnection);
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Method used for updating all the lists
        /// </summary>
        /// <param name="aConnection"></param>
        private void Assign(Connection aConnection)
        {
            aConnection.SQLConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM bus", aConnection.SQLConnection);
            cmd.Prepare();

            aConnection.SQLReader = cmd.ExecuteReader();

            while (aConnection.SQLReader.Read())
            {
                myBuses.Add(Bus.AssignBus(aConnection.SQLReader));
            }
            aConnection.SQLReader.Close();

            cmd = new MySqlCommand("SELECT * FROM destination", aConnection.SQLConnection);
            cmd.Prepare();

            aConnection.SQLReader = cmd.ExecuteReader();

            while(aConnection.SQLReader.Read())
            {
                myDestinations.Add(Destination.AssignDestination(aConnection.SQLReader));
            }
            aConnection.SQLReader.Close();
            

            cmd = new MySqlCommand("SELECT * FROM passengers", aConnection.SQLConnection);
            cmd.Prepare();

            aConnection.SQLReader = cmd.ExecuteReader();

            while(aConnection.SQLReader.Read())
            {
                myPassengers.Add(Passenger.AssignPassenger(aConnection.SQLReader));
            }

            aConnection.SQLConnection.Close();
            aConnection.SQLReader.Close();

        }
        #endregion
    }
}
