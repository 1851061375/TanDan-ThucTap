using BussinessInfo.Dapper;
using BussinessInfo.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessInfo
{
    public class YellowPages: DoanhNghiepRepos
    {
        private static HtmlWeb web = new HtmlWeb();
        public static List<DoanhNghiep> GetAllBussiness(string url)
        {
            List<DoanhNghiep> result = new List<DoanhNghiep>();
            var htmlDoc = web.Load(url);

            //Tìm xem có bao nhiêu trang dữ liệu
            HtmlNode nodePaging = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='paging']/a[last()-1]");
            int pageLength = int.Parse(nodePaging.InnerText);//int.Parse(nodePaging[nodePaging.Count - 2].InnerText);

            //Lấy dữ liệu từng trang
            for (int i = 0; i < pageLength; i++)
            {
                htmlDoc = web.Load(url + "?page=" + (i + 1));

                HtmlNodeCollection nodesBussiness = htmlDoc.DocumentNode.SelectNodes("//*[@class='listing_box']");
                for (int j = 0, n = nodesBussiness.Count; j < n; j++)
                {
                    DoanhNghiep obj = new DoanhNghiep();
                    //Xử lý tiếp: Đọc chi tiết của page để đổ dữ liệu vào Bussiness


                    result.Add(obj);

                }
            }

            return result;
        }
    }
}
