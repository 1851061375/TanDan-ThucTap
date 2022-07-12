namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Re_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DNNganhNghe", "MaDayDu", c => c.String());
            AlterColumn("dbo.DMNganhNghe", "MaCha", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DMNganhNghe", "MaCha", c => c.Int());
            DropColumn("dbo.DNNganhNghe", "MaDayDu");
        }
    }
}
