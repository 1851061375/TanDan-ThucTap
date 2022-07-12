namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class big_update_database2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DoanhNghiep", "TinhThanhID", c => c.Int());
            AlterColumn("dbo.DoanhNghiep", "QuanHuyenID", c => c.Int());
            AlterColumn("dbo.DoanhNghiep", "PhuongXaID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DoanhNghiep", "PhuongXaID", c => c.Int(nullable: false));
            AlterColumn("dbo.DoanhNghiep", "QuanHuyenID", c => c.Int(nullable: false));
            AlterColumn("dbo.DoanhNghiep", "TinhThanhID", c => c.Int(nullable: false));
        }
    }
}
