using BussinessInfo.Dapper;
using BussinessInfo.Models;
using HtmlAgilityPack;
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
    public class ThongTinDoanhNghiepPage : DoanhNghiepRepos
    {
        public static string strInfo { get; set; }
        private static HtmlWeb web = new HtmlWeb();
        private static string urlNganhNghe = "https://thongtindoanhnghiep.co/api/industry";
        private static string urlDSCongTy = "https://thongtindoanhnghiep.co/api/company";// danh sách công ty lấy theo tham số i="ngành nghề" r="số lượng trên 1 trang max 100" p="số trang"
        private static string urlCTCongTy = "https://thongtindoanhnghiep.co/api/company";//chi tiết công ty theo mã số thuế: /mã số thuế
        //private static DMCoQuanRepos coQuanRepos = new DMCoQuanRepos();

        public static int TinhToanSoLuong(string param_nganhNghe, int param_tongTrang, int param_TongTrong1Trang, int param_tongSoCanLay)
        {
            int sum = 0;
            //Get json ngành nghề từ web
            //HttpClient client = new HttpClient();
            //ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            //HttpWebRequest request = GetRequest(urlNganhNghe);
            //WebResponse webResponse = request.GetResponse();
            //string json = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            string json = BaseAPI.GetReleases(urlNganhNghe);//Điệp edit

            List<ItemNganhNghe> itemsNganhNghe = GetNganhNgheFromJson(json);//get object ItemNganhNghe từ json
            List<string> lstMaSoThue = new List<string>();
            if (string.IsNullOrEmpty(param_nganhNghe))
                foreach (ItemNganhNghe itemNganhNghe in itemsNganhNghe)//xử lý doanh nghiệp trong từng ngành nghề
                {
                    string urlNN = itemNganhNghe.SolrID;
                    urlNN = urlNN.Split(new string[] { "/" }, StringSplitOptions.None)[urlNN.Split(new string[] { "/" }, StringSplitOptions.None).Length - 1];//  từ '/nganh-nghe/nong-nghiep-lam-nghiep-va-thuy-san' lấy 'nong-nghiep-lam-nghiep-va-thuy-san'
                    int tong1NganhNghe = itemNganhNghe.TotalDoanhNghiep;
                    int sotrang = tong1NganhNghe / param_TongTrong1Trang;
                    if (param_tongTrang < sotrang)
                    {
                        sum += param_tongTrang * param_TongTrong1Trang;
                        sotrang = param_tongTrang;
                    }
                    else
                        sum += tong1NganhNghe;
                    if (sum >= param_tongSoCanLay)
                    {
                        break;
                    }
                }
            else
            {
                var node = itemsNganhNghe.Where(x => !string.IsNullOrEmpty(x.Title) && x.Title == param_nganhNghe);
                if (node.Any())
                {
                    ItemNganhNghe itemNganhNghe = node.FirstOrDefault();
                    string urlNN = itemNganhNghe.SolrID;
                    urlNN = urlNN.Split(new string[] { "/" }, StringSplitOptions.None)[urlNN.Split(new string[] { "/" }, StringSplitOptions.None).Length - 1];//  từ '/nganh-nghe/nong-nghiep-lam-nghiep-va-thuy-san' lấy 'nong-nghiep-lam-nghiep-va-thuy-san'
                    int tong1NganhNghe = itemNganhNghe.TotalDoanhNghiep;
                    int sotrang = tong1NganhNghe / param_TongTrong1Trang;
                    if (param_tongTrang < sotrang)
                    {
                        sum = param_tongTrang * param_TongTrong1Trang;
                        sotrang = param_tongTrang;
                    }
                    else
                        sum = tong1NganhNghe;
                }
            }
            return sum;
        }


        public static List<DoanhNghiep> GetBussiness(string param_nganhNghe, int param_tongTrang, int param_TongTrong1Trang, int param_tongSoCanLay)
        {
            frmMain frmMain = new frmMain();
            int count = 0;
            List<DoanhNghiep> result = new List<DoanhNghiep>();
            //    int sum = 0;
            //    //Get json ngành nghề từ web
            //    //HttpClient client = new HttpClient();
            //    //ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            //    //HttpWebRequest request = GetRequest(urlNganhNghe);
            //    //WebResponse webResponse = request.GetResponse();
            //    //string json = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
                //string json = GetDataJson(urlNganhNghe);//Điệp edit

            //    List<ItemNganhNghe> itemsNganhNghe = GetNganhNgheFromJson(json);//get object ItemNganhNghe từ json
            //    List<string> lstMaSoThue = new List<string>();
            //    if (string.IsNullOrEmpty(param_nganhNghe))
            //    {
            //        foreach (ItemNganhNghe itemNganhNghe in itemsNganhNghe)//xử lý doanh nghiệp trong từng ngành nghề
            //        {
            //            string urlNN = itemNganhNghe.SolrID;
            //            urlNN = urlNN.Split(new string[] { "/" }, StringSplitOptions.None)[urlNN.Split(new string[] { "/" }, StringSplitOptions.None).Length - 1];//  từ '/nganh-nghe/nong-nghiep-lam-nghiep-va-thuy-san' lấy 'nong-nghiep-lam-nghiep-va-thuy-san'
            //            int tong1NganhNghe = itemNganhNghe.TotalDoanhNghiep;
            //            int sotrang = tong1NganhNghe / param_TongTrong1Trang;
            //            if (param_tongTrang < sotrang)
            //            {
            //                sum += param_tongTrang * param_TongTrong1Trang;
            //                sotrang = param_tongTrang;
            //            }
            //            else
            //                sum += tong1NganhNghe;
            //            for (int i = 1; i < (sotrang + 1); i++)
            //            {
            //                string urlDS = urlDSCongTy + "?i=" + urlNN + "&r=" + param_TongTrong1Trang + "&p=" + i;
            //                HttpWebRequest rq = GetRequest(urlDS);
            //                WebResponse wR = rq.GetResponse();
            //                string js = new StreamReader(wR.GetResponseStream()).ReadToEnd();
            //                lstMaSoThue = GetListMaSoThueFromJson(js, lstMaSoThue);
            //                foreach (string mst in lstMaSoThue)
            //                {
            //                    string urlDN = urlCTCongTy + "/" + mst;
            //                    //rq = GetRequest(urlDN);
            //                    //wR = rq.GetResponse();
            //                    //string jsDN = new StreamReader(wR.GetResponseStream()).ReadToEnd();
            //                    string jsDN = GetDataJson(urlDN);
            //                    DoanhNghiep dn = SyncBussinessByJson(jsDN, itemsNganhNghe);
            //                    result.Add(dn);
            //                }
            //            }
            //            if (sum >= param_tongSoCanLay)
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        var node = itemsNganhNghe.Where(x => !string.IsNullOrEmpty(x.Title) && x.Title == param_nganhNghe);
            //        if (node.Any())
            //        {
            //            ItemNganhNghe itemNganhNghe = node.FirstOrDefault();
            //            string urlNN = itemNganhNghe.SolrID;
            //            urlNN = urlNN.Split(new string[] { "/" }, StringSplitOptions.None)[urlNN.Split(new string[] { "/" }, StringSplitOptions.None).Length - 1];//  từ '/nganh-nghe/nong-nghiep-lam-nghiep-va-thuy-san' lấy 'nong-nghiep-lam-nghiep-va-thuy-san'
            //            int tong1NganhNghe = itemNganhNghe.TotalDoanhNghiep;
            //            int sotrang = tong1NganhNghe / param_TongTrong1Trang;
            //            if (param_tongTrang < sotrang)
            //            {
            //                sum = param_tongTrang * param_TongTrong1Trang;
            //                sotrang = param_tongTrang;
            //            }
            //            else
            //                sum = tong1NganhNghe;
            //            for (int i = 1; i < (sotrang + 1); i++)
            //            {
            //                string urlDS = urlDSCongTy + "?i=" + urlNN + "&r=" + param_TongTrong1Trang + "&p=" + i;
            //                //HttpWebRequest rq = GetRequest(urlDS);
            //                //WebResponse wR = rq.GetResponse();
            //                //string js = new StreamReader(wR.GetResponseStream()).ReadToEnd();
            //                string js = GetDataJson(urlDS);
            //                lstMaSoThue = GetListMaSoThueFromJson(js, lstMaSoThue);
            //                foreach (string mst in lstMaSoThue)
            //                {
            //                    string urlDN = urlCTCongTy + "/" + mst;
            //                    //rq = GetRequest(urlDN);
            //                    //wR = rq.GetResponse();
            //                    //string jsDN = new StreamReader(wR.GetResponseStream()).ReadToEnd();
            //                    string jsDN = GetDataJson(urlDN);
            //                    DoanhNghiep dn = SyncBussinessByJson(jsDN, itemsNganhNghe);
            //                    result.Add(dn);
            //                }
            //            }
            //        }
            //    }
                return result;
            }

            private static List<ItemNganhNghe> GetNganhNgheFromJson(string json)
            {
                List<ItemNganhNghe> items = new List<ItemNganhNghe>();
            //    ItemNganhNghe it = new ItemNganhNghe();
            //    Dictionary<string, object> obj = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(json);
            //    Object[] itemsNN = (Object[])obj["LtsItem"];
            //    foreach (var item in itemsNN)
            //    {
            //        it = new ItemNganhNghe();
            //        Dictionary<string, object> d = (Dictionary<string, object>)item;
            //        it.Type = int.Parse("0" + d["Type"]);
            //        it.SolrID = d["SolrID"] + "";
            //        it.ID = int.Parse("0" + d["ID"]);
            //        it.Title = d["Title"] + "";
            //        it.TitleAscii = d["TitleAscii"] + "";
            //        it.Lv1 = d["Lv1"] + "";
            //        it.Lv2 = d["Lv2"] + "";
            //        it.Lv3 = d["Lv3"] + "";
            //        it.Lv4 = d["Lv4"] + "";
            //        it.Lv5 = d["Lv5"] + "";
            //        it.Created = d["Created"] + "";
            //        it.Updated = d["Updated"] + "";
            //        it.TotalDoanhNghiep = int.Parse("0" + d["TotalDoanhNghiep"]);
            //        items.Add(it);
            //    }
                return items;
            }
            private static List<string> GetListMaSoThueFromJson(string json, List<string> lstMaSoThue)
            {
            //    Dictionary<string, object> obj = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(json);
            //    Object[] itemsDN = (Object[])obj["LtsItems"];
            //    foreach (var item in itemsDN)
            //    {
            //        Dictionary<string, object> d = (Dictionary<string, object>)item;
            //        string mst = d["MaSoThue"] + "";
            //        if (!lstMaSoThue.Contains(mst))
            //        {
            //            //string text = File.ReadAllText(@"C:\Users\nguye\OneDrive\Desktop\id.txt");
            //            //File.WriteAllText(@"C:\Users\nguye\OneDrive\Desktop\id.txt", text + "#" + mst);
            //            lstMaSoThue.Add(mst);
            //        }

            //    }
                return lstMaSoThue;
            }
            private static DoanhNghiep SyncBussinessByJson(string json,List<ItemNganhNghe> itemsNganhNghe)
            {
                DoanhNghiep dn = new DoanhNghiep();
            //    string mst = string.Empty;
            //    try
            //    {
            //        Dictionary<string, object> d = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(json);
            //        mst = d["MaSoThue"] + "";
            //        string ten = d["Title"] + "";
            //        if (!string.IsNullOrEmpty(mst))
            //        {
            //            dn = new DoanhNghiepRepos().Find(mst);
            //        }
            //        if (dn == null)
            //        {
            //            dn = new DoanhNghiepRepos().Add(new DoanhNghiep() { MaSoThue = mst, IsDelete = false, Ten = ten });
            //        }
            //        int idDN = dn.Id;

            //        dn.CapChuongLoaiKhoan = d["CapChuongLoaiKhoan"] + "";
            //        dn.ChuSoHuu = d["ChuSoHuu"] + "";
            //        dn.ChuSoHuu_DiaChi = d["ChuSoHuu_DiaChi"] + "";
            //        dn.DiaChi = d["DiaChiCongTy"] + "";
            //        dn.DiaChiGiamDoc = d["GiamDoc_DiaChi"] + "";
            //        dn.DiaChiKeToanTruong = d["KeToanTruong_DiaChi"] + "";
            //        dn.DiaChiNhanThongBaoThue = d["DiaChiNhanThongBaoThue"] + "";
            //        dn.Email = "";
            //        dn.EmailGiamDoc = "";
            //        dn.EmailKeToanTruong = "";
            //        dn.Fax = "";
            //        dn.GiamDoc = d["GiamDoc"] + "";
            //        dn.GiayPhepKinhDoanh = d["GiayPhepKinhDoanh"] + "";
            //        dn.GiayPhepKinhDoanh_CoQuanCapId = DN_GetIDCoQuan(d["GiayPhepKinhDoanh_CoQuanCapTitle"] + "", null, null);
            //        try
            //        {
            //            dn.GiayPhepKinhDoanh_NgayCap = Convert.ToDateTime(d["GiayPhepKinhDoanh_NgayCap"] + "");
            //        }
            //        catch { }
            //        dn.HinhThucThanhToan = d["HinhThucThanhToan"] + ""; try
            //        {
            //            dn.IsDelete = Convert.ToBoolean(d["IsDelete"] + "");
            //        }
            //        catch { }
            //        dn.KeToanTruong = d["KeToanTruong"] + "";
            //        dn.MaSoThue = mst;
            //        try
            //        {
            //            dn.NamTaiChinh = Convert.ToDateTime(d["NamTaiChinh"] + "");
            //        }
            //        catch { }
            //        int nncID = int.Parse("0" + (d["NganhNgheID"] + ""));
            //        string nncTitle = d["NganhNgheTitle"] + "";
            //        try
            //        {
            //            string fullCode = d["Lv1"] + "";
            //            string parentCode = d["Lv1"] + "";
            //            string code = d["Lv1"] + "";
            //            if (!string.IsNullOrEmpty(d["Lv2"] + ""))
            //            {
            //                code = d["Lv2"] + "";
            //                fullCode += "." + code;
            //                parentCode = d["Lv1"] + "";
            //            }
            //            if (!string.IsNullOrEmpty(d["Lv3"] + ""))
            //            {
            //                code = d["Lv3"] + "";
            //                fullCode += "." + code;
            //                parentCode = d["Lv2"] + "";
            //            }
            //            if (!string.IsNullOrEmpty(d["Lv4"] + ""))
            //            {
            //                code = d["Lv4"] + "";
            //                fullCode += "." + code;
            //                parentCode = d["Lv3"] + "";
            //            }
            //            if (!string.IsNullOrEmpty(d["Lv5"] + ""))
            //            {
            //                code = d["Lv5"] + "";
            //                fullCode += "." + code;
            //                parentCode = d["Lv4"] + "";
            //            }
            //            dn.NganhNgheKinhDoanhChinhId = DN_GetIDNganhNghe(nncTitle, code, fullCode, parentCode);
            //        }
            //        catch { }
            //        try
            //        {
            //            dn.NgayBatDauHopDong = Convert.ToDateTime(d["NgayBatDauHopDong"] + "");
            //        }
            //        catch { }
            //        try
            //        {
            //            dn.NgayCapMST = Convert.ToDateTime(d["NgayCap"] + "");
            //        }
            //        catch { }
            //        try
            //        {
            //            dn.NgayDongMST = Convert.ToDateTime(d["NgayDongMST"] + "");
            //        }
            //        catch { }
            //        try
            //        {
            //            dn.NgayNhanToKhai = Convert.ToDateTime(d["NgayNhanToKhai"] + "");
            //        }
            //        catch { }
            //        dn.NoiDangKyQuanLyId = DN_GetIDCoQuan(d["NoiDangKyQuanLy_CoQuanTitle"] + "", null, null);
            //        dn.NoiNopThueID = DN_GetIDCoQuan(d["NoiNopThue_CoQuanTitle"] + "", d["NoiNopThue_DienThoai"] + "", d["NoiNopThue_Fax"] + "");
            //        dn.PhuongPhapTinhThueGTGT = d["PhuongPhapTinhThueGTGT"] + "";
            //        dn.PhuongXaId = DN_GetIDPhuongXa(d["PhuongXaTitle"] + "");
            //        dn.QuanHuyenId = DN_GetIDQuanHuyen(d["QuanHuyenTitle"] + "");
            //        dn.SDTGiamDoc = "";
            //        dn.SDTKeToanTruong = "";
            //        dn.SoDienThoai = "";
            //        dn.TenEn = d["TitleEn"] + "";
            //        dn.TinhThanhId = DN_GetIDTinhThanh(d["TinhThanhTitle"] + "");
            //        dn.TongSoLaoDong = d["TongSoLaoDong"] == null ? intNull : Convert.ToInt32(d["TongSoLaoDong"] + "");
            //        dn.TrangThai = "";
            //        dn.TrangThaiText = "";
            //        dn.VonDieuLe = d["VonDieuLe"] + "";
            //        dn.Web = "";
            //        //
            //        Object[] dntt = (Object[])d["LtsDoanhNghiepTrucThuoc"];
            //        if (dntt.Count() > 0)
            //        {
            //            foreach (var item in dntt)
            //            {
            //                Dictionary<string, object> _d = (Dictionary<string, object>)item;
            //                if (string.IsNullOrEmpty(_d["MaSoThue"] + ""))
            //                    continue;
            //                else
            //                {
            //                    DoanhNghiep _dntt = new DoanhNghiep();
            //                    string mast = _d["MaSoThue"] + "";
            //                    string qh = _d["QuanHe"] + "";
            //                    if (string.IsNullOrEmpty(mast))
            //                    {
            //                        _dntt = new DoanhNghiepRepos().Find(mst);
            //                    }
            //                    if (dn == null)
            //                    {
            //                        _dntt = new DoanhNghiepRepos().Add(new DoanhNghiep() { MaSoThue = mst, IsDelete = false });
            //                    }
            //                    if (_dntt != null)
                                  //DN_GetDNDoanhNghiepTrucThuoc(idDN, _dntt.Id, qh);
            //                }
            //            }
            //        }
            //        Object[] nnkd = (Object[])d["DSNganhNgheKinhDoanhID"];
            //        if (nnkd.Count() > 0)
            //        {
            //            foreach (Object obj in nnkd)
            //            {
            //                try
            //                {
            //                    int idnn = int.Parse(obj.ToString());
            //                    ItemNganhNghe nn = itemsNganhNghe.Where(x => x.ID == idnn).FirstOrDefault();
            //                    if (nn != null)
            //                    {
            //                        string fullCode = nn.Lv1;
            //                        string parentCode = nn.Lv1;
            //                        string code = nn.Lv1;
            //                        if (!string.IsNullOrEmpty(nn.Lv2))
            //                        {
            //                            code = nn.Lv2;
            //                            fullCode += "." + code;
            //                            parentCode = nn.Lv1;
            //                        }
            //                        if (!string.IsNullOrEmpty(nn.Lv3))
            //                        {
            //                            code = nn.Lv3;
            //                            fullCode += "." + code;
            //                            parentCode = nn.Lv2;
            //                        }
            //                        if (!string.IsNullOrEmpty(nn.Lv4))
            //                        {
            //                            code = nn.Lv4;
            //                            fullCode += "." + code;
            //                            parentCode = nn.Lv3;
            //                        }
            //                        if (!string.IsNullOrEmpty(nn.Lv5))
            //                        {
            //                            code = nn.Lv5;
            //                            fullCode += "." + code;
            //                            parentCode = nn.Lv4;
            //                        }
            //                        int? nnID = DN_GetIDNganhNghe(nn.Title, code, fullCode, parentCode);
            //                        if (nnID.HasValue)
            //                            DN_SetNNDoanhNghiep(idDN, nnID.Value, fullCode);
            //                    }
            //                }
            //                catch { }
            //            }
            //        }
            //        Object[] nh = (Object[])d["DSNganHang"];
            //        if (nh.Count() > 0)
            //        {
            //            foreach (Object obj in nh)
            //            {
            //                string txt = obj.ToString();
            //                new DMNganHangRepos().Add(new DMNganHang() { Ten = txt });
            //            }
            //        }
            //        Object[] tpn = (Object[])d["DSThuePhaiNop"];
            //        if (tpn.Count() > 0)
            //        {
            //            foreach (Object obj in tpn)
            //            {
            //                string thue = obj.ToString();
            //                DMThuePhaiNop dmThue = new DMThuePhaiNop();
            //                string[] thues = thue.Split(new string[] { "|" }, StringSplitOptions.None);
            //                thue = thues[thues.Length - 1].Trim();
            //                if (!string.IsNullOrEmpty(thue))
            //                    dmThue = new DMThuePhaiNopRepos().Find(thue);
            //                if (dmThue == null)
            //                {
            //                    dmThue = new DMThuePhaiNopRepos().Add(new DMThuePhaiNop() { Ten = thue });
            //                }
            //                if (dmThue != null)
            //                    DN_GetDNThuePhaiNop(idDN, dmThue.Id);
            //            }
            //        }
            //        //object sp = d["DSSanPham"];
            //        new DoanhNghiepRepos().Update(dn);

            //    }
            //    catch (Exception ex)
            //    {
            //        string text = File.ReadAllText(@"C:\Users\nguye\OneDrive\Desktop\id.txt");
            //        File.WriteAllText(@"C:\Users\nguye\OneDrive\Desktop\id.txt", text + "#" + mst);
            //    }
                return dn;
        }

    }

    #region entities
    public class ItemDoanhNghiep
    {
        public int Type { get; set; }
        public string SolrID { get; set; }
        public int ID { get; set; }
        public string MaSoThue { get; set; }
        public string NgayCap { get; set; }
        public string NgayDongMST { get; set; }
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string TitleEnAscii { get; set; }
        public string DiaChiCongTy { get; set; }
        public string DiaChiNhanThongBaoThue { get; set; }
        public string NamTaiChinh { get; set; }
        public string MaSoHienThoi { get; set; }
        public string NgayNhanToKhai { get; set; }
        public string NgayBatDauHopDong { get; set; }
        public string VonDieuLe { get; set; }
        public int TongSoLaoDong { get; set; }
        public string CapChuongLoaiKhoan { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string PhuongPhapTinhThueGTGT { get; set; }
        public string ChuSoHuu { get; set; }
        public string ChuSoHuu_DiaChi { get; set; }
        public string GiamDoc { get; set; }
        public string GiamDoc_DiaChi { get; set; }
        public string KeToanTruong { get; set; }
        public string KeToanTruong_DiaChi { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public bool IsDelete { get; set; }
        public bool RequestChanged { get; set; }
        public bool ExitsInGDT { get; set; }
        public int SourceID { get; set; }
        public int TinhThanhID { get; set; }
        public string TinhThanhTitle { get; set; }
        public string TinhThanhTitleAscii { get; set; }
        public int QuanHuyenID { get; set; }
        public string QuanHuyenTitle { get; set; }
        public string QuanHuyenTitleAscii { get; set; }
        public int PhuongXaID { get; set; }
        public string PhuongXaTitle { get; set; }
        public string PhuongXaTitleAscii { get; set; }
        public int NoiDangKyQuanLyID { get; set; }
        public string NoiDangKyQuanLy_CoQuanTitle { get; set; }
        public int NoiDangKyQuanLy_CoQuanTitleAscii { get; set; }
        public string NoiDangKyQuanLy_DienThoai { get; set; }
        public string NoiDangKyQuanLy_Fax { get; set; }
        public int NoiNopThueID { get; set; }
        public string NoiNopThue_DienThoai { get; set; }
        public string NoiNopThue_Fax { get; set; }
        public string NoiNopThue_CoQuanTitle { get; set; }
        public string NoiNopThue_CoQuanTitleAscii { get; set; }
        public string QuyetDinhThanhLap { get; set; }
        public string QuyetDinhThanhLap_NgayCap { get; set; }
        public int QuyetDinhThanhLap_CoQuanCapID { get; set; }
        public string QuyetDinhThanhLap_CoQuanCapTitle { get; set; }
        public string QuyetDinhThanhLap_CoQuanCapTitleAscii { get; set; }
        public int GiayPhepKinhDoanh_CoQuanCapID { get; set; }
        public string GiayPhepKinhDoanh_CoQuanCapTitle { get; set; }
        public string GiayPhepKinhDoanh_CoQuanCapTitleAscii { get; set; }
        public string GiayPhepKinhDoanh { get; set; }
        public string GiayPhepKinhDoanh_NgayCap { get; set; }
        public int LoaiHinhID { get; set; }
        public string LoaiHinhTitle { get; set; }
        public string LoaiHinhTitleAscii { get; set; }
        public int NganhNgheID { get; set; }
        public string NganhNgheTitle { get; set; }
        public string NganhNgheTitleAscii { get; set; }
        public string[] DSNganhNgheKinhDoanh { get; set; }
        public int[] DSNganhNgheKinhDoanhID { get; set; }
        public string[] DSMaNganhNgheKinhDoanh { get; set; }
        public string Lv1 { get; set; }
        public string Lv2 { get; set; }
        public string Lv3 { get; set; }
        public string Lv4 { get; set; }
        public string Lv5 { get; set; }
        public string[] DSNganHang { get; set; }
        public int[] DSNganHangID { get; set; }
        public string[] DSThuePhaiNop { get; set; }
        public int[] DSThuePhaiNopID { get; set; }
        public LtsDoanhNghiepTrucThuoc[] LtsDoanhNghiepTrucThuoc { get; set; }
        public string[] DSTags { get; set; }
    }
    public class ItemNganhNghe
    {
        public int Type { get; set; }
        public string SolrID { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string TitleAscii { get; set; }
        public string Lv1 { get; set; }
        public string Lv2 { get; set; }
        public string Lv3 { get; set; }
        public string Lv4 { get; set; }
        public string Lv5 { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public int TotalDoanhNghiep { get; set; }
        public ItemNganhNghe() { }
    }
    public class LtsDoanhNghiepTrucThuoc
    {
        public int Type { get; set; }
        public int QuanHe { get; set; }
        public string SolrID { get; set; }
        public int ID { get; set; }
        public string MaSoThue { get; set; }
        public string Title { get; set; }
        public string DiaChi { get; set; }
        public int DoanhNghiepID { get; set; }
        public string DoanhNghiepTitle { get; set; }
        public string DoanhNghiepMaSoThue { get; set; }
        public string DoanhNghiepTitleAscii { get; set; }
        public LtsDoanhNghiepTrucThuoc() { }
    }
    public class ObjFromJson
    {
        public string HtmlPage { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string SolrID { get; set; }
        public object Option { get; set; }
        public object[] LtsMaps { get; set; }
        public string TitleFacet { get; set; }
        public object[] LtsFacets { get; set; }
        public string LtsFacetOption { get; set; }
        public object[] LtsFacetNganhNgheKinhDoanh { get; set; }
        public List<DoanhNghiep> LtsItems { get; set; }
        public ObjFromJson() { }
    }

    #endregion entities
}
