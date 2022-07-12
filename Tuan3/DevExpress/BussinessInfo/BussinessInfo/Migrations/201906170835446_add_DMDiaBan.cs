namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_DMDiaBan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DMDiaBan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        SolrID = c.String(maxLength: 100),
                        TinhThanhID = c.Int(nullable: false),
                        TinhThanhTitle = c.String(maxLength: 100),
                        TinhThanhTitleAscii = c.String(maxLength: 100),
                        QuanHuyenID = c.Int(nullable: false),
                        QuanHuyenTitle = c.String(maxLength: 100),
                        QuanHuyenTitleAscii = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DMDiaBan");
        }
    }
}
