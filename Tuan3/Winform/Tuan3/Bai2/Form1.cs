using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class fMain : Form
    {
        List<Flight> listFlight = new List<Flight>();

        public fMain()
        {
            InitializeComponent();
            listFlight.Add(new Flight()
            {
                tenHangBay = "Vietnam Airline",
                giaVe = 1165000,
                diemDi = "Hà Nội",
                diemDen = "Sài Gòn",
                ngayDi = new DateTime(2021, 11, 30),
                soVe = 100,
                hinhAnh = "vietnam-airlines.jpg"
            });

            listFlight.Add(new Flight()
            {
                tenHangBay = "VietJet Air",
                giaVe = 1000000,
                diemDi = "Hà Nội",
                diemDen = "Sài Gòn",
                ngayDi = new DateTime(2021, 11, 25),
                soVe = 100,
                hinhAnh = "vietjet-air.jpg"
            });

            String[] array = { "Hà Nội", "Sài Gòn", "Đà Nẵng" };
            foreach (var item in array)
            {
                cbStart.Items.Add(item);
                cbEnd.Items.Add(item);
            }
        }

        /*private void doDuLieuCombobox()
        {
            cbStart.DataSource = listFlight;
            cbStart.DisplayMember = "diemDi";

            cbEnd.DataSource = listFlight;
            cbEnd.DisplayMember = "diemDen";
        }*/

        private List<Flight> timChuyenBay(Flight flight)
        {
            var listFlightResult = new List<Flight>();
            for (int i = 0; i < listFlight.Count; i++)
            {
                int thoiGianDenLucBay = (listFlight[0].ngayDi - flight.ngayDi).Days;
                int soVeConLai = listFlight[i].soVe - flight.soVe;
                if (flight.diemDi == listFlight[i].diemDi && flight.diemDen == listFlight[i].diemDen
                     && thoiGianDenLucBay > 0 && soVeConLai > 0)
                    listFlightResult.Add(listFlight[i]);
            }
            return listFlightResult;
        }

        private string timAnh(string[] arr)
        {
            string result = "";
            for (int i = 0; i < listFlight.Count; i++)
                if (arr[0] == listFlight[i].tenHangBay)
                    result = listFlight[i].hinhAnh;
            return result;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            lbResult.Items.Clear();
            var flight = new Flight();
            flight.diemDi = cbStart.Text;
            flight.diemDen = cbEnd.Text;
            flight.ngayDi = dtDate.Value;
            flight.soVe = Convert.ToInt32(nmCount.Value);
            var result = timChuyenBay(flight);
            CultureInfo culture = new CultureInfo("vi-VN");
            for (int i = 0; i < result.Count; i++)
                lbResult.Items.AddRange(new object[] {
                    result[i].tenHangBay + ", " + result[i].ngayDi.ToShortDateString() + ", " + result[i].giaVe.ToString("c",culture),
                });

            //lbResult.Items.Add(result[0].hinhAnh);
        }

        private void lbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arr = lbResult.SelectedItem.ToString().Split(',');
            pbPicture.Image = new Bitmap(Application.StartupPath + "//Resources/" + timAnh(arr));
        }
    }
}
