using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Classes.Service
{
    public class UtryckningScrapingClient : ScrapingClient
    {
        

        public override string Site { get { return string.Format("http://www.utryckning.se/"); } }

        public override string Xpath { get { return @"id('homepage')/div[1]/div[1]/h1"; } }
    }
}
