namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DNNganHang")]
    public partial class DNNganHang
    {
        public int Id { get; set; }

        public int DoanhNghiepId { get; set; }

        public int NganHangId { get; set; }
    }
}
