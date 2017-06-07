using System.Data.Entity;

namespace ChannelRankinigs.Data.PostgreSQL
{
    public class PostgreSQLContext : DbContext
    {

        public PostgreSQLContext() : base("NpgsqlConnectionString")
        {

        }

        public virtual DbSet<Company> CompanySet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
