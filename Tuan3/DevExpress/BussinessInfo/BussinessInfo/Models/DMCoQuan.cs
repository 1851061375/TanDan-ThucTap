namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMCoQuan")]
    public partial class DMCoQuan
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DMCoQuan()
        {
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(20)]
        public string Ma { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }
    }
}
