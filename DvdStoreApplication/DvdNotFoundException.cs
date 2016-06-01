using System;

namespace DvdStoreApplication
{
    public class DvdNotFoundException : Exception
    {     
        public DvdNotFoundException(string message) :  base(message)
        {

        }
    }
}
