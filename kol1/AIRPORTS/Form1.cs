using AIRPORTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIRPORTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onClickAddAirport(object sender, EventArgs e)
        {
            AddAirport frm=new AddAirport();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(frm.airport);
            }
        }

        private void onClickRemoveAirport(object sender, EventArgs e)
        {
            if (lbAirports.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("DALI SI SIGUREN" , "SIGUREN LI SI? ",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Airport airport = lbAirports.SelectedItem as Airport;
                    airport.Destinations.Clear();
                    lbAirports.Items.Remove(airport);
                    updateComponent(airport);
                }
            }

        }

        private void onClickAddDestination(object sender, EventArgs e)
        {
            if (lbAirports.SelectedItems.Count > 0)
            {
                Airport airport = lbAirports.SelectedItem as Airport;
                AddDestination frm = new AddDestination();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    airport.addDestination(frm.destination);
                    updateComponent(airport);
                }
            }
        }


       private void updateComponent(Airport airport)
        {
            updateDestBox(airport);
            updateMax(airport);
            updateAverage(airport);
        }



        private void updateMax(Airport airport)
        {
            if(airport.Destinations.Count > 0)
            {
                tbMostExpensive.Text = airport.mostExpensive().ToString();
            }
            else
            {
                tbMostExpensive.Text = "NO DESTINATION YET!!!";
            }
            
        }

        private void updateAverage(Airport airport)
        {
            if (airport.Destinations.Count > 0)
            {
                tbAvgDest.Text = airport.getAverageLengthForDestinations().ToString();
            }
            else
            {
                tbAvgDest.Text = "NO DESTINATION YET!!!";
            }
        }

        private void updateDestBox(Airport airport)
        {
            lbDestinations.Items.Clear();
            lbDestinations.Items.AddRange(airport.Destinations.ToArray());
            tbMostExpensive.Clear();
            tbAvgDest.Clear();
        }

        private void handleChange(object sender, EventArgs e)
        {
            if (lbAirports.SelectedItems.Count > 0)
            {
                Airport airport = lbAirports.SelectedItem as Airport;
                updateComponent(airport);
            }
        }
    }
}
