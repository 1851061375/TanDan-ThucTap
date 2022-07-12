using Demo.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class BaseWeb
    {
        public DateTime? convertStringToDatime(string s)
        {
            return DateTime.ParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture).Date;
        }
        public double getNumberFormString(string s)
        {
            double number = -1;
            try
            {
                number = double.Parse(Regex.Match(s, @"\d+").Value);
            }
            catch (Exception) { }
            return number;
        }
        public HtmlDocument connectWeb(string url)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);
            return document;
        }
        // Lấy số lượng trang
        public Double getWebLength(string url, string parentClass)
        {
            HtmlDocument document = connectWeb(url);
            Double result = 1;
            HtmlNode node;
            // (?)
            if (url != "https://marinetraffic.live/vessels.php")
                node = document.DocumentNode.SelectSingleNode("(.//*[@class='" + parentClass + "'])[last()]/li[last()]/a");         
            else
                node = document.DocumentNode.SelectSingleNode("(.//*[@class='" + parentClass + "'])[last()]/li[last()-1]/a");

            if (node != null)
                result = getNumberFormString(node.GetAttributeValue("href", String.Empty));
            return result;
        }
        // Lấy số lượng tàu trên từng trang
        public int getRowPerPage(string url, string parentClass)
        {
            HtmlDocument document = connectWeb(url);
            HtmlNode[] nodes;
            if (url == "https://www.vesseltracker.com/en/vessels.html")
                nodes = document.DocumentNode.SelectNodes(".//*[@class='" + parentClass + "']/*").ToArray();
            else
                nodes = document.DocumentNode.SelectNodes(".//*[@class='" + parentClass + "']/tbody/*").ToArray();
            return nodes.Length;
        }
    }
}

