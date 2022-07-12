namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMTag")]
    public partial class DMTag
    {
        public int Id { get; set; }

        public string Tag { get; set; }
    }
}
