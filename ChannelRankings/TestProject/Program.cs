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

                
                Console.WriteLine(channels[0].Corporation.Owner.LastName);
            }

        }

        private static void AddToDb(ISqlServerDatabase database, Channel channel)
        {
            //var owner = new Models.Owner(){ FirstName = channel.Sponsors.}

            //var channelToAdd = new ChannelRankings.Models.Channel()
            //{
            //    Name = channel.Name,
            //    Corporation = new Models.Corporation() { },

            //}

            //database.Channels.Add((ChannelRankings.Models.Channel)channel);
        }
    }
}
