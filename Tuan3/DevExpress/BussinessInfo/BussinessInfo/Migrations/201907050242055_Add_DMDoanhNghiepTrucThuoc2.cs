namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_DMDoanhNghiepTrucThuoc2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DMDoanhNghiepTrucThuoc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Type = c.Int(nullable: false),
                        QuanHe = c.Int(nullable: false),
                        SolrID = c.String(),
                        MaSoThue = c.String(),
                        DiaChi = c.String(),
                        DoanhNghiepID = c.Int(nullable: false),
                        DoanhNghiepTitle = c.String(),
                        DoanhNghiepMaSoThue = c.String(),
                        DoanhNghiepTitleAscii = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DMDoanhNghiepTrucThuoc");
        }
    }
}
