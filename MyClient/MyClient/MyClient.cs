using MyCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class MyClient
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            // string strValue = myScrape.ScrapeWebPage("http://www.msdn.microsoft.com");
            string strValue = myScrape.ScrapeWebPage("http://www.google.com");
            /*
            string strValue = myScrape.ScrapeWebPage("http://www.nike.com");
            - this one fails since the site is expecting authentication before it will let the user scrape the text of the page
            */
            Console.WriteLine(strValue);
            Console.ReadLine();
        }
    }
}
