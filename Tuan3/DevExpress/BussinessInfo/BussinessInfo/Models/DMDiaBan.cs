namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMDiaBan")]
    public partial class DMDiaBan
    {
        /// <summary>
        /// Id của địa bàn
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 1: Tỉnh thành; 2: Quận huyện; 3: Xã phường
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// Tên của địa bàn
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        /// <summary>
        /// Được dùng như mã, là đường dẫn của địa bàn: /tinh/huyen/xa
        /// </summary>
        [StringLength(100)]
        public string SolrID { get; set; }
        /// <summary>
        /// Id của tỉnh
        /// </summary>
        public int? TinhThanhID { get; set; }
        /// <summary>
        /// Tên của tỉnh
        /// </summary>
        [StringLength(100)]
        public string TinhThanhTitle { get; set; }
        /// <summary>
        /// Đường dẫn của tỉnh
        /// </summary>
        [StringLength(100)]
        public string TinhThanhTitleAscii { get; set; }
        /// <summary>
        /// Id của huyện
        /// </summary>
        public int? QuanHuyenID { get; set; }
        /// <summary>
        /// Tên của huyện
        /// </summary>
        [StringLength(100)]
        public string QuanHuyenTitle { get; set; }
        /// <summary>
        /// Đường dẫn của huyện
        /// </summary>
        [StringLength(100)]
        public string QuanHuyenTitleAscii { get; set; }
        /// <summary>
        /// Tổng số doanh nghiệp trên địa bàn
        /// </summary>
        public int TotalDoanhNghiep { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
