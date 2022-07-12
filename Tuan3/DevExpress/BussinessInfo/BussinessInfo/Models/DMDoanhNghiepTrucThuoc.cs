namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMDoanhNghiepTrucThuoc")]
    public partial class DMDoanhNghiepTrucThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DMDoanhNghiepTrucThuoc()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public int QuanHe { get; set; }
        public string SolrID { get; set; }
        public string MaSoThue { get; set; }
        public string DiaChi { get; set; }
        public int DoanhNghiepID { get; set; }
        public string DoanhNghiepTitle { get; set; }
        public string DoanhNghiepMaSoThue { get; set; }
        public string DoanhNghiepTitleAscii { get; set; }
    }
}
