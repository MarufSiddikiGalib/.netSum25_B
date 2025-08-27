namespace CFCRUDEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeptColChnge : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String());
        }
    }
}
