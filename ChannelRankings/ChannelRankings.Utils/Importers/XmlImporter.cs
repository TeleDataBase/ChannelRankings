using System;
using ChannelRankins.Contracts.Data;
using ChannelRankins.Contracts.Utils;
using System.IO;
using ChannelRankings.XmlModels;
using System.Linq;
using System.Xml.Serialization;

namespace ChannelRankings.Utils.Importers
{
    public class XmlImporter : IXmlImporter
    {
        private ISqlServerDatabase connection;

        public XmlImporter(ISqlServerDatabase connection)
        {
            this.connection = connection;
        }

        public void Import(ISqlServerDatabase connection)
        {
            using (var fileStream = new FileStream("../../generated-channels.xml", FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(Ranklist));

                var ranklist = (Ranklist)serializer.Deserialize(fileStream);
                var channels = ranklist.Channels.ToList();

                //Sort and add to database
            }
        }
    }
}
