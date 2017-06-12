using ChannelRankings.Data.SQLite;

namespace TestProject
{
    public class Program
    {
        public static void Main()
        {
            //var modelMapper = new ChannelModelMapper();
            //var context = new SqlServerDbContext();
            //var db = new SqlServerDataProvider(context);

            //var db = new PostgreSqlContext();

            //db.Database.CreateIfNotExists();

            var db = new SqliteDBContext();

            db.Database.CreateIfNotExists();

        }
    }
}
