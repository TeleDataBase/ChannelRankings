using ChannelRankings.XmlModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestProject
{
    public class Program
    {
        public static void Main()
        {

            using (var fileStream = new FileStream("../../generated-channels.xml", FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(Ranklist));

                var ranklist = (Ranklist)serializer.Deserialize(fileStream);
                var channels = ranklist.Channels.ToList();

                Console.WriteLine(channels[0].Sponsors.FirstOrDefault().Name);
            }
        }
    }
}
