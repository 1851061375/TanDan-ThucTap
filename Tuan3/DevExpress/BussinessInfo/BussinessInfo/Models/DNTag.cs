namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DNTag")]
    public partial class DNTag
    {
        public int Id { get; set; }

        public int DoanhNghiepId { get; set; }

        public int TagId { get; set; }
    }
}
