namespace MarketOdev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Siparisler", "Nakit", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Siparisler", "Nakit");
        }
    }
}
