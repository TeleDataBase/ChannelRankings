using System.Data.Entity;

namespace ChannelRankings.Data.PostgreSQL
{
    public class CompanyContext : DbContext
    {
        public virtual DbSet<Company> CompanySet { get; set; }
        public virtual DbSet<Employee> EmployeeSet { get; set; }

        public CompanyContext() : base("NpgsqlConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
