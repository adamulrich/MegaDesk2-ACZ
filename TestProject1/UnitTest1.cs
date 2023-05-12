
using MegaDesk;
using NUnit.Framework;

namespace TestProject1
{
    
    

    public class Tests
    {
        private const int V = 0;

        public void Setup()
        {
        }

        [Test]
        public void SaveToFileLoadFromFile()
        {
            MegaDesk.JsonPersistence jp = new MegaDesk.JsonPersistence();
            
            DeskQuote quote = new DeskQuote();

            quote.customerName = "Foo Bar";
            quote.desk.depth = 24;
            quote.desk.width = 36;
            quote.desk.material = material.Pine;
            quote.desk.drawer_count = 1;
            quote.Date = DateTime.Now;
            quote.productionTime = productionTime.normal;
            quote.calculatePrice();
            
            jp.AddToFile(quote);

            List<DeskQuote> quoteData = jp.LoadQuotes();
            DeskQuote lastQuote = quoteData.Last();
            Assert.That(quote.customerName == lastQuote.customerName, "Customer Name Not Equal");
            Assert.That(quote.price == lastQuote.price, "Price Not Equal");
            Assert.That(quote.desk.depth == lastQuote.desk.depth, "desk depth Not Equal");
            Assert.That(quote.desk.width == lastQuote.desk.width, "desk width Not Equal");
            Assert.That(quote.desk.material == lastQuote.desk.material, "desk material Not Equal");
            Assert.That(quote.desk.drawer_count == lastQuote.desk.drawer_count, "desk drawer count Not Equal");
            Assert.That(quote.Date == lastQuote.Date, "date Not Equal");
            Assert.That(quote.productionTime == lastQuote.productionTime, "production time Not Equal");


        }
    }
}