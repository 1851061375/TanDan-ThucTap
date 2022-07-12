namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_NameEnglishToVietNamese : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DMNganhNghe", "MaCha", c => c.Int());
            AddColumn("dbo.DMNganhNghe", "MaDayDu", c => c.String());
            AddColumn("dbo.DMNganhNghe", "TongSo", c => c.Int());
            AddColumn("dbo.DMSanPham", "MaCha", c => c.Int());
            AddColumn("dbo.DMSanPham", "SoLuong", c => c.Int());
            AddColumn("dbo.DoanhNghiep", "NganhNgheKinhDoanhChinhId", c => c.Int());
            AlterColumn("dbo.DMNganHang", "Ten", c => c.String(nullable: false));
            DropColumn("dbo.DMNganhNghe", "ParentId");
            DropColumn("dbo.DMNganhNghe", "FullParentMa");
            DropColumn("dbo.DMNganhNghe", "Count");
            DropColumn("dbo.DMSanPham", "ParentId");
            DropColumn("dbo.DMSanPham", "Count");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DMSanPham", "Count", c => c.Int());
            AddColumn("dbo.DMSanPham", "ParentId", c => c.Int());
            AddColumn("dbo.DMNganhNghe", "Count", c => c.Int());
            AddColumn("dbo.DMNganhNghe", "FullParentMa", c => c.String());
            AddColumn("dbo.DMNganhNghe", "ParentId", c => c.Int());
            AlterColumn("dbo.DMNganHang", "Ten", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.DoanhNghiep", "NganhNgheKinhDoanhChinhId");
            DropColumn("dbo.DMSanPham", "SoLuong");
            DropColumn("dbo.DMSanPham", "MaCha");
            DropColumn("dbo.DMNganhNghe", "TongSo");
            DropColumn("dbo.DMNganhNghe", "MaDayDu");
            DropColumn("dbo.DMNganhNghe", "MaCha");
        }
    }
}
