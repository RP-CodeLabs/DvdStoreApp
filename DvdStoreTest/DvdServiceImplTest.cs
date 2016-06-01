using DvdStoreApplication;
using NUnit.Framework;

namespace DvdStoreTest
{
    [TestFixture]
    public class DvdServiceImplTest
    {
        [TestCase]
        public void RetrieveDvd_invalid_text_should_return_must_begin_with_dvd()
        {
            var serviceImlp = new DvdServiceImpl();


            var ex = Assert.Catch<DvdNotFoundException>(() => serviceImlp.RetrieveDvd("INVALID-TEXT"));

            Assert.AreEqual(ex.Message, "Reference must begin with DVD-");
        }

        [TestCase]
        public void RetrieveDvd_invalid_reference_should_return_unable_to_find_dvd()
        {
            var serviceImlp = new DvdServiceImpl();


            var ex = Assert.Catch<DvdNotFoundException>(() => serviceImlp.RetrieveDvd("DVD-999"));

            Assert.AreEqual(ex.Message, "Unable to find dvd");
        }

        [TestCase]
        public void RetrieveDvd_valid_reference_should_return_valid_dvd()
        {
            var serviceImlp = new DvdServiceImpl();


            var result = serviceImlp.RetrieveDvd("DVD-TG423");

            Assert.AreEqual(result.GetTitle(), "Topgun");
        }

        [TestCase]
        public void GetDvdSummary_invalid_reference_should_return_must_begin_with_dvd()
        {
            var serviceImlp = new DvdServiceImpl();


            var ex = Assert.Catch<DvdNotFoundException>(() => serviceImlp.GetDvdSummary("INVALID-TEXT"));

            Assert.AreEqual(ex.Message, "Reference must begin with DVD-");
        }

        [TestCase]
        public void GetDvdSummary_invalid_reference_should_return_unable_to_find_dvd()
        {
            var serviceImlp = new DvdServiceImpl();


            var ex = Assert.Catch<DvdNotFoundException>(() => serviceImlp.RetrieveDvd("DVD-999"));

            Assert.AreEqual(ex.Message, "Unable to find dvd");
        }

        [TestCase]
        public void GetDvdSummary_valid_reference_should_return_valid_dvd()
        {
            var serviceImlp = new DvdServiceImpl();


            var result = serviceImlp.GetDvdSummary("DVD-TG423");

            Assert.AreEqual(result, "DVD-TG423 Topgun - All action film");
        }

        [TestCase]
        public void GetDvdSummary_valid_reference_should_return_valid_more_than_ten_words_dvd()
        {
            var serviceImlp = new DvdServiceImpl();


            var result = serviceImlp.GetDvdSummary("DVD-S765");

            Assert.AreEqual(result, "DVD-S765 Shrek - Green monsters seem to be all the rage these days...");
        }

    }
}
