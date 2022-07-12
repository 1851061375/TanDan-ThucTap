namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_DMDiaBan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DMDiaBan", "TotalDoanhNghiep", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DMDiaBan", "TotalDoanhNghiep");
        }
    }
}
