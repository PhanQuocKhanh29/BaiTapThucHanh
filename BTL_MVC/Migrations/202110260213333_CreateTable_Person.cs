namespace BTL_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128, unicode: false),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
