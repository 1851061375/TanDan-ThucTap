namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class re_create_db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DMNganhNghe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma = c.String(nullable: false, maxLength: 16),
                        Ten = c.String(nullable: false, maxLength: 300),
                        ParentId = c.Int(),
                        FullParentMa = c.String(),
                        Count = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMPhuongXa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
                        Ma = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMQuanHuyen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
                        Ma = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMSanPham",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 300),
                        ParentId = c.Int(),
                        Count = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMTinhThanh",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
                        Ma = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DNNganhNghe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoanhNghiepId = c.Int(nullable: false),
                        NganhNgheId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DNSanPham",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoanhNghiepId = c.Int(nullable: false),
                        SanPhamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DoanhNghiep",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Ten = c.String(nullable: false, maxLength: 100),
                        IsDelete = c.Boolean(nullable: false),
                        DiaChi = c.String(maxLength: 100),
                        SoDienThoai = c.String(maxLength: 50, fixedLength: true),
                        Fax = c.String(maxLength: 50, fixedLength: true),
                        Email = c.String(maxLength: 50, fixedLength: true),
                        Web = c.String(maxLength: 100),
                        TinhThanhId = c.Int(),
                        TrangThai = c.String(maxLength: 100),
                        MaSoThue = c.String(maxLength: 100),
                        TenEn = c.String(),
                        NgayCapMST = c.DateTime(),
                        NgayDongMST = c.DateTime(),
                        DiaChiNhanThongBaoThue = c.String(maxLength: 100),
                        NamTaiChinh = c.Int(),
                        NgayNhanToKhai = c.DateTime(),
                        NgayBatDauHopDong = c.DateTime(),
                        VonDieuLe = c.String(),
                        TongSoLaoDong = c.Int(),
                        CapChuongLoaiKhoan = c.String(),
                        HinhThucThanhToan = c.String(),
                        PhuongPhapTinhThueGTGT = c.String(),
                        ChuSoHuu = c.String(maxLength: 100),
                        ChuSoHuu_DiaChi = c.String(maxLength: 100),
                        GiamDoc = c.String(maxLength: 100, unicode: false),
                        SDTGiamDoc = c.String(maxLength: 20, fixedLength: true),
                        EmailGiamDoc = c.String(maxLength: 50, fixedLength: true),
                        DiaChiGiamDoc = c.String(maxLength: 100),
                        KeToanTruong = c.String(maxLength: 100),
                        SDTKeToanTruong = c.String(maxLength: 20),
                        EmailKeToanTruong = c.String(maxLength: 50),
                        DiaChiKeToanTruong = c.String(maxLength: 100),
                        NoiNopThueID = c.Int(),
                        GiayPhepKinhDoanh = c.String(maxLength: 20),
                        GiayPhepKinhDoanh_NgayCap = c.DateTime(),
                        QuanHuyenId = c.Int(),
                        PhuongXaId = c.Int(),
                        NoiDangKyQuanLyID = c.Int(),
                    })
                .PrimaryKey(t => new { t.Id, t.Ten, t.IsDelete });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DoanhNghiep");
            DropTable("dbo.DNSanPham");
            DropTable("dbo.DNNganhNghe");
            DropTable("dbo.DMTinhThanh");
            DropTable("dbo.DMSanPham");
            DropTable("dbo.DMQuanHuyen");
            DropTable("dbo.DMPhuongXa");
            DropTable("dbo.DMNganhNghe");
        }
    }
}
