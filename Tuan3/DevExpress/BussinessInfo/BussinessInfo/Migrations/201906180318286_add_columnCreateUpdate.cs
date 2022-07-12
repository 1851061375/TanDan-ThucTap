namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_columnCreateUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DMDiaBan", "Created", c => c.DateTime());
            AddColumn("dbo.DMDiaBan", "Update", c => c.DateTime());
            AddColumn("dbo.DMNganhNghe", "Title", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.DMNganhNghe", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.DMNganhNghe", "SolrID", c => c.String(maxLength: 200));
            AddColumn("dbo.DMNganhNghe", "TitleAscii", c => c.String(maxLength: 200));
            AddColumn("dbo.DMNganhNghe", "Lv1", c => c.String());
            AddColumn("dbo.DMNganhNghe", "Lv2", c => c.String());
            AddColumn("dbo.DMNganhNghe", "Lv3", c => c.String());
            AddColumn("dbo.DMNganhNghe", "Lv4", c => c.String());
            AddColumn("dbo.DMNganhNghe", "Lv5", c => c.String());
            AddColumn("dbo.DMNganhNghe", "Created", c => c.DateTime());
            AddColumn("dbo.DMNganhNghe", "Update", c => c.DateTime());
            AddColumn("dbo.DMNganhNghe", "TotalDoanhNghiep", c => c.Int());
            DropColumn("dbo.DMNganhNghe", "Ma");
            DropColumn("dbo.DMNganhNghe", "Ten");
            DropColumn("dbo.DMNganhNghe", "MaCha");
            DropColumn("dbo.DMNganhNghe", "MaDayDu");
            DropColumn("dbo.DMNganhNghe", "TongSo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DMNganhNghe", "TongSo", c => c.Int());
            AddColumn("dbo.DMNganhNghe", "MaDayDu", c => c.String());
            AddColumn("dbo.DMNganhNghe", "MaCha", c => c.String());
            AddColumn("dbo.DMNganhNghe", "Ten", c => c.String(nullable: false, maxLength: 300));
            AddColumn("dbo.DMNganhNghe", "Ma", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.DMNganhNghe", "TotalDoanhNghiep");
            DropColumn("dbo.DMNganhNghe", "Update");
            DropColumn("dbo.DMNganhNghe", "Created");
            DropColumn("dbo.DMNganhNghe", "Lv5");
            DropColumn("dbo.DMNganhNghe", "Lv4");
            DropColumn("dbo.DMNganhNghe", "Lv3");
            DropColumn("dbo.DMNganhNghe", "Lv2");
            DropColumn("dbo.DMNganhNghe", "Lv1");
            DropColumn("dbo.DMNganhNghe", "TitleAscii");
            DropColumn("dbo.DMNganhNghe", "SolrID");
            DropColumn("dbo.DMNganhNghe", "Type");
            DropColumn("dbo.DMNganhNghe", "Title");
            DropColumn("dbo.DMDiaBan", "Update");
            DropColumn("dbo.DMDiaBan", "Created");
        }
    }
}
