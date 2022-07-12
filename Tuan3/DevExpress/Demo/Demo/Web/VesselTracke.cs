using Demo.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class VesselTracke : BaseWeb
    {
        public Vessel getDataPerPage(string href)
        {
            Vessel vessel = new Vessel();
            HtmlDocument document = connectWeb(href);
            vessel.Url = href;
            //Lấy dữ liệu từng row gutter
            HtmlNode[] nodes = document.DocumentNode.SelectNodes(".//*[@class='row gutter']/*/h2").ToArray();
            vessel.Name = document.DocumentNode.SelectSingleNode(".//h1").InnerText;
            Thread t1 = new Thread(() =>
            {
                foreach (var item in nodes)
                {
                    if (item.InnerText == "General information")
                    {
                        // Chọn về row gutter để lấy image
                        vessel.Images = item.ParentNode.ParentNode.SelectSingleNode(".//*[@class='detail-image']/*/img").GetAttributeValue("src", "");
                        var generalNode = item.NextSibling;
                        var imoTemp = generalNode.SelectSingleNode(".//*[text()='IMO:']/following::span").InnerText;
                        vessel.IMOID = (!imoTemp.Contains("&nbsp;")) ? imoTemp : null;
                        vessel.MMSI = generalNode.SelectSingleNode(".//*[text()='MMSI:']").NextSibling.InnerText;
                        vessel.CallSign = generalNode.SelectSingleNode(".//*[text()='Callsign:']").NextSibling.InnerText;
                        vessel.Beam = generalNode.SelectSingleNode(".//*[text()='Width:']").NextSibling.InnerText;
                        vessel.Beam = getNumberFormString(vessel.Beam).ToString();
                        vessel.Length = generalNode.SelectSingleNode(".//*[text()='Length:']").NextSibling.InnerText;
                        vessel.Length = getNumberFormString(vessel.Length).ToString();
                        vessel.Flag = generalNode.SelectSingleNode(".//*[text()='Flag:']").NextSibling.InnerText;
                        vessel.VesselType = generalNode.SelectSingleNode(".//*[text()='AIS type:']").NextSibling.InnerText;
                    }
                }
            });
            t1.Start();
            Thread t2 = new Thread(() =>
            {
                // Node gốc không giống nhau hoàn toàn.
                HtmlNode[] nodesPort = document.DocumentNode.SelectNodes(".//*[@class='row gutter']/h2").ToArray();
                foreach (var item in nodesPort)
                {
                    if (item.InnerText == "Latest portsAll PORTS")
                    {
                        List<LatestPort> list = new List<LatestPort>();
                        var portNode = item.ParentNode.SelectSingleNode(".//*[@class='data-table']");
                        HtmlNode[] rows = portNode.ChildNodes.ToArray();
                        for (int i = 1; i < rows.Length - 1; i++)
                        {
                            LatestPort latestPort = new LatestPort();
                            latestPort.Port = rows[i].SelectSingleNode(".//div[2]").InnerText;
                            if (latestPort.Port != "")
                            {
                                latestPort.Flag = rows[i].SelectSingleNode(".//div[1]/div").GetAttributeValue("title", "");
                                latestPort.Arrival = rows[i].SelectSingleNode(".//div[3]").InnerText;
                                latestPort.Departure = rows[i].SelectSingleNode(".//div[4]").InnerText;
                                latestPort.Duration = rows[i].SelectSingleNode(".//div[5]").InnerText;
                                list.Add(latestPort);
                            }
                        }
                        vessel.LatestPort = Newtonsoft.Json.JsonConvert.SerializeObject(list).ToString();
                    }
                }
            });
            t2.Start();
            t2.Join();

            return vessel;
        }

    }
}
