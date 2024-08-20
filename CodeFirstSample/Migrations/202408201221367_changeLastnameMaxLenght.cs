namespace CodeFirstSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeLastnameMaxLenght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Masters", "LastName", c => c.String(nullable: false, maxLength: 64));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Masters", "LastName", c => c.String(nullable: false));
        }
    }
}
