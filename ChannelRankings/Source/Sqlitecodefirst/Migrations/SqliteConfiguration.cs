using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

/// <summary>
/// 作者：音樂咖啡
/// 联系方式：QQ 136463644
/// </summary>
namespace Sqlitecodefirst.Migrations
{
    internal sealed class ContextMigrationConfiguration : DbMigrationsConfiguration<SqliteDBContext>
    {
        public ContextMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(SqliteDBContext context)
        {
            //base.Seed(context);
            context.Yusers.AddOrUpdate(new Entity.YUser[] { new Entity.YUser() {  UserID=1,UserName="test1", UserSex="man" ,NickName="tetdd"} });
        }
    }
}
