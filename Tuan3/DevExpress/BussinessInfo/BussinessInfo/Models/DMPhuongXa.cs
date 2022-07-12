namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMPhuongXa")]
    public partial class DMPhuongXa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(20)]
        public string Ma { get; set; }
    }
}
