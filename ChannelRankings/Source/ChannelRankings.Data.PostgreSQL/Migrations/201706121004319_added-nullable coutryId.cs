namespace ChannelRankings.Data.PostgreSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednullablecoutryId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.RadioChannels", "CountryId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("public.RadioChannels", "CountryId", c => c.Int(nullable: false));
        }
    }
}
