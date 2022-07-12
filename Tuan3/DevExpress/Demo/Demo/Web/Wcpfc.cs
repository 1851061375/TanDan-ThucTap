using Demo.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class Wcpfc: BaseWeb
    {
        public Vessel getDataPerPage(string href)
        {
            var obj = new Vessel();
            HtmlDocument document = connectWeb(href);
            obj.Name = document.DocumentNode.SelectSingleNode("//h1[@id='page-title'][text()]").InnerText.Trim();
            HtmlNode leftNodes = document.DocumentNode.SelectSingleNode("//*[@class='group-left']");
            //obj.Owner = leftNodes.SelectSingleNode("//*[@class='field-label'][text()='Owner Name:&nbsp;']").NextSibling.InnerText;
            obj.Length = leftNodes.SelectSingleNode("//*[@class='field-label'][text()='Length:&nbsp;']").NextSibling.InnerText;
            obj.Beam = leftNodes.SelectSingleNode("//*[@class='field-label'][text()='Beam:&nbsp;']").NextSibling.InnerText;
            obj.DeadWeightTonnage = leftNodes.SelectSingleNode("//*[@class='field-label'][text()='Tonnage:&nbsp;']").NextSibling.InnerText;
            obj.RegPort = leftNodes.SelectSingleNode("//*[@class='field-label'][text()='Reg Port:&nbsp;']").NextSibling.InnerText;

            HtmlNode rightNodes = document.DocumentNode.SelectSingleNode("//*[@class='group-left']");
            var imoTemp = rightNodes.SelectSingleNode("//*[@class='field-label'][text()='IMO-LR:&nbsp;']").NextSibling.InnerText;
            if (!imoTemp.Contains("&nbsp;"))
                obj.IMOID = imoTemp;
            obj.Images = rightNodes.SelectSingleNode("//*[@class='field-label'][text()='Attachments:&nbsp;']").NextSibling.SelectSingleNode(".//img").GetAttributeValue("src", "");
            obj.VesselType = rightNodes.SelectSingleNode("//*[@class='field-label'][text()='Vessel Type:&nbsp;']").NextSibling.InnerText;
            obj.Flag = rightNodes.SelectSingleNode("//*[@class='field-label'][text()='Flag:&nbsp;']").NextSibling.InnerText;
            obj.RegistrationNumber = rightNodes.SelectSingleNode("//*[@class='field-label'][text()='Registration Number:&nbsp;']").NextSibling.InnerText;
            obj.Url = href;
            return obj;
        }
    }
}
