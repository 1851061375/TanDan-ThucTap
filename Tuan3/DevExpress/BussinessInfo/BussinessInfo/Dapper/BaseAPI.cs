using BussinessInfo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace BussinessInfo.Dapper
{
    public class BaseAPI
    {
        public IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);


        public static void SendMail(string subject, string body)
        {
            MailMessage msg = new MailMessage();
            msg.IsBodyHtml = true;
            msg.Subject = subject;
            msg.From = new MailAddress("yaiba2017@gmail.com");
            msg.Body = body;

            msg.To.Add(new MailAddress("doninhtatdiepnd@gmail.com"));
            msg.To.Add(new MailAddress("nguyenthanhhai18101995@gmail.com"));
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            NetworkCredential nc = new NetworkCredential("yaiba2017@gmail.com", "Tandan@123");
            smtp.Credentials = nc;
            ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate,
                     X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
            smtp.Send(msg);
        }

        public static bool IsNumber(string strNumber)
        {
            int n;
            return int.TryParse(strNumber, out n);
        }
        public static string CreateCode(int maxLength)
        {
            string result = "";
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            result = String.Format("{0:x}", i - DateTime.Now.Ticks);
            if (maxLength > result.Length) maxLength = result.Length;
            result = result.Substring(0, maxLength).ToUpper();
            return result;
        }
        public static int? DN_GetIDCoQuan(string tencq, string dienthoai, string fax)
        {
            if (!string.IsNullOrEmpty(tencq))
            {
                tencq = tencq.Trim();
                DMCoQuan cq = new DMCoQuanRepos().Find(tencq);
                if (cq == null)
                {
                    cq = new DMCoQuanRepos().Add(new DMCoQuan()
                    {
                        Ma = CreateCode(16),
                        Ten = tencq,
                        DienThoai = dienthoai,
                        Fax = fax
                    });
                }
                return cq.Id;
            }
            return null;
        }
        #region get tỉnh thành quận huyện cũ
        //public static int? DN_GetIDTinhThanh(string ten)
        //{
        //    if (!string.IsNullOrEmpty(ten))
        //    {
        //        ten = ten.Trim();
        //        try
        //        {

        //            DMTinhThanh dm = new DMTinhThanhRepos().Find(ten);
        //            if (dm == null)
        //            {
        //                dm = new DMTinhThanhRepos().Add(new DMTinhThanh()
        //                {
        //                    Ma = CreateCode(16),
        //                    Ten = ten
        //                });
        //            }
        //            return dm.Id;
        //        }
        //        catch (Exception ex) { }
        //    }
        //    return null;
        //}
        //public static int? DN_GetIDQuanHuyen(string ten)
        //{
        //    if (!string.IsNullOrEmpty(ten))
        //    {
        //        ten = ten.Trim();
        //        try
        //        {

        //            DMQuanHuyen dm = new DMQuanHuyenRepos().Find(ten);
        //            if (dm == null)
        //            {
        //                dm = new DMQuanHuyenRepos().Add(new DMQuanHuyen()
        //                {
        //                    Ma = CreateCode(16),
        //                    Ten = ten
        //                });
        //            }
        //            return dm.Id;
        //        }
        //        catch { }
        //    }
        //    return null;
        //}
        //public static int? DN_GetIDPhuongXa(string ten)
        //{
        //    if (!string.IsNullOrEmpty(ten))
        //    {
        //        ten = ten.Trim();
        //        try
        //        {

        //            DMPhuongXa dm = new DMPhuongXaRepos().Find(ten);
        //            if (dm == null)
        //            {
        //                dm = new DMPhuongXaRepos().Add(new DMPhuongXa()
        //                {
        //                    Ma = CreateCode(16),
        //                    Ten = ten
        //                });
        //            }
        //            return dm.Id;
        //        }
        //        catch { }
        //    }
        //    return null;
        //}
        #endregion
        public static void DN_UpDNDoanhNghiepTrucThuoc(int? dnID, int? dnttID, string qh)
        {
            if (dnID.HasValue && dnttID.HasValue && !string.IsNullOrEmpty(qh))
            {
                DNDoanhNghiepTrucThuocRepos dnTTRepos = new DNDoanhNghiepTrucThuocRepos();
                qh = qh.Trim();
                switch (qh)
                {
                    case "4":
                        qh = "Văn phòng đại diện";
                        break;
                    case "3":
                        qh = "Đơn vị trực thuộc";
                        break;
                    case "2":
                        qh = "Đơn vị thành viên";
                        break;
                    case "1":
                        qh = "Đơn vị chủ quản";
                        break;
                    default:
                        break;
                }
                DNDoanhNghiepTrucThuoc dntt = dnTTRepos.Find(dnID, dnttID, qh);
                if (dntt == null || dntt.Id == 0)
                {
                    dntt = dnTTRepos.Add(new DNDoanhNghiepTrucThuoc() { DoanhNghiepId = dnID.Value, DoanhNghiepTrucThuocId = dnttID.Value, QuanHe = qh });
                }
            }
        }
        public static void DN_GetDNThuePhaiNop(int? dnID, int? thueID)
        {
            if (dnID.HasValue && thueID.HasValue)
            {
                DNThuePhaiNopRepos dnThueRepos = new DNThuePhaiNopRepos();
                DNThuePhaiNop dntpn = dnThueRepos.Find(dnID, thueID);
                if (dntpn == null || dntpn.Id == 0)
                {
                    dntpn = dnThueRepos.Add(new DNThuePhaiNop() { DoanhNghiepId = dnID.Value, ThuePhaiNopId = thueID.Value });
                }
            }
        }
        public static int? DN_GetIDNganhNghe(string ten, string code, string fullCode, string parentCode)
        {
            if (!string.IsNullOrEmpty(ten))
            {
                DMNganhNgheRepos dmNNRepos = new DMNganhNgheRepos();
                ten = ten.Trim();
                DMNganhNghe dm = dmNNRepos.Find(ten);
                if (dm == null || dm.ID == 0)
                {
                    dm = dmNNRepos.Add(new DMNganhNghe()
                    {
                        //Ma = code,
                        //Ten = ten,
                        //MaDayDu = fullCode,
                        //MaCha = parentCode
                    });
                }
                return dm.ID;
            }
            return null;
        }
        public static void DN_SetNNDoanhNghiep(int idDN, int nnID, string fullCode)
        {
            DNNganhNgheRepos dnNNRepos = new DNNganhNgheRepos();
            DNNganhNghe dnnn = dnNNRepos.Find(idDN, nnID);
            if (dnnn == null || dnnn.Id == 0)
            {
                dnnn = dnNNRepos.Add(new DNNganhNghe() { DoanhNghiepId = idDN, NganhNgheId = nnID, MaDayDu = fullCode });
            }
        }
        public static void DN_SetNganHang(int idDN, string nh)
        {
            if (nh != null)
            {
                nh = nh.Trim();
                DMNganHangRepos nhRepos = new DMNganHangRepos();
                DMNganHang dmNH = nhRepos.Find(nh);
                if (dmNH == null || dmNH.Id == 0)
                {
                    dmNH = nhRepos.Add(new DMNganHang() { Ten = nh });
                }
                new DNNganHangRepos().Add(new DNNganHang() { DoanhNghiepId = idDN, NganHangId = dmNH.Id });
            }
        }
        public static void DN_SetTag(int idDN, string tag)
        {
            if (tag != null)
            {
                tag = tag.Trim();
                DMTagRepos tagRepos = new DMTagRepos();
                DMTag dmTag = tagRepos.Find(tag);
                if (dmTag == null || dmTag.Id == 0)
                {
                    dmTag = tagRepos.Add(new DMTag() { Tag = tag });
                }
                new DNTagRepos().Add(new DNTag() { DoanhNghiepId = idDN, TagId = dmTag.Id });
            }
        }
        //public static HttpWebRequest GetRequest(string url, string httpMethod = "GET", bool allowAutoRedirect = true)
        //{
        //    Uri uri = new Uri(url);
        //    HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
        //    request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";

        //    request.Timeout = Convert.ToInt32(new TimeSpan(0, 5, 0).TotalMilliseconds);
        //    request.Method = httpMethod;
        //    return request;
        //}
        //public static string GetDataJson(string url)
        //{
        //    HttpClient client = new HttpClient();
        //    ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
        //    HttpWebRequest request = GetRequest(url);
        //    WebResponse webResponse = request.GetResponse();
        //    return new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
        //}

        public static string GetReleases(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var content = string.Empty;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }

            return content;
        }

        public static void WriteLog(string maST, string path)
        {
            if (!string.IsNullOrEmpty(maST))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(maST);
                    sw.Flush();
                }
            }
        }

        //public string NonStaticGetDataJson(string url)
        //{
        //    HttpClient client = new HttpClient();
        //    ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
        //    HttpWebRequest request = GetRequest(url);
        //    WebResponse webResponse = request.GetResponse();
        //    return new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
        //}
        //public int GetTotalRow(string url)
        //{
        //    int sum = 0;
        //    try
        //    {
        //        string json = NonStaticGetDataJson(url);
        //        string[] lst = json.Split(new string[] { "," }, StringSplitOptions.None);
        //        var node = lst.Where(x => x.Contains("TotalRow")).ToList();
        //        if (node != null && node.Count > 0)
        //        {
        //            var _node = Regex.Replace(node[0], "[^\\d]", "");
        //            sum = Convert.ToInt32(_node);
        //        }
        //    }
        //    catch { }
        //    return sum;
        //}

        /// <summary>
        /// Điệp fix
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public int GetTotalRow(string json)
        {
            int sum = 0;
            try
            {
                string[] lst = json.Split(new string[] { "," }, StringSplitOptions.None);
                var node = lst.Where(x => x.Contains("TotalRow")).ToList();
                if (node != null && node.Count > 0)
                {
                    var _node = Regex.Replace(node[0], "[^\\d]", "");
                    sum = Convert.ToInt32(_node);
                }
            }
            catch { }
            return sum;
        }
    }
}
