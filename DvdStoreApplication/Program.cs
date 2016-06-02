using System;

namespace DvdStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var dvdImpl = new DvdServiceImpl();
            var summary = dvdImpl.GetDvdSummary("DVD-");
            Console.WriteLine($"Summary : {summary}");
        }
    }
}
