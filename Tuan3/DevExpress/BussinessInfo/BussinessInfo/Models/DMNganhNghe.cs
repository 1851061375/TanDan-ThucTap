namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMNganhNghe")]
    public partial class DMNganhNghe
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public int Type { get; set; }

        [StringLength(200)]
        public string SolrID { get; set; }

        [StringLength(200)]
        public string TitleAscii { get; set; }

        public string Lv1 { get; set; }
        public string Lv2 { get; set; }
        public string Lv3 { get; set; }
        public string Lv4 { get; set; }
        public string Lv5 { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public int? TotalDoanhNghiep { get; set; }
    }
}
