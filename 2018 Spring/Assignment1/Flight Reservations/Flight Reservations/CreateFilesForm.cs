using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class CreateFilesForm : Form
    {
        //Create a FlightFactory object to create flights
        FlightFactory.FlightFactory temp = new FlightFactory.FlightFactory();

        /// <summary>
        /// Initializes the form 
        /// </summary>
        public CreateFilesForm()
        {
            InitializeComponent();  
        }

        /// <summary>
        /// btnDisplayFlights click event handler. Creates a web browser and displays
        /// flights.xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayFlights_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "flights.xml"; 
            frm.ShowDialog();
        }

        /// <summary>
        /// btnCreateFlights click event handler. Uses a FlightFactory object to creates flights, 
        /// and then create a flights.xml using the flights created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateFlights_Click(object sender, EventArgs e)
        {        
            temp.CreateFlights();
            temp.Serialize();
        }

        /// <summary>
        /// btnDeserialize click event handler. Uses FlightFactory object to read the flights.xml
        /// file and create a list of flight objects. It then displays the list of flight objects 
        /// in a listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            lstbxFlightSchedules.Items.Clear();
            temp.DeSerialize();
            List<Flight> flights = temp.GetFlights();
            foreach (Flight a in flights)
            {
                lstbxFlightSchedules.Items.Add(a);
            }
        }
    }
}
