namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DNDoanhNghiepTrucThuoc")]
    public partial class DNDoanhNghiepTrucThuoc
    {
        public int Id { get; set; }

        public int DoanhNghiepId { get; set; }

        public string QuanHe { get; set; }

        public int DoanhNghiepTrucThuocId { get; set; }
    }
}
