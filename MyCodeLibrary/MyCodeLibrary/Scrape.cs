using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyCodeLibrary
{
    public class Scrape // this is a a class (assembly or class library) that is compiled into a DLL that can be used by other projects in C#
    {

        public string ScrapeWebPage(string strUrl)
        {
            return GetWebpage(strUrl);
        }

        public string ScrapeWebPage(string strUrl, string strTextFilePath)
        {
            string strReply = GetWebpage(strUrl);
            File.WriteAllText(strTextFilePath, strReply); // write path and reply string to text file - we would normally do something with this data
            return strReply; // return the text of the string
        }

        private string GetWebpage(string strUrl) // private helper method to get the actual web page address
        {
            WebClient client = new WebClient();
            return client.DownloadString(strUrl); //gets the full text of the specified page (the URL's string value)
        }
    }

}
