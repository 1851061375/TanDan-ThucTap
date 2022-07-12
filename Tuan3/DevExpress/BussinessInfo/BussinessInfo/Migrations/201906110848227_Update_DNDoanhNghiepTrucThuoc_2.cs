namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_DNDoanhNghiepTrucThuoc_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DNDoanhNghiepTrucThuoc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoanhNghiepId = c.Int(nullable: false),
                        QuanHe = c.String(),
                        DoanhNghiepTrucThuocId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DNDoanhNghiepTrucThuoc");
        }
    }
}
