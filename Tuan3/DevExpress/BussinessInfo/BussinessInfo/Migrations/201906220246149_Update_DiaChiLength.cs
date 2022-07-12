namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_DiaChiLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DoanhNghiep", "DiaChiCongTy", c => c.String(maxLength: 200));
            AlterColumn("dbo.DoanhNghiep", "DiaChiNhanThongBaoThue", c => c.String(maxLength: 200));
            AlterColumn("dbo.DoanhNghiep", "ChuSoHuu_DiaChi", c => c.String(maxLength: 200));
            AlterColumn("dbo.DoanhNghiep", "GiamDoc_DiaChi", c => c.String(maxLength: 200));
            AlterColumn("dbo.DoanhNghiep", "KeToanTruong_DiaChi", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DoanhNghiep", "KeToanTruong_DiaChi", c => c.String(maxLength: 100));
            AlterColumn("dbo.DoanhNghiep", "GiamDoc_DiaChi", c => c.String(maxLength: 100));
            AlterColumn("dbo.DoanhNghiep", "ChuSoHuu_DiaChi", c => c.String(maxLength: 100));
            AlterColumn("dbo.DoanhNghiep", "DiaChiNhanThongBaoThue", c => c.String(maxLength: 100));
            AlterColumn("dbo.DoanhNghiep", "DiaChiCongTy", c => c.String(maxLength: 100));
        }
    }
}
