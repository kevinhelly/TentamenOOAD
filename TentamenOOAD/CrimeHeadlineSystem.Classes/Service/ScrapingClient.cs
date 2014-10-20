using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeHeadlineSystem.Classes.Interface;
using HtmlAgilityPack;

namespace CrimeHeadlineSystem.Classes.Service
{
    public abstract class ScrapingClient : IScrapingClient
    {
        public abstract string Site { get; }
        public abstract string Xpath { get; }

        public string GetHtmlContentFromScraping()
        {
            var webClient = new HtmlWeb();
            var htmlClient = new HtmlDocument();
            htmlClient = webClient.Load(Site);
            return htmlClient.DocumentNode.SelectSingleNode(Xpath).InnerText;
        }
    }
}
