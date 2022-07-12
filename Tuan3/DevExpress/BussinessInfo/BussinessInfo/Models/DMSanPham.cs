namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMSanPham")]
    public partial class DMSanPham
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Ten { get; set; }

        public int? MaCha { get; set; }

        public int? SoLuong { get; set; }
    }
}
