namespace ChannelRankings.Data.PostgreSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.RadioChannels", "Name", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            DropColumn("public.RadioChannels", "Name");
        }
    }
}
