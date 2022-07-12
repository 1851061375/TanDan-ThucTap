using Demo.DAO;
using Demo.Models;
using Demo.Web;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Demo
{
    public partial class frmMain : RibbonForm
    {
        List<Vessel> listVessel = new List<Vessel>();
        int startPage = 1, endPage = 1;
        int indexGet = 0, totalGet = 0;
        int indexSave = 0;
        string[,] webConfig = new string[,]
        {
            {"https://www.vesseltracker.com", "https://www.vesseltracker.com/en/vessels.html",
                "20", "pagination", "192", "results-table"},
            {"https://www.wcpfc.int", "https://www.wcpfc.int/record-fishing-vessel-database",
                "50", "pager", "68", "views-table cols-8"},
            {"https://marinetraffic.live", "https://marinetraffic.live/vessels.php",
                "20", "pagination pagination-sm", "39112", "table_main"}
            // số trang, số tàu trên 1 trang(Có thread gán lại khi from load)
        };
        public frmMain()
        {
            InitializeComponent();
        }       
        #region Events
        private void timer1_Tick(object sender, EventArgs e)
        {
            ribbonPageGroup1.Text = "Đang lấy dữ liệu: " + indexGet + "/" + totalGet;
            if (indexGet == totalGet)
                turnOnControl();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ribbonPageGroup1.Text = "Đang lưu dữ liệu: " + indexSave + "/" + totalGet;
            if (indexSave == totalGet)
                turnOnControl();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu cho Cbb chọn trang web
            BaseWeb baseWeb = new BaseWeb();
            List<string> urlList = new List<string>();
            for (int i = 0; i < webConfig.GetLength(0); i++)
                urlList.Add(webConfig[i, 1]);
            (barCbSelectWeb.Edit as RepositoryItemComboBox).Items.AddRange(urlList);

            // Lấy số trang của các website
            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < webConfig.GetLength(0); i++)
                    webConfig[i, 4] = baseWeb.getWebLength(webConfig[i, 1], webConfig[i, 3]).ToString();
            });
            t1.IsBackground = true;
            t1.Start();
            // Lấy số tàu trên 1 trang
            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < webConfig.GetLength(0); i++)
                    webConfig[i, 2] = baseWeb.getRowPerPage(webConfig[i, 1], webConfig[i, 5]).ToString();
            });
            t2.IsBackground = true;
            t2.Start();

        }
        private void barCbSelectWeb_EditValueChanged(object sender, EventArgs e)
        {
            // Gán dữ liệu cho Cbb trang bắt đầu, kết thúc
            var webLength = new List<int>();
            for (int i = 0; i < webConfig.GetLength(0); i++)
            {
                if (barCbSelectWeb.EditValue.ToString() == webConfig[i, 1])
                    for (int j = 1; j <= int.Parse(webConfig[i, 4]); j++)
                        webLength.Add(j);
            }
                
            (barCbStartPage.Edit as RepositoryItemComboBox).Items.Clear();
            (barCbEndPage.Edit as RepositoryItemComboBox).Items.Clear();
            (barCbStartPage.Edit as RepositoryItemComboBox).Items.AddRange(webLength);
            (barCbEndPage.Edit as RepositoryItemComboBox).Items.AddRange(webLength);
        }

        private void barBtnGetData_ItemClick(object sender, ItemClickEventArgs e)
        {
            listVessel.Clear();
            tbResult.Clear();
            indexGet = 0;
            string url = barCbSelectWeb.EditValue.ToString();
            string domain = ""; int row = 1;
            // Ko duoc
            if (barCbStartPage.EditValue.ToString()!="" && barCbEndPage.EditValue.ToString()!="")
            {
                startPage = int.Parse(barCbStartPage.EditValue.ToString());
                endPage = int.Parse(barCbEndPage.EditValue.ToString());
            }
            int sub = endPage - startPage + 1;
            if (sub > 0 && sub <= 10)
            {
                turnOffControl(1);
                for (int i = 0; i < webConfig.GetLength(0); i++)
                    if (url == webConfig[i, 1])
                    {
                        domain = webConfig[i, 0];
                        row = int.Parse(webConfig[i, 2]);
                    }
                // Tổng số tàu phải lấy
                totalGet = sub * row;
                if (url == webConfig[0, 1])
                    getDataVesselTracke(domain, url, startPage, endPage);
                if (url == webConfig[1, 1])
                    getDataWcpfc(domain, url, startPage, endPage);
                if (url == webConfig[2, 1])
                    getDataMarine(domain, url, startPage, endPage);
            }
            else
            {
                MessageBox.Show("Chọn ít hơn 10 trang!");
            }
            
        }
        private void barBtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            long result = -1;
            indexSave = 0;
            turnOffControl(2);
            VesselDAO vesselDAO = new VesselDAO();
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < listVessel.Count; i++)
                {
                    // Nếu tàu chưa tồn tại thì thêm mới
                    if (vesselDAO.checkExist(listVessel[i]) == -1)
                    { result = vesselDAO.insertToDB(listVessel[i]); indexSave++; }
                    else
                    { result = vesselDAO.updateToDB(listVessel[i]); indexSave++; }
                }
                if (result != -1)
                    MessageBox.Show("Lưu thành công!");
                else
                    MessageBox.Show("Lưu thất bại!");
            });
            thread.Start();
            
        }
        #endregion
        #region Methods
        public void turnOffControl(int timer)
        {
            barBtnGetData.Enabled = false;
            barBtnExcel.Enabled = false;
            barBtnSave.Enabled = false;
            if (timer == 1)
                timer1.Start();
            if (timer == 2)
                timer2.Start();
        }
        public void turnOnControl()
        {
            barBtnGetData.Enabled = true;
            barBtnExcel.Enabled = true;
            barBtnSave.Enabled = true;
            timer1.Stop();
            timer2.Stop();
        }
        // Lấy dữ liệu trang(1) https://www.vesseltracker.com/en/vessels.html
        public void getDataVesselTracke(string domain, string url, int start, int end)
        {
            HtmlWeb web = new HtmlWeb();
            Vessel vessel = new Vessel();
            VesselTracke vesselTracke = new VesselTracke();

            Thread thread = new Thread(() =>
            {
                //Lấy dữ liệu từng trang
                for (int i = startPage; i <= endPage; i++)
                {
                    HtmlDocument document = web.Load(url + "?page=" + i);
                    HtmlNode[] nodes = document.DocumentNode.SelectNodes("//*[@class='col-sm-1 hidden-xs photo']/a").ToArray();
                    foreach (var it in nodes)
                    {
                        var href = domain + it.GetAttributeValue("href", String.Empty);
                        vessel = vesselTracke.getDataPerPage(href);
                        Invoke(new Action(() =>
                        {
                            tbResult.Text += Newtonsoft.Json.JsonConvert.SerializeObject(vessel) + "\n";
                            listVessel.Add(vessel);
                            indexGet++;
                        }));
                    }

                }
            });
            thread.Start();
        }

        // Lấy dữ liệu trang(2) https://www.wcpfc.int/record-fishing-vessel-database
        public void getDataWcpfc(string domain, string url, int start, int end)
        {
            HtmlWeb web = new HtmlWeb();
            Vessel vessel = new Vessel();
            Wcpfc wc = new Wcpfc();

            Thread thread = new Thread(() =>
            {
                //Lấy dữ liệu từng trang
                for (int i = startPage; i <= endPage; i++)
                {
                    HtmlDocument document = web.Load(url + "?page=" + (i - 1));
                    HtmlNode table = document.DocumentNode.SelectSingleNode("//*[@class='views-table cols-8']/*[2]");
                    HtmlNode[] nodes = table.SelectNodes(".//tr/td/a").ToArray();
                    foreach (var iteam in nodes)
                    {
                        var href = domain + iteam.GetAttributeValue("href", String.Empty);
                        vessel = wc.getDataPerPage(href);
                        Invoke(new Action(() =>
                        {
                            tbResult.Text += Newtonsoft.Json.JsonConvert.SerializeObject(vessel) + "\n";
                            listVessel.Add(vessel);
                            indexGet++;
                        }));
                    }

                }
            });
            thread.Start();
        }
        // Lấy dữ liệu trang(3) https://marinetraffic.live/vessels.php
        public void getDataMarine(string domain, string url, int start, int end)
        {
            HtmlWeb web = new HtmlWeb();
            Vessel vessel = new Vessel();
            MarineTraffice marine = new MarineTraffice();

            Thread thread = new Thread(() =>
            {
                //Lấy dữ liệu từng trang
                for (int i = startPage; i <= endPage; i++)
                {
                    HtmlDocument document = web.Load(url + "?page=" + (i - 1));
                    HtmlNode[] nodes = document.DocumentNode.SelectNodes("//*[@class='table_title table_vessel_title']/a").ToArray();
                    foreach (var iteam in nodes)
                    {
                        var href = domain + iteam.GetAttributeValue("href", String.Empty);
                        vessel = marine.getDataPerPage(href);
                        Invoke(new Action(() =>
                        {
                            tbResult.Text += Newtonsoft.Json.JsonConvert.SerializeObject(vessel) + "\n";
                            listVessel.Add(vessel);
                            indexGet++;
                        }));
                    }

                }
            });
            thread.Start();
        }
        #endregion
    }
}
