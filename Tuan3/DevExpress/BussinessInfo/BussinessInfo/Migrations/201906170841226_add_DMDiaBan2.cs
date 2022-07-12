namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_DMDiaBan2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DMDiaBan", "TinhThanhID", c => c.Int());
            AlterColumn("dbo.DMDiaBan", "QuanHuyenID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DMDiaBan", "QuanHuyenID", c => c.Int(nullable: false));
            AlterColumn("dbo.DMDiaBan", "TinhThanhID", c => c.Int(nullable: false));
        }
    }
}
