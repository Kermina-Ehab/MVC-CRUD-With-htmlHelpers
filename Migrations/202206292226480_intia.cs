namespace CRUDHTNLHELPERS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fname = c.String(nullable: false, maxLength: 20),
                        lname = c.String(),
                        age = c.Int(),
                        salary = c.Decimal(precision: 18, scale: 2),
                        Email = c.String(nullable: false),
                        pwd = c.String(),
                        URL = c.String(),
                        DOB = c.DateTime(),
                        address = c.String(),
                        Deptid = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.Deptid)
                .Index(t => t.Deptid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Deptid", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Deptid" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
