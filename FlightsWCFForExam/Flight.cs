using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FlightsWCFForExam
{
    [DataContract]
    public class Flight
    {
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string LocationFrom { get; set; }
        [DataMember]
        public string LocationTo { get; set; }
        [DataMember]
        public DateTime Departure { get; set; }
        [DataMember]
        public DateTime Arrival { get; set; }

        public Flight (int number, string type, string locationFrom, string locationTo, DateTime departure, DateTime arrival)
        {
            this.Number = number;
            this.Type = type;
            this.LocationFrom = locationFrom;
            this.LocationTo = locationTo;
            this.Departure = departure;
            this.Arrival = arrival;
        }
        
    }
}