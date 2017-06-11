using ChannelRankings.Data.PostgreSQL.Models;
using ChannelRankings.XmlModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Data.PostgreSQL
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext() : base("NpgsqlConnectionString")
        {
        }

        DbSet<Models.Country> Countries { get; set; }

        DbSet<RadioChannel> RadioChannels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
