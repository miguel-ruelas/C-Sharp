using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightFactory;
using Flights;

/// <summary>
///This program was created as a coursework assignment by
///@Author   : Miguel A. Ruelas Jacobo
///For:
///Course    : COP 4814 Component Based Software Development U01
///Professor : Kip Irvine
///Assignment:Assignment 1
///Due Date : 02/11/2018
/// </summary>
namespace FlightReservationGui
{
    /// <summary>
    /// A Gui test class created to quickly verify the functonality of a FlightFactory object using a listbox.
    /// Edit Program.CS to enable.
    /// </summary>
    public partial class FactoryTest : Form
    {
        public FactoryTest()
        {
            InitializeComponent();
        }

        private void btnCreateFlights_Click(object sender, EventArgs e)
        {
            FlightFactory.FlightFactory test = new FlightFactory.FlightFactory();
            test.CreateFlights();
            List<Flight> t = test.GetFlights();
            foreach (Flight i in t)
            {
                string flight = i.ToString();
                listBox1.Items.Add(flight);

            }

        }
    }
}
