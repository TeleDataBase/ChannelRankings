namespace Sqlitecodefirst.Migrations
{
    using Sqlitecodefirst.Models;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;

    internal sealed class SqliteConfiguration : DbMigrationsConfiguration<ChannelRankings.Data.SQLite.SqliteDBContext>
    {
        public SqliteConfiguration()
        {
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(ChannelRankings.Data.SQLite.SqliteDBContext context)
        {
            context.YouTubeChannels.AddOrUpdate(new TvSeries[]
            {
                new TvSeries() { Name = "Pretty little liars", AnnualIncome = 12000000, Genre="American drama" },
                new TvSeries() { Name = "Game of Thrones", AnnualIncome = 98000000, Genre="Fantasy" },
                new TvSeries() { Name = "The Walking Dead", AnnualIncome = 67050000, Genre="Horror-fiction" },
                new TvSeries() { Name = "Arrow", AnnualIncome = 9900000, Genre="Crime fiction" },
                new TvSeries() { Name = "Mr.Robot", AnnualIncome = 45060000, Genre="Psychological thriller" },
                new TvSeries() { Name = "Stranger Things", AnnualIncome = 22030000, Genre="Science fiction" }
            });
        }
    }
}
