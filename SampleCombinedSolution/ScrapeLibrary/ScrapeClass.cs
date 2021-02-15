using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary

    /*
     All of this code below and the code in the ScarpeLibrary is part of uber solutiuon called SampleCombinedSolution, 
     which shows how to copmbine multiple code assemblies into one larger solution taht can be deployed
    */
{
    public class ScrapeClass
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
