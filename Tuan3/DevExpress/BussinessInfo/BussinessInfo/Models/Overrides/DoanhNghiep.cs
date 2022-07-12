using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessInfo.Models
{
    public partial class DoanhNghiep
    {
        [NotMapped]
        public int ID { get; set; }
        [NotMapped]
        public List<string> DSNganhNgheKinhDoanh { get; set; }
        [NotMapped]
        public List<int> DSNganhNgheKinhDoanhID { get; set; }
        [NotMapped]
        public List<string> DSMaNganhNgheKinhDoanh { get; set; }
        [NotMapped]
        public List<string> DSNganHang { get; set; }
        [NotMapped]
        public List<int> DSNganHangID { get; set; }
        [NotMapped]
        public List<string> DSThuePhaiNop { get; set; }
        [NotMapped]
        public List<int> DSThuePhaiNopID { get; set; }
        [NotMapped]
        public List<LtsDoanhNghiepTrucThuoc> LtsDoanhNghiepTrucThuoc { get; set; }
        [NotMapped]
        public List<string> DSTags { get; set; }

        [NotMapped]
        public List<int> lstDoanhNghiepTrucThuoc { get; set; }

        [NotMapped]
        public List<int> lstNganhNgheKinhDoanh { get; set; }

        [NotMapped]
        public List<int> lstNganHang { get; set; }

        [NotMapped]
        public List<int> lstThuePhaiNop { get; set; }
    }
}