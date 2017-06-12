namespace ChannelRankings.Data.PostgreSQL.Migrations
{
    using ChannelRankings.Data.PostgreSQL.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ChannelRankings.Data.PostgreSQL.PostgreSqlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ChannelRankings.Data.PostgreSQL.PostgreSqlContext context)
        {
            var radioChannels = new RadioChannel[]
            {
                new RadioChannel(){Name = "The Voice", Frequency ="96.20", MainTopic = "Music" },
                new RadioChannel(){Name = "Z-Rock", Frequency ="89.10", MainTopic = "Music" },
                new RadioChannel(){Name = "Radio Nova News", Frequency ="95.70", MainTopic = "News" },
                new RadioChannel(){Name = "Radio Horizont", Frequency ="100.90", MainTopic = "Boring stuff" }
            };

            context.RadioChannels.AddOrUpdate(radioChannels);
        }
    }
}
