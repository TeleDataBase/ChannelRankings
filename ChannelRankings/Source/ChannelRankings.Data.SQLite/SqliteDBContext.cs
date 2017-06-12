using ChannelRankings.Data.SQLite.Entity;
using SQLite.CodeFirst;
using Sqlitecodefirst.Migrations;
using System.Data.Entity;

namespace ChannelRankings.Data.SQLite
{
    //[DbConfigurationType(typeof(ContextMigrationConfiguration))]
    public class SqliteDBContext : DbContext
    {
        public SqliteDBContext()
            : base("SqlitecodefirstConstring")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<SqliteDBContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqliteDBContext, SqliteConfiguration>(true));
        }

        public DbSet<YouTubeChannel> YouTubeChannels { get; set; }
    }
}
