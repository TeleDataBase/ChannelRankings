namespace Sqlitecodefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modelsupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TvSeries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 40),
                        AnnualIncome = c.Int(nullable: false),
                        Genre = c.String(maxLength: 40),
                        ChannelId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.YouTubeChannels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.YouTubeChannels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Url = c.String(maxLength: 64),
                        Rank = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.TvSeries");
        }
    }
}
