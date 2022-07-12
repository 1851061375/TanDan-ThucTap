namespace BussinessInfo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<DMCoQuan> DMCoQuans { get; set; }
        public virtual DbSet<DMDoanhNghiepTrucThuoc> DMDoanhNghiepTrucThuocs { get; set; }
        public virtual DbSet<DMNganHang> DMNganHangs { get; set; }
        public virtual DbSet<DMDiaBan> DMDiaBans { get; set; }
        public virtual DbSet<DMNganhNghe> DMNganhNghes { get; set; }
        //public virtual DbSet<DMPhuongXa> DMPhuongXas { get; set; }
        //public virtual DbSet<DMQuanHuyen> DMQuanHuyens { get; set; }
        public virtual DbSet<DMSanPham> DMSanPhams { get; set; }
        public virtual DbSet<DMThuePhaiNop> DMThuePhaiNops { get; set; }
        //public virtual DbSet<DMTinhThanh> DMTinhThanhs { get; set; }
        public virtual DbSet<DNNganHang> DNNganHangs { get; set; }
        public virtual DbSet<DNNganhNghe> DNNganhNghes { get; set; }
        public virtual DbSet<DNSanPham> DNSanPhams { get; set; }
        public virtual DbSet<DNThuePhaiNop> DNThuePhaiNops { get; set; }
        public virtual DbSet<DNDoanhNghiepTrucThuoc> DNDoanhNghiepTrucThuocs { get; set; }
        public virtual DbSet<DoanhNghiep> DoanhNghieps { get; set; }
        public virtual DbSet<DMTag> DMTags { get; set; }
        public virtual DbSet<DNTag> DNTags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
