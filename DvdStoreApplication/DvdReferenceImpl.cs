namespace DvdStoreApplication
{
    public class DvdReferenceImpl : Dvd 
    {
        private string _review;
        private string _reference;
        private string _title;
        public DvdReferenceImpl(string reference, string title, string description)
        {
            _review = description;
            _reference = reference;
            _title = title;
        }

        public string GetReview()
        {
            return _review;
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetReference()
        {
            return _reference;
        }
    }
}
