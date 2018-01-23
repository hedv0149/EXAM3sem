using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FlightsWCFForExam
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        object myLock = new object();
        public List<Flight> list = new List<Flight>();
        Flight flight1 = new Flight(1, "economic", "Riga", "Tallinn", DateTime.Parse("25.08.2012 14:00"), DateTime.Parse("25.08.2018 14:00"));
        Flight flight2 = new Flight(2, "economic", "Vilnus", "Tallinn", DateTime.Parse("24.08.2012 14:00"), DateTime.Parse("25.05.2018 14:00"));
        

        public List<Flight> AllFlights()
        {
            lock (myLock)
            {
                list.Add(flight1);
                list.Add(flight2);
                return list.ToList();
            }
        }

        public string ChangeFlights(int number, string type, string locationFrom, string locationTo, DateTime departure, DateTime arrival)
        {
            string answer = "no such flight!";
            lock (myLock)
            {
                list.Add(flight1);
                list.Add(flight2);
                foreach (Flight flight in list)
                {
                    if(number == flight.Number)
                    {
                        answer = "done!";
                        flight.Type = type;
                        flight.LocationFrom = locationFrom;
                        flight.LocationTo = locationTo;
                        flight.Departure = departure;
                        flight.Arrival = arrival;
                    }
                }

                //Flight neededFlight = FindFlightByNR(number);
                //if (neededFlight != null)
                //{
                //    answer = "done!";
                //    neededFlight.Type = type;
                //    neededFlight.LocationFrom = locationFrom;
                //    neededFlight.LocationTo = locationTo;
                //    neededFlight.Departure = departure;
                //    neededFlight.Arrival = arrival;
                //}

            }
            return answer;
        }

        public Flight FindFlightByNR(int number)
        {
            Flight answer = null;
            lock (myLock)
            {
                list.Add(flight1);
                list.Add(flight2);
                foreach (Flight flight in list)
                {
                    if (number == flight.Number)
                    {
                        answer = flight;
                    }
                }
            }
            return answer;
        }
    }
}
