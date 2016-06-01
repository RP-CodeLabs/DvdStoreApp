using System.Text.RegularExpressions;

namespace DvdStoreApplication
{
    public class DvdServiceImpl : DvdService
    {
        private readonly DvdRepository _dvdRespository;
        public DvdServiceImpl()
        {
            _dvdRespository = new DvdRepositoryReferenceImpl();
        }

        public Dvd RetrieveDvd(string reference)
        {
            try
            {
                return _dvdRespository.RetrieveDvd(reference);
            }
            catch { throw new DvdNotFoundException(Validation(reference)); }
        }

        public string GetDvdSummary(string reference)
        {
            try
            {
                var dvd = _dvdRespository.RetrieveDvd(reference);
                return reference + " " +dvd.GetTitle() + " - " + GetTenWords(dvd.GetReview());
            }
            catch { throw new DvdNotFoundException(Validation(reference)); }
            
        }

        private string GetTenWords(string review)
        {
            var text = Regex.Replace(review, @"[-,\?\.\):_;'!\(\[\]\*""]", " ");
            var items = text.Split(' ');
            var sb = new System.Text.StringBuilder();
            int length = items.Length >= 10 ? 10 : items.Length;
            for(int i = 0; i < length; i++)
            {
                sb.Append(items[i]);
                if(i< length-1) { sb.Append(" "); }
                if(i == 9 && length == 10) { sb.Append("..."); }
            }
                       
            return sb.ToString();
        }

        private string Validation(string reference)
        {
            return (reference.StartsWith("DVD-")) ? "Unable to find dvd" : "Reference must begin with DVD-";            
        }
    }
}
