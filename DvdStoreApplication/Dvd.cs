using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdStoreApplication
{
    public interface Dvd
    {
        string GetReview();
        string GetReference();
        string GetTitle();
    }
}
