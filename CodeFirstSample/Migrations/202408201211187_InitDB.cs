namespace CodeFirstSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Masters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 64),
                        LastName = c.String(nullable: false),
                        Mobile = c.String(maxLength: 11),
                        Email = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MyStudent",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 32),
                        LastName = c.String(nullable: false),
                        Mobile = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyStudent");
            DropTable("dbo.Masters");
        }
    }
}
