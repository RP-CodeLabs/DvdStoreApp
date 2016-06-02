using System;

namespace DvdStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dvdServiceImpl = new DvdServiceImpl();
            //var summary = dvdServiceImpl.GetDvdSummary("DVD-TG423");

            var dvdImpl = new DvdServiceImpl();
            var summary = dvdImpl.GetDvdSummary("DVD-");
            Console.WriteLine($"Summary : {summary}");
        }
    }
}
