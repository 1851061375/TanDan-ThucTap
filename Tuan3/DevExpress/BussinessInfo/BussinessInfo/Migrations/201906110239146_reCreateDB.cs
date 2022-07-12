namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reCreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DMCoQuan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
                        Ma = c.String(maxLength: 10),
                        DienThoai = c.String(maxLength: 20),
                        Fax = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMDoanhNghiepTrucThuoc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuanHe = c.String(nullable: false, maxLength: 50),
                        MaSoThue = c.String(maxLength: 20),
                        Title = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMNganHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
                        Ma = c.String(maxLength: 10),
                        TenTat = c.String(maxLength: 100),
                        TenEn = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.DMThuePhaiNop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
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
                "dbo.DNNganHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoanhNghiepId = c.Int(nullable: false),
                        NganHangId = c.Int(nullable: false),
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
                "dbo.DNThuePhaiNop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoanhNghiepId = c.Int(nullable: false),
                        ThuePhaiNopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DoanhNghiep",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 100),
                        IsDelete = c.Boolean(),
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
                        NoiDangKyQuanLyId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DoanhNghiep");
            DropTable("dbo.DNThuePhaiNop");
            DropTable("dbo.DNSanPham");
            DropTable("dbo.DNNganhNghe");
            DropTable("dbo.DNNganHang");
            DropTable("dbo.DMTinhThanh");
            DropTable("dbo.DMThuePhaiNop");
            DropTable("dbo.DMSanPham");
            DropTable("dbo.DMQuanHuyen");
            DropTable("dbo.DMPhuongXa");
            DropTable("dbo.DMNganhNghe");
            DropTable("dbo.DMNganHang");
            DropTable("dbo.DMDoanhNghiepTrucThuoc");
            DropTable("dbo.DMCoQuan");
        }
    }
}
