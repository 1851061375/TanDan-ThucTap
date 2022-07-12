namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DMDiaBan", "Updated", c => c.DateTime());
            AddColumn("dbo.DMNganhNghe", "Updated", c => c.DateTime());
            DropColumn("dbo.DMDiaBan", "Update");
            DropColumn("dbo.DMNganhNghe", "Update");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DMNganhNghe", "Update", c => c.DateTime());
            AddColumn("dbo.DMDiaBan", "Update", c => c.DateTime());
            DropColumn("dbo.DMNganhNghe", "Updated");
            DropColumn("dbo.DMDiaBan", "Updated");
        }
    }
}
