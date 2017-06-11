namespace ChannelRankings.Data.PostgreSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.RadioChannels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Frequency = c.String(maxLength: 40),
                        MainTopic = c.String(maxLength: 40),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.RadioChannels", "Country_Id", "public.Countries");
            DropIndex("public.RadioChannels", new[] { "Country_Id" });
            DropTable("public.RadioChannels");
            DropTable("public.Countries");
        }
    }
}
