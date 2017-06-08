using ChannelRankings.Data.PostgreSQL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Data.PostgreSQL
{
    public class LegacyContext : DbContext
    {
        
        public LegacyContext() : base("NpgsqlConnectionString")
        {

        }

        public virtual DbSet<SovietChannel> Channels { get; set; }

        public virtual DbSet<Director> Directors { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
