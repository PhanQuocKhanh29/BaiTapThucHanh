namespace BTL_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SinhVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenSV = c.String(),
                        NamSinh = c.String(),
                        Lop = c.String(),
                        GioiTinh = c.String(),
                        DiaChi = c.String(),
                        SoDienThoai = c.String(),
                    })
                .PrimaryKey(t => t.MaSV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhVien");
        }
    }
}
