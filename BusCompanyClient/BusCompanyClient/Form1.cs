using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BusCompanyClient
{
    public partial class Form1 : Form
    {
        List<Booking> PackageBookings = new List<Booking>();
        public Form1()
        {
            InitializeComponent();
        }


        #region Shit
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /* private void AssignEntities()
         {

         } */
        #endregion

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public void FillLists()
        {

            ClearAll();
            PassengerList.DisplayMember = "Name";
            foreach (Passenger p in Program.myAssigner.Passengers)
            {
                PassengerList.Items.Add(p);
            }

            foreach(Destination d in Program.myAssigner.Destinations)
            {
                FromDestinationList.Items.Add(d.Name);
            }
        }

        private void FromDestinationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearGeneral();
            ToDestinationList.Items.Clear();

            foreach (Bus b in Program.myAssigner.Buses)
            {
                if(b.FromDestination == (string)FromDestinationList.SelectedItem && !ToDestinationList.Items.Contains(b.ToDestination))
                {
                    ToDestinationList.Items.Add(b.ToDestination);
                }
            }
        }

        private void ToDestinationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearGeneral();
            foreach (Bus b in Program.myAssigner.Buses)
            {
                if (b.FromDestination == (string)FromDestinationList.SelectedItem && b.ToDestination == (string)ToDestinationList.SelectedItem)
                {
                    TimeBox.Items.Add(b.DepatureTime + " " + b.Date);
                }
            }
        }

        private void TimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  foreach(Bus b in Program.myAssigner.Buses)
            {
                if (b.FromDestination == (string)FromDestinationList.SelectedItem && b.ToDestination == (string)ToDestinationList.SelectedItem &&
                    b.DepatureTime + " " + b.Date == (string)TimeBox.SelectedItem)
                {
                    ArrivalLabel.Text = "Arrival Time: " + b.ArrivalTime;
                    DateLabel.Text = "Depature Date: " + b.Date;
                }
            }
         */
        }

        private void ClearGeneral()
        {
           /* ArrivalLabel.Text = "Arrival Time: ";
            DateLabel.Text = "Depature Date: "; */
            TimeBox.Items.Clear();
            BookedLabel.Visible = false;
        }

        private void ClearAll()
        {
            TimeBox.Items.Clear();
            ToDestinationList.Items.Clear();
            FromDestinationList.Items.Clear();
            PassengerList.Items.Clear();
            BookedLabel.Visible = false;
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
           

            if (PassengerList.SelectedItem != null && TimeBox.SelectedItem != null)
            {
                Booking booking = null;

                foreach (Bus b in Program.myAssigner.Buses)
                {
                    if (b.DepatureTime + " " + b.Date == (string)TimeBox.SelectedItem && b.ToDestination == (string)ToDestinationList.SelectedItem 
                        && b.FromDestination == (string)FromDestinationList.SelectedItem)
                    {
                        booking = new Booking((Passenger)PassengerList.SelectedItem, b.ID);
                    }
                }
                if (booking != null)
                {
                    booking.RegisterBooking();
                    BookedLabel.Visible = true;
                }
            }
        }

        private void PackageButton_Click(object sender, EventArgs e)
        {
            Booking booking = null;

            foreach (Bus b in Program.myAssigner.Buses)
            {
                if (b.DepatureTime + " " + b.Date == (string)TimeBox.SelectedItem && b.ToDestination == (string)ToDestinationList.SelectedItem 
                    && b.FromDestination == (string)FromDestinationList.SelectedItem)
                {
                    booking = new Booking((Passenger)PassengerList.SelectedItem, b.ID);
                }
            }
            if (booking != null)
            {
                PackageBookings.Add(booking);
                PackageList.Items.Add(FromDestinationList.SelectedItem + " to " + ToDestinationList.SelectedItem + " on " + TimeBox.SelectedItem);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BookPackageButton_Click(object sender, EventArgs e)
        {
            foreach (Booking b in PackageBookings)
            {
                b.RegisterBooking();
            }
            BookedLabel.Visible = true;
            PackageList.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (NameBox.Text != String.Empty && AdressBox.Text != String.Empty && PIDBox.Text != String.Empty && PIDBox.Text.Length >= 6)
            {
                Passenger passenger = new Passenger(PIDBox.Text, NameBox.Text, AdressBox.Text);
                passenger.RegisterPassenger();
                NameBox.Clear();
                AdressBox.Clear();
                PIDBox.Clear();
                SignUpLabel.Text = "You have been registered!";
                SignUpLabel.Visible = true;
                Program.myAssigner = new Assigner(Program.myConnection);
                FillLists();
            }
            else
            {
                SignUpLabel.Text = "You need to fill in all boxes with valid values to register";
                SignUpLabel.Visible = true;
            }
        }
    }
}
