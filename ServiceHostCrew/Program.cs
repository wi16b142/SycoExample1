using ServiceDefinitionCrew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHostCrew
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service_Crew));
            host.Open();
            Console.WriteLine("Service started.");
            Console.ReadLine();
        }
    }
}
