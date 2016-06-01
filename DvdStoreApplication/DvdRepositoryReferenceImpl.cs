using System.Collections.Generic;

namespace DvdStoreApplication
{
    public class DvdRepositoryReferenceImpl : DvdRepository
    {
        private static string DVD_REFERENCE_PREFIX = "DVD-";
        private static string DVD_TOPGUN_REFERENCE = DVD_REFERENCE_PREFIX + "TG423";
        private static string DVD_DIRTYDANCING_REFERENCE = DVD_REFERENCE_PREFIX + "DD878";
        private static string DVD_SHREK_REFERENCE = DVD_REFERENCE_PREFIX + "S765";

        private static Dictionary<string, DvdReferenceImpl> dvds;
        private static Dictionary<string, DvdReferenceImpl> Dvds()
        {
            dvds = new Dictionary<string, DvdReferenceImpl>();
            dvds.Add(DVD_TOPGUN_REFERENCE,new DvdReferenceImpl(DVD_TOPGUN_REFERENCE, "Topgun", "All action film"));
            dvds.Add(DVD_DIRTYDANCING_REFERENCE,
            new DvdReferenceImpl(DVD_DIRTYDANCING_REFERENCE, "Dirty Dancing", "Nobody leaves baby in the corner"));
            dvds.Add(DVD_SHREK_REFERENCE,
            new DvdReferenceImpl(DVD_SHREK_REFERENCE, "Shrek", "Green monsters seem to be all " +
                    "the rage these days, what with Hulk, Yoda, and that big ugly troll " +
                    "thingy out of the first Harry Potter movie. But Shrek, the flatulent " +
                    "swamp-dwelling ogre with a heart of gold (well, silver at least), " +
                    "is more than capable of rivalling any of them."));
            return dvds;
        }
        public Dvd RetrieveDvd(string reference)
        {           
            return Dvds()[reference];
        }
    }
}
