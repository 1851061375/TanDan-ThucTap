namespace BussinessInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_MaLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DMCoQuan", "Ma", c => c.String(maxLength: 20));
            AlterColumn("dbo.DMNganHang", "Ma", c => c.String(maxLength: 20));
            AlterColumn("dbo.DMNganhNghe", "Ma", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.DMPhuongXa", "Ma", c => c.String(maxLength: 20));
            AlterColumn("dbo.DMQuanHuyen", "Ma", c => c.String(maxLength: 20));
            AlterColumn("dbo.DMTinhThanh", "Ma", c => c.String(maxLength: 20, fixedLength: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DMTinhThanh", "Ma", c => c.String(maxLength: 10, fixedLength: true));
            AlterColumn("dbo.DMQuanHuyen", "Ma", c => c.String(maxLength: 10));
            AlterColumn("dbo.DMPhuongXa", "Ma", c => c.String(maxLength: 10));
            AlterColumn("dbo.DMNganhNghe", "Ma", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.DMNganHang", "Ma", c => c.String(maxLength: 10));
            AlterColumn("dbo.DMCoQuan", "Ma", c => c.String(maxLength: 10));
        }
    }
}
