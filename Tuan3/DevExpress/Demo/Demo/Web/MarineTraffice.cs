using Demo.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class MarineTraffice : BaseWeb
    {
        public MarineTraffice() { }

        public Vessel getDataPerPage(string href)
        {
            var obj = new Vessel();
            HtmlDocument document = connectWeb(href);

            HtmlNode table = document.DocumentNode.SelectSingleNode("//*[@class='vessels_table']/tbody");
            if (table != null)
            {
                obj.Name = table.SelectSingleNode(".//tr/td[text()='Name']/following::td").InnerText;
                var imoTemp = table.SelectSingleNode(".//tr/td[text()='IMO']/following::td").InnerText;
                obj.IMOID = (!imoTemp.Contains("---")) ? imoTemp : null;
                var mmsiTemp = table.SelectSingleNode(".//tr/td[text()='MMSI']/following::td").InnerText;
                obj.MMSI = (!mmsiTemp.Contains("---") ? mmsiTemp : null);
                var callTmp = table.SelectSingleNode(".//tr/td[text()='Call Sign']/following::td").InnerText;
                obj.CallSign = (!callTmp.Contains("---") ? callTmp : null);
                obj.VesselType = table.SelectSingleNode(".//tr/td[text()='Type']/following::td").InnerText;
                obj.Flag = table.SelectSingleNode(".//tr/td[text()='Flag']/following::td").InnerText;
                // Xử lý Length và Beam
                string[] arr = table.SelectSingleNode(".//tr/td[text()='Size']/following::td").InnerText.Split('x');
                if (arr.Length > 1)
                {
                    obj.Length = arr[0];
                    obj.Beam = getNumberFormString(arr[1]).ToString();
                }

                var div = document.DocumentNode.SelectSingleNode("//*[@id='vphoto']");
                obj.Images = Regex.Match(div.GetAttributeValue("style", ""), @"(?<=url\()(.*)(?=\))").Groups[1].Value;
                obj.Url = href;

                HtmlNode[] nodes = document.DocumentNode.SelectNodes("//*[@class='listbox_title']/h2").ToArray();
                foreach (var item in nodes)
                {
                    if (item.InnerText.Contains("Port Calls"))
                    {
                        //Dang loi cho nay(*)
                        List<LatestPort> list = new List<LatestPort>();
                        var contentNode = item.ParentNode.ParentNode.SelectSingleNode(".//*[@class='listbox_content']");
                        if (!contentNode.InnerText.Contains("No records found"))
                        {
                            HtmlNode portNode = contentNode.SelectSingleNode(".//table/tbody");
                            HtmlNode[] rows = portNode.ChildNodes.ToArray();
                            for (int i = 0; i < rows.Length; i++)
                            {
                                LatestPort latestPort = new LatestPort();
                                latestPort.Port = rows[i].SelectSingleNode(".//td/a").InnerText;
                                if (latestPort.Port != "")
                                {
                                    latestPort.Flag = rows[i].SelectSingleNode(".//td/img").GetAttributeValue("title", "");
                                    latestPort.Arrival = rows[i].SelectSingleNode(".//td/span").InnerText;
                                    latestPort.Departure = rows[i].SelectSingleNode(".//td/span").InnerText;
                                    latestPort.Duration = rows[i].SelectSingleNode(".//td[@class='hide500']").InnerText;
                                    list.Add(latestPort);
                                }
                            }
                            obj.LatestPort = Newtonsoft.Json.JsonConvert.SerializeObject(list).ToString();
                        }    
                    }
                }
            }
            return obj;
        }
    }
}
