using ChannelRankings.Data.SQLite;
using ChannelRankings.Data.SQLite.Entity;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;


namespace ChannelChannelRankings.Data.SQLite.Migrations
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
            //context.Yusers.AddOrUpdate(new Entity.YUser[] { new Entity.YUser() {  UserID=1,UserName="test1", UserSex="man" ,NickName="tetdd"} });

           context.YouTubeChannels.AddOrUpdate(new YouTubeChannel[]
            {
                new YouTubeChannel() { Name = "TUSofia", Url = "youtube.com/tusofia", Rank = 7},
                new YouTubeChannel() { Name = "FMI", Url = "youtube.com/fmi", Rank = 71},
                new YouTubeChannel() { Name = "TelerikAcademy", Url = "youtube.com/telerikacademy", Rank = 1},
                new YouTubeChannel() { Name = "Funny", Url = "youtube.com/funny", Rank = 2},
                new YouTubeChannel() { Name = "Kango", Url = "youtube.com/kango", Rank = 11},
                new YouTubeChannel() { Name = "UFC", Url = "youtube.com/ufc", Rank = 3},
                new YouTubeChannel() { Name = "Camp", Url = "youtube.com/camp", Rank = 25},
                new YouTubeChannel() { Name = "Shooting", Url = "youtube.com/shooting", Rank = 18},
            });
        }
    }
}
