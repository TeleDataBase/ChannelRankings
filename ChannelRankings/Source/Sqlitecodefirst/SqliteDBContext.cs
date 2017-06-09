using Sqlitecodefirst.Entity;
using Sqlitecodefirst.Migrations;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
/// <summary>
/// 作者：音樂咖啡
/// 联系方式：QQ 136463644
/// </summary>
namespace Sqlitecodefirst
{
    //[DbConfigurationType(typeof(ContextMigrationConfiguration))]
    public class SqliteDBContext : DbContext
    {
        public SqliteDBContext()
            : base("name=SqlitecodefirstConstring")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqliteDBContext, ContextMigrationConfiguration>(true));
        }

        public DbSet<YUser> Yusers { get; set; }
        public DbSet<YGroup> Ygroup { get; set; }
    }
}
