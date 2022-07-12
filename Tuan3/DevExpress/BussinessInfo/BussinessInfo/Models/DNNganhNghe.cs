namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DNNganhNghe")]
    public partial class DNNganhNghe
    {
        public int Id { get; set; }

        public int DoanhNghiepId { get; set; }

        public int NganhNgheId { get; set; }

        public string MaDayDu { get; set; }


    }
}
