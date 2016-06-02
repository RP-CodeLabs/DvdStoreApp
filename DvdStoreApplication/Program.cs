using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var dvdServiceImplementation = new DvdServiceImpl();
            var summary = dvdServiceImplementation.GetDvdSummary("DVD-TG423");
            Console.WriteLine($"Dvd Summary : {summary}");
            Console.ReadLine();
        }
    }
}
