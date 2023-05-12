
using MegaDesk;
using NUnit.Framework;
using System.Globalization;


namespace TestProject1
{
    
    

    public class Tests
    {
        private const int V = 0;

        public void Setup()
        {
        }

        [Test]
        public void SaveToFile_LoadFromFile()
        {
            MegaDesk.JsonPersistence jp = new MegaDesk.JsonPersistence();
            
            DeskQuote quote = new DeskQuote();

            var textInfo = new CultureInfo("en-US", false).TextInfo;


            quote.customerName = textInfo.ToTitleCase(TestHelpers.RandomString(TestHelpers.random.Next(3, 10)))  + " " + textInfo.ToTitleCase(TestHelpers.RandomString(TestHelpers.random.Next(3, 10)));
            quote.desk.depth = TestHelpers.random.Next(12, 49);
            quote.desk.width = TestHelpers.random.Next(24, 97);
            quote.desk.material = TestHelpers.RandomEnumValue<material>();
            quote.desk.drawer_count = TestHelpers.random.Next(0, 8);
            quote.date = DateTime.Now;
            quote.productionTime = TestHelpers.RandomEnumValue<productionTime>();
            quote.calculatePrice();
            
            jp.AddQuoteToFile(quote);

            List<DeskQuote> quoteData = jp.LoadQuotes();
            DeskQuote lastQuote = quoteData.Last();
            Assert.That(quote.customerName == lastQuote.customerName, "Customer Name Not Equal");
            Assert.That(quote.price == lastQuote.price, "Price Not Equal");
            Assert.That(quote.desk.depth == lastQuote.desk.depth, "desk depth Not Equal");
            Assert.That(quote.desk.width == lastQuote.desk.width, "desk width Not Equal");
            Assert.That(quote.desk.material == lastQuote.desk.material, "desk material Not Equal");
            Assert.That(quote.desk.drawer_count == lastQuote.desk.drawer_count, "desk drawer count Not Equal");
            Assert.That(quote.date == lastQuote.date, "date Not Equal");
            Assert.That(quote.productionTime == lastQuote.productionTime, "production time Not Equal");


        }
    }
}