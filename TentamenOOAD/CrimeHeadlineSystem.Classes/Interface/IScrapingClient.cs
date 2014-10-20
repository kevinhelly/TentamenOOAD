using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Classes.Interface
{
    public interface IScrapingClient
    {
        string GetHtmlContentFromScraping();
    }
}
