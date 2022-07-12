namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_DMTag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DMTag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tag = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DNTag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoanhNghiepId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DNTag");
            DropTable("dbo.DMTag");
        }
    }
}
