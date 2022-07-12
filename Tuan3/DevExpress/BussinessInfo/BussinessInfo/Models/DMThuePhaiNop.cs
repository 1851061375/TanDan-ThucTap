namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMThuePhaiNop")]
    public partial class DMThuePhaiNop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DMThuePhaiNop()
        {
            //DNThuePhaiNops = new HashSet<DNThuePhaiNop>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
    }
}
