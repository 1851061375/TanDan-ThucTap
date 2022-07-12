using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using HtmlAgilityPack;
using BussinessInfo.Models;
using BussinessInfo.Dapper;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using IronOcr;

namespace BussinessInfo
{
    public partial class demo : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string json = BaseAPI.GetReleases("https://thongtindoanhnghiep.co/api/city");
            textBox1.Text = json;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Bạn cần nhập đường dẫn capcha trước.");
                return;
            }
            var Ocr = new AutoOcr();
            var Result = Ocr.Read(textBox1.Text);
            MessageBox.Show(Result.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string 

            //var Ocr = new AutoOcr();
            //var Result = Ocr.Read(@"sdt.png");
            //MessageBox.Show(Result.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TTDNPage.DongBoDiaBan();
            textBox1.Text += "Đã đồng bộ xong Địa bàn";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TTDNPage.DongBoNganhNghe();
            textBox1.Text += "Đã đồng bộ xong Ngành nghề";
        }
    }
}