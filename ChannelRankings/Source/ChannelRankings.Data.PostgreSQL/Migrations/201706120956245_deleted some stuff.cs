namespace ChannelRankings.Data.PostgreSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedsomestuff : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.RadioChannels", "Country_Id", "public.Countries");
            DropIndex("public.RadioChannels", new[] { "Country_Id" });
            AddColumn("public.RadioChannels", "CountryId", c => c.Int(nullable: false));
            DropColumn("public.RadioChannels", "Country_Id");
            DropTable("public.Countries");
        }
        
        public override void Down()
        {
            CreateTable(
                "public.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("public.RadioChannels", "Country_Id", c => c.Int());
            DropColumn("public.RadioChannels", "CountryId");
            CreateIndex("public.RadioChannels", "Country_Id");
            AddForeignKey("public.RadioChannels", "Country_Id", "public.Countries", "Id");
        }
    }
}
