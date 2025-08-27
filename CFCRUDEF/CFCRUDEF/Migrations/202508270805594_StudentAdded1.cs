namespace CFCRUDEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentAdded1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Cgpa", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Cgpa");
        }
    }
}
