using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationGui
{
    /// <summary>
    ///This program was created as a coursework assignment by
    ///@Author   : Miguel A. Ruelas Jacobo
    ///For:
    ///Course    : COP 4814 Component Based Software Development U01
    ///Professor : Kip Irvine
    ///Assignment:Assignment 1
    ///Due Date : 02/11/2018
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new CreateFilesForm());
            //Application.Run(new FactoryTest()); //Uncomment to enable
        }
    }
}
