using ChannelChannelRankings.Data.SQLite.Migrations;
using ChannelRankings.Data.SQLite.Entity;
using System.Data.Entity;

namespace ChannelRankings.Data.SQLite
{
    //[DbConfigurationType(typeof(ContextMigrationConfiguration))]
    public class SqliteDBContext : DbContext
    {
        public SqliteDBContext()
            : base("name=SqlitecodefirstConstring")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqliteDBContext, ContextMigrationConfiguration>(true));
        }

        public DbSet<YouTubeChannel> YouTubeChannels { get; set; }
    }
}
