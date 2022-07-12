namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMNganHang")]
    public partial class DMNganHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DMNganHang()
        {
            //DNNganHangs = new HashSet<DNNganHang>();
        }

        public int Id { get; set; }

        [Required]
        public string Ten { get; set; }

        [StringLength(20)]
        public string Ma { get; set; }

        [StringLength(100)]
        public string TenTat { get; set; }

        [StringLength(100)]
        public string TenEn { get; set; }
    }
}
