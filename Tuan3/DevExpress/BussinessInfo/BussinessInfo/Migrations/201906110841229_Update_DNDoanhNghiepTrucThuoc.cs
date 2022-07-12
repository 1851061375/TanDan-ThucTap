namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_DNDoanhNghiepTrucThuoc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DoanhNghiep", "GiayPhepKinhDoanh_CoQuanCapId", c => c.Int());
            DropTable("dbo.DMDoanhNghiepTrucThuoc");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DMDoanhNghiepTrucThuoc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuanHe = c.String(nullable: false, maxLength: 50),
                        MaSoThue = c.String(maxLength: 20),
                        Title = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.DoanhNghiep", "GiayPhepKinhDoanh_CoQuanCapId");
        }
    }
}
