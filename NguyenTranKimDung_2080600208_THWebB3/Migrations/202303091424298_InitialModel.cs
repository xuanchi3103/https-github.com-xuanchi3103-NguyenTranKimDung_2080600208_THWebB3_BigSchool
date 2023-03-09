namespace NguyenTranKimDung_2080600208_THWebB3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Courses", "LecturerID", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerID" });
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            DropTable("dbo.Categories");
            DropTable("dbo.Courses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LecturerID = c.String(nullable: false, maxLength: 128),
                        Place = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        CategoryID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Courses", "CategoryID");
            CreateIndex("dbo.Courses", "LecturerID");
            AddForeignKey("dbo.Courses", "LecturerID", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
    }
}
