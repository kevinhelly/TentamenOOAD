using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Classes.Service
{
    public class PolisenScrapingClient : ScrapingClient
    {

        public override string Site { get { return string.Format("http://www.polisen.se/"); } }

        public override string Xpath { get { return @"id('newslist-1')/div/ul/li[1]/p[1]/a"; } }
    }
}
