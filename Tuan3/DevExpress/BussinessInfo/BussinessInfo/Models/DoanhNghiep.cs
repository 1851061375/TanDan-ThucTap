namespace BussinessInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhNghiep")]
    public partial class DoanhNghiep
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public bool? IsDelete { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        [StringLength(20)]
        public string MaSoThue { get; set; }

        public DateTime? NgayCap { get; set; }

        public DateTime? NgayDongMST { get; set; }

        [StringLength(100)]
        public string TitleEn { get; set; }

        [StringLength(200)]
        public string DiaChiCongTy { get; set; }

        [StringLength(200)]
        public string DiaChiNhanThongBaoThue { get; set; }

        public DateTime? NamTaiChinh { get; set; }

        [StringLength(20)]
        public string MaSoHienThoi { get; set; }

        public DateTime? NgayNhanToKhai { get; set; }

        public DateTime? NgayBatDauHopDong { get; set; }

        public string VonDieuLe { get; set; }

        public int? TongSoLaoDong { get; set; }

        public string CapChuongLoaiKhoan { get; set; }

        public string HinhThucThanhToan { get; set; }

        public string PhuongPhapTinhThueGTGT { get; set; }

        [StringLength(50)]
        public string ChuSoHuu { get; set; }

        [StringLength(200)]
        public string ChuSoHuu_DiaChi { get; set; }

        [StringLength(50)]
        public string GiamDoc { get; set; }

        [StringLength(200)]
        public string GiamDoc_DiaChi { get; set; }

        [StringLength(50)]
        public string KeToanTruong { get; set; }

        [StringLength(200)]
        public string KeToanTruong_DiaChi { get; set; }

        public bool? ExitsInGDT { get; set; }

        public int? TinhThanhID { get; set; }
        public string TinhThanhTitle { get; set; }
        public string TinhThanhTitleAscii { get; set; }

        public int? QuanHuyenID { get; set; }
        public string QuanHuyenTitle { get; set; }
        public string QuanHuyenTitleAscii { get; set; }

        public int? PhuongXaID { get; set; }
        public string PhuongXaTitle { get; set; }
        public string PhuongXaTitleAscii { get; set; }

        public int? NoiDangKyQuanLyID { get; set; }
        public string NoiDangKyQuanLy_CoQuanTitle { get; set; }
        public string NoiDangKyQuanLy_CoQuanTitleAscii { get; set; }
        public string NoiDangKyQuanLy_DienThoai { get; set; }
        public string NoiDangKyQuanLy_Fax { get; set; }
        public int? NoiNopThueID { get; set; }
        public string NoiNopThue_DienThoai { get; set; }
        public string NoiNopThue_Fax { get; set; }
        public string NoiNopThue_CoQuanTitle { get; set; }
        public string NoiNopThue_CoQuanTitleAscii { get; set; }
        public string QuyetDinhThanhLap { get; set; }
        public string QuyetDinhThanhLap_NgayCap { get; set; }
        public int? QuyetDinhThanhLap_CoQuanCapID { get; set; }
        public string QuyetDinhThanhLap_CoQuanCapTitle { get; set; }
        public string QuyetDinhThanhLap_CoQuanCapTitleAscii { get; set; }
        public int? GiayPhepKinhDoanh_CoQuanCapID { get; set; }
        public string GiayPhepKinhDoanh_CoQuanCapTitle { get; set; }
        public string GiayPhepKinhDoanh_CoQuanCapTitleAscii { get; set; }
        public string GiayPhepKinhDoanh { get; set; }
        public DateTime? GiayPhepKinhDoanh_NgayCap { get; set; }
        public int? LoaiHinhID { get; set; }
        public string LoaiHinhTitle { get; set; }
        public string LoaiHinhTitleAscii { get; set; }
        public int? NganhNgheID { get; set; }
        public string NganhNgheTitle { get; set; }
        public string NganhNgheTitleAscii { get; set; }
        public string Lv1 { get; set; }
        public string Lv2 { get; set; }
        public string Lv3 { get; set; }
        public string Lv4 { get; set; }
        public string Lv5 { get; set; }
    }
}
