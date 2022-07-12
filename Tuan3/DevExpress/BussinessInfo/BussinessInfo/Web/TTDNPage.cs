using BussinessInfo.Dapper;
using BussinessInfo.Models;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BussinessInfo
{
    public class TTDNPage : DoanhNghiepRepos
    {
        private static HtmlWeb web = new HtmlWeb();
        private static string urlNganhNghe = "https://thongtindoanhnghiep.co/api/industry";
        private static string urlDSCongTy = "https://thongtindoanhnghiep.co/api/company";// danh sách công ty lấy theo tham số i="ngành nghề" r="số lượng trên 1 trang max 100" p="số trang"
        private static string urlChiTietCongTy = "https://thongtindoanhnghiep.co/api/company/";//chi tiết công ty theo mã số thuế: /mã số thuế

        #region Đồng bộ dữ liệu


        public static void DongBoDiaBan()
        {
            string jsonTinh = BaseAPI.GetReleases("https://thongtindoanhnghiep.co/api/city");
            DMDiaBanRepos diaBanRepos = new DMDiaBanRepos();
            ResultDiaBan lstTinh = JsonConvert.DeserializeObject<ResultDiaBan>(jsonTinh);
            for (int i = 0, lengthT = lstTinh.LtsItem.Count; i < lengthT; i++)
            {
                DMDiaBan tinh = lstTinh.LtsItem[i];
                tinh.Created = DateTime.Now;
                diaBanRepos.Add(tinh);
                string jsonHuyen = BaseAPI.GetReleases("https://thongtindoanhnghiep.co/api/city/" + tinh.ID + "/district");
                List<DMDiaBan> lstHuyen = JsonConvert.DeserializeObject<List<DMDiaBan>>(jsonHuyen);
                for (int j = 0, lengthH = lstHuyen.Count; j < lengthH; j++)
                {
                    DMDiaBan huyen = lstHuyen[j];
                    huyen.TinhThanhID = tinh.ID;
                    huyen.TinhThanhTitle = tinh.Title;
                    huyen.TinhThanhTitleAscii = tinh.SolrID;
                    huyen.Created = DateTime.Now;
                    diaBanRepos.Add(lstHuyen[j]);
                    string jsonXa = BaseAPI.GetReleases("https://thongtindoanhnghiep.co/api/district/" + lstHuyen[j].ID + "/ward");
                    List<DMDiaBan> lstXa = JsonConvert.DeserializeObject<List<DMDiaBan>>(jsonXa);
                    for (int k = 0, lengthX = lstXa.Count; k < lengthX; k++)
                    {
                        DMDiaBan xa = lstXa[k];
                        xa.TinhThanhID = tinh.ID;
                        xa.TinhThanhTitle = tinh.Title;
                        xa.TinhThanhTitleAscii = tinh.SolrID;

                        xa.QuanHuyenID = huyen.ID;
                        xa.QuanHuyenTitle = huyen.Title;
                        xa.QuanHuyenTitleAscii = huyen.SolrID;
                        xa.Created = DateTime.Now;
                        diaBanRepos.Add(lstXa[k]);
                    }
                }
            }
        }
        public List<DoanhNghiep> GetListDoanhNghiepFormMaSoThue(List<string> lstMaSoThue, frmMain frmMain)
        {
            List<DoanhNghiep> lstDoanhNghiep = new List<DoanhNghiep>();
            foreach (string maSoThue in lstMaSoThue)
            {
                try
                {
                    string json = BaseAPI.GetReleases(urlChiTietCongTy + maSoThue);
                    DoanhNghiep itemDoanhNghiep = JsonConvert.DeserializeObject<DoanhNghiep>(json);
                    lstDoanhNghiep.Add(itemDoanhNghiep);
                    frmMain.indexGet++;
                }
                catch (Exception ex)
                {

                }
            }
            return lstDoanhNghiep;
        }
        public static void DongBoNganhNghe()
        {
            string jsonTinh = BaseAPI.GetReleases("https://thongtindoanhnghiep.co/api/industry");
            DMNganhNgheRepos nganhNgheRepos = new DMNganhNgheRepos();
            ResultNganhNghe lstNganhNghe = JsonConvert.DeserializeObject<ResultNganhNghe>(jsonTinh);
            for (int i = 0, length = lstNganhNghe.LtsItem.Count; i < length; i++)
            {
                DMNganhNghe nganhNghe = lstNganhNghe.LtsItem[i];
                nganhNghe.Created = DateTime.Now;
                nganhNgheRepos.Add(nganhNghe);
            }
        }
        #endregion
    }

    public class ResultNganhNghe
    {
        public List<DMNganhNghe> LtsItem { get; set; }
        public int TotalDoanhNghiep { get; set; }
        public int TotalItem { get; set; }
    }
    public class ResultDiaBan
    {
        public List<DMDiaBan> LtsItem { get; set; }
        public int TotalDoanhNghiep { get; set; }
        public int TotalItem { get; set; }
    }
}
