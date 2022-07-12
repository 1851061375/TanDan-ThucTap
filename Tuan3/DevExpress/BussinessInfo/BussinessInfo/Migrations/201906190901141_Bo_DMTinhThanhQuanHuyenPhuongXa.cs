namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bo_DMTinhThanhQuanHuyenPhuongXa : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.DMPhuongXa");
            DropTable("dbo.DMQuanHuyen");
            DropTable("dbo.DMTinhThanh");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DMTinhThanh",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
                        Ma = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMQuanHuyen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
                        Ma = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMPhuongXa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 50),
                        Ma = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
