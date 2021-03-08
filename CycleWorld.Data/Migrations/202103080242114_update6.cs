namespace CycleWorld.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Part", "TypeofPart", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Part", "TypeofPart", c => c.Int(nullable: false));
        }
    }
}
