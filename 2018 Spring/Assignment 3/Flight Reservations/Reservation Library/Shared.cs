using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Reservation_Library
{
    /// <summary>
    /// contains the list of flights, which tends to be shared between different component classes. 
    /// This class must not be Public, because we do not want it to be accessed by any code outside the Reservation Library component.
    /// </summary>
    class Shared
    {
        private static FlightFactory fliFact = new FlightFactory();     //Holds all flight information
        private static DateTime startDate = new DateTime(2017, 06, 01); //Date to start the flights
        private static int days = DateTime.DaysInMonth(2017, 06);       //Get the days in the month of June 2017
        private static DateTime endDate = startDate.AddDays(days);      //Add the days in June to the start date to get the end date.
        private static XmlSerializer serial;                       //Used to create/read XML file
        //private static Random rand = new Random();                 //Used to randomize numbers - not used yet

        public static List<Flight> Flight
        {
            get
            {
                if (fliFact.GetFlights().Count == 0)
                {
                    CheckFile();
                }
                return fliFact.GetFlights();
            }

        }

        private static void CheckFile()
        {
            if (File.Exists(fliFact.FilePath))
            {
                fliFact.DeSerialize();
            }
            else
            {
                fliFact.CreateFlights();
                fliFact.Serialize();
            }
        }

        public static DateTime StartDate()
        {
            return startDate;
        }

        public static DateTime EndDate()
        {
            return endDate;
        }

        public static List<Airport> Airports()
        {
            return Airport.GetAirports();

        }

        public static Boolean Serialize(Object anytype, String filePath,String version)
        {

            try
            {
                //Serialize 
                serial = new XmlSerializer(anytype.GetType());
                StreamWriter sw = new StreamWriter(filePath);
                if (version == "1.3")  //check version to alter behaviour of CreateFlightRequest form.
                {
                    using (sw)
                    {
                        using (XmlTextWriter writer = new XmlTextWriter(sw))
                        {
                            writer.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"utf-8\"");
                            writer.WriteProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"displayFlights.xslt\"");
                            serial.Serialize(writer, anytype);
                        }
                    }

                    
                }
                else 
                {
                    serial.Serialize(sw, anytype);
                    sw.Close();


                }
                
                return true;

            }
            catch
            {
                //error occurred return false.
                return false;
            }


        }
    }
}
