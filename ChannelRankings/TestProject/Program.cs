using ChannelRankings.Data;
using ChannelRankings.Models.Authorities;
using ChannelRankings.Utils.ModelFactory;
using ChannelRankings.XmlModels;
using ChannelRankins.Contracts.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models = ChannelRankings.Models;

namespace TestProject
{
    public class Program
    {
        public static void Main()
        {
            //var directory = new DirectoryInfo("../../generated-channels.xml");

            //using (var fileStream = new FileStream(directory.FullName, FileMode.Open))
            //{
            //    var serializer = new XmlSerializer(typeof(Ranklist));

            //    var ranklist = (Ranklist)serializer.Deserialize(fileStream);
            //    var channels = ranklist.Channels.ToList();

            //}
            var context = new SqlServerDbContext();
            var db = new SqlServerDataProvider(context);
            AddToDb(db);
        }

        private static void AddToDb(ISqlServerDatabase database)
        {
            var factory = new ChannelModelMapper();

            var owner = factory.CreateOwner("Mitko", "Stoikov", "2312312");

            var coutry = factory.CreateCountry("Botswana");

            var sponsor = factory.CreateSponsor("Porsche", "brum brum");

            var corporation = factory.CreateCorporation("Golqmata firma", owner);

            var returnChannel = factory.CreateChannel("BTV", corporation, coutry, new List<Sponsor> { sponsor });

            database.Channels.Add(returnChannel);
            database.Commit();
        }
    }
}
