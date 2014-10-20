using System;
using CrimeHeadlineSystem.Classes.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrimeHeadlineSystem.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_If_Screen_Scraper_Returns_Value()
        {
            var expectedPolisenNews = "Så kan Polisen bättre utreda våldtäkter";
            var expectedUtryckningNews = "Brand på Ahlstroms i Ställdalen";

            var polisen = ScrapingFactory.CreateScreenScraperForPolisen();
            var polisenNews = polisen.GetHtmlContentFromScraping();
            var utryckning = ScrapingFactory.CreateScreenScraperForUtryckning();
            var utryckningNews = utryckning.GetHtmlContentFromScraping();

            Assert.AreEqual(expectedPolisenNews, polisenNews);
            Assert.AreEqual(expectedUtryckningNews, utryckningNews);
        }
    }
}
