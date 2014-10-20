using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using CrimeHeadlineSystem.Classes.Factory;
using CrimeHeadlineSystem.Web.Models;

namespace CrimeHeadlineSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<string> newsList = new List<string>();
            var polisen = ScrapingFactory.CreateScreenScraperForPolisen();
            var polisenNews = polisen.GetHtmlContentFromScraping();
            var utryckning = ScrapingFactory.CreateScreenScraperForUtryckning();
            var utryckningNews = utryckning.GetHtmlContentFromScraping();
            newsList.Add(polisenNews);
            newsList.Add(utryckningNews);
            return View(new IndexViewModel{NewsList = newsList});
        }

    }
}
