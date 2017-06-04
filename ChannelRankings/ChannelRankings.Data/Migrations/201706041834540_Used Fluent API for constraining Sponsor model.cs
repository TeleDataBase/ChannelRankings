namespace ChannelRankings.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsedFluentAPIforconstrainingSponsormodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Channels", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Channels", new[] { "Country_Id" });
            AlterColumn("dbo.Channels", "Country_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Sponsors", "Name", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Sponsors", "About", c => c.String(storeType: "ntext"));
            CreateIndex("dbo.Channels", "Country_Id");
            CreateIndex("dbo.Sponsors", "Name", unique: true);
            AddForeignKey("dbo.Channels", "Country_Id", "dbo.Countries", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Channels", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Sponsors", new[] { "Name" });
            DropIndex("dbo.Channels", new[] { "Country_Id" });
            AlterColumn("dbo.Sponsors", "About", c => c.String());
            AlterColumn("dbo.Sponsors", "Name", c => c.String());
            AlterColumn("dbo.Channels", "Country_Id", c => c.Int());
            CreateIndex("dbo.Channels", "Country_Id");
            AddForeignKey("dbo.Channels", "Country_Id", "dbo.Countries", "Id");
        }
    }
}
