namespace ChannelRankings.Data.PostgreSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.SovietChannels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        SvoietRankplace = c.Int(nullable: false),
                        Country_Id = c.Int(),
                        Director_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Countries", t => t.Country_Id)
                .ForeignKey("public.Directors", t => t.Director_Id, cascadeDelete: true)
                .Index(t => t.Country_Id)
                .Index(t => t.Director_Id);
            
            CreateTable(
                "public.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Directors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.SovietChannels", "Director_Id", "public.Directors");
            DropForeignKey("public.SovietChannels", "Country_Id", "public.Countries");
            DropIndex("public.SovietChannels", new[] { "Director_Id" });
            DropIndex("public.SovietChannels", new[] { "Country_Id" });
            DropTable("public.Directors");
            DropTable("public.Countries");
            DropTable("public.SovietChannels");
        }
    }
}
