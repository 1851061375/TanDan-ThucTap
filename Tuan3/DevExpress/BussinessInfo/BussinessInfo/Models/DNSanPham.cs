namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DNSanPham")]
    public partial class DNSanPham
    {
        public int Id { get; set; }

        public int DoanhNghiepId { get; set; }

        public int SanPhamId { get; set; }
    }
}
