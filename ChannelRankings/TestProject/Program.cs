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
            var directory = new DirectoryInfo("../../generated-channels.xml");

            using (var fileStream = new FileStream(directory.FullName, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(Ranklist));

                var ranklist = (Ranklist)serializer.Deserialize(fileStream);
                var channels = ranklist.Channels.ToList();

                var context = new SqlServerDbContext();
                var db = new SqlServerDataProvider(context);
                AddToDb(db, channels[1]);
            }
        }

        private static void AddToDb(ISqlServerDatabase database, Channel channel)
        {
            var factory = new ChannelModelMapper();

            var owner = factory.CreateOwner(
                channel.Corporation.Owner.FirstName,
                channel.Corporation.Owner.LastName,
                channel.Corporation.Owner.NetWorth
                );

            var coutry = factory.CreateCountry(
                channel.Country.Name
                );

            var sponsors = new List<Sponsor>();

            foreach (var sponsor in channel.Sponsors)
            {
                sponsors.Add(
                    factory.CreateSponsor(
                        sponsor.Name,
                        sponsor.About
                        )
                    );
            }

            var corporation = factory.CreateCorporation(
                channel.Corporation.Name,
                owner
                );

            var returnChannel = factory.CreateChannel(
                channel.Name, corporation, coutry, sponsors
                );

            database.Channels.Add(returnChannel);
            database.Commit();
        }
    }
}
