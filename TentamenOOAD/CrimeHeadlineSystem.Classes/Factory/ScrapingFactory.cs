using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeHeadlineSystem.Classes.Interface;
using CrimeHeadlineSystem.Classes.Service;

namespace CrimeHeadlineSystem.Classes.Factory
{
    public class ScrapingFactory
    {
        public static IScrapingClient CreateScreenScraperForPolisen()
        {
            return new PolisenScrapingClient();
            //if (site.ToLower().Contains("eniro"))
            //    return new EniroScrapingClient(orgNr);
            //else if (site.ToLower().Contains("hitta"))
            //    return new HittaScrapingClient(orgNr);
            //else if (site.ToLower().Contains("upplysning"))
            //    return new UpplysningScrapingClient(orgNr);
            //else
            //    return new AllabolagScrapingClient(orgNr);
        }
        public static IScrapingClient CreateScreenScraperForUtryckning()
        {
            return new UtryckningScrapingClient();
        }
    }
}
