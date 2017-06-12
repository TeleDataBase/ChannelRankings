using System.Data.Entity;
using ChannelRankings.Data.PostgreSQL.Models;

namespace ChannelRankings.Data.PostgreSQL
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext() : base("NpgsqlConnectionString")
        {
        }

        public DbSet<RadioChannel> RadioChannels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
