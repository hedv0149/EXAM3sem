using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            Console.WriteLine(service.AllFlights().ToString());
            Console.WriteLine("Find flight 1");
            Console.WriteLine(service.FindFlightByNR(1).ToString());
            Console.WriteLine("Find flight 1 and change it to number = 1, type = monkey, locationFrom = PlanetApe, locationTo = here, departure = 31.12.2017 23:59, arrival = Now");
            Console.WriteLine(service.ChangeFlights(1, "monkey", "PlanetApe", "Here", DateTime.Parse("31.12.2017 23:59"), DateTime.Now));
            Console.ReadKey();
        }
    }
}
