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
        int myCurrentBusID;

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
            foreach (Passenger p in Program.myAssigner.Passengers)
            {
                PassengerList.Items.Add(p.Name);
            }

            //foreach(Bus b in Program.myAssigner.Buses)
            //{

            //}

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
                if(b.FromDestination == (string)FromDestinationList.SelectedItem)
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
                    TimeBox.Items.Add(b.DepatureTime);
                }
            }
        }

        private void TimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Bus b in Program.myAssigner.Buses)
            {
                if (b.FromDestination == (string)FromDestinationList.SelectedItem && b.ToDestination == (string)ToDestinationList.SelectedItem && b.DepatureTime == (string)TimeBox.SelectedItem)
                {
                    ArrivalLabel.Text = "Arrival Time: " + b.ArrivalTime;
                    DateLabel.Text = "Depature Date: " + b.Date;
                }
            }
        }

        private void ClearGeneral()
        {
            ArrivalLabel.Text = "Arrival Time: ";
            DateLabel.Text = "Depature Date: ";
            TimeBox.Items.Clear();
        }
    }
}
