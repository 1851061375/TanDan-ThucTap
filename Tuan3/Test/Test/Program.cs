
using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            /*HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.vesseltracker.com/en/Ships/A2b-Ambition-9113745.html");
            List<LatestPort> result = new List<LatestPort>();

            HtmlNode[] nodes = document.DocumentNode.SelectNodes(".//*[@class='row gutter']/h2").ToArray();
            foreach (var item in nodes)
            {
                if (item.InnerText == "Latest portsAll PORTS")
                {
                    var portNode = item.ParentNode.SelectSingleNode(".//*[@class='data-table']");
                    HtmlNode[] rows = portNode.ChildNodes.ToArray();
                    for (int i = 1; i < rows.Length - 1; i++)
                    {
                        LatestPort latestPort = new LatestPort();
                        string arrival = "", departure = "";
                        latestPort.Port = rows[i].SelectSingleNode(".//div[2]").InnerText;
                        arrival = rows[i].SelectSingleNode(".//div[3]").InnerText;
                        if (arrival != "")
                            latestPort.Arrival = arrival;
                        departure = rows[i].SelectSingleNode(".//div[4]").InnerText;
                        if (departure != "")
                            latestPort.Departure = departure;
                        latestPort.Duration = rows[i].SelectSingleNode(".//div[5]").InnerText;
                        result.Add(latestPort);
                    }
                }

            }

            foreach(var item in result)
            {
                Console.WriteLine(item.Port + " " + item.Arrival + " " + item.Departure + " " + item.Duration);
            }*/
            Console.WriteLine(processUrl("lap;phung;van", "60TH2"));

            Console.ReadKey();
        }

        public static string processUrl(string oldUrl, string newUrl)
        {
            string result = "";
            List<string> urlList = new List<string>();
            urlList = oldUrl.Split(';').ToList();

            if (!urlList.Any(s => s.Contains(newUrl)))
                urlList.Add(newUrl);

            for (int i = 0; i < urlList.Count - 1; i++)
                result += urlList[i] + ";";
            result += urlList[urlList.Count - 1];
            return result;
        }


    }
}

