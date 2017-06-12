using System;
using ChannelRankings.Data;
using ChannelRankings.Models;
using ChannelRankings.Utils.Importers;
using ChannelRankings.Utils.ModelFactory;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ChannelRankings.Utils.Reporters;
using System.IO;
using System.Linq;
using ChannelRankings.Models.Authorities;
using ChannelRankings.Data.PostgreSQL;
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
