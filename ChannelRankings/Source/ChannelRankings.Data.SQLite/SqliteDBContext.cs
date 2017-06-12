using Sqlitecodefirst.Migrations;
using Sqlitecodefirst.Models;
using System.Data.Entity;

namespace ChannelRankings.Data.SQLite
{
    public class SqliteDBContext : DbContext
    {
        public SqliteDBContext()
            : base("SqlitecodefirstConstring")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqliteDBContext, SqliteConfiguration>(true));
        }

        public DbSet<TvSeries> YouTubeChannels { get; set; }
    }
}
