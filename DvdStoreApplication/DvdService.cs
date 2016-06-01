namespace DvdStoreApplication
{
    public interface DvdService
    {
        Dvd RetrieveDvd(string dvdReference);
        string GetDvdSummary(string dvdReference);
    }
}
