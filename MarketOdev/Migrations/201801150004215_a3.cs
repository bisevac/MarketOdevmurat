namespace MarketOdev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "BarkodNumarasi", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunler", "BarkodNumarasi");
        }
    }
}
