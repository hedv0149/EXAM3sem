using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FlightsWCFForExam
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Flight> AllFlights();

        [OperationContract]
        Flight FindFlightByNR(int number);

        [OperationContract]
        string ChangeFlights(int number, string type, string locationFrom, string locationTo, DateTime departure, DateTime arrival);
    }

    
}
