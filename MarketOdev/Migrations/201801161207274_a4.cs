namespace MarketOdev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Urunler", "BarkodNumarasi", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Urunler", "BarkodNumarasi", c => c.Int(nullable: false));
        }
    }
}
