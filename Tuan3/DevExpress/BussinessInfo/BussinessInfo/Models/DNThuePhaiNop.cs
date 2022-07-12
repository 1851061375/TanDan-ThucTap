namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DNThuePhaiNop")]
    public partial class DNThuePhaiNop
    {
        public int Id { get; set; }

        public int DoanhNghiepId { get; set; }

        public int ThuePhaiNopId { get; set; }
    }
}
