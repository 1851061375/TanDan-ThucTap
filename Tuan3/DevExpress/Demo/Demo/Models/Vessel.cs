namespace Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vessel")]
    public partial class Vessel
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string CallSign { get; set; }

        [StringLength(50)]
        public string MMSI { get; set; }

        [StringLength(50)]
        public string IMOID { get; set; }

        [StringLength(50)]
        public string Flag { get; set; }

        [StringLength(50)]
        public string Length { get; set; }

        [StringLength(50)]
        public string Beam { get; set; }

        [StringLength(50)]
        public string RegPort { get; set; }

        [StringLength(50)]
        public string RegistrationNumber { get; set; }

        [StringLength(50)]
        public string DeadWeightTonnage { get; set; }

        [StringLength(50)]
        public string VesselType { get; set; }

        [Column(TypeName = "text")]
        public string Images { get; set; }

        [Column(TypeName = "text")]
        public string LatestPort { get; set; }

        [Column(TypeName = "text")]
        public string Url { get; set; }
    }
}
