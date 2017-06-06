using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ChannelRankins.Contracts.Data;
using ChannelRankins.Contracts.Utils;
using ChannelRankings.XmlModels;

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
            var directory = new DirectoryInfo("../../generated-channels.xml");

            using (var fileStream = new FileStream(directory.FullName, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(Ranklist));

                var ranklist = (Ranklist)serializer.Deserialize(fileStream);
                var channels = ranklist.Channels.ToList();

                //Sort and add to database
            }
        }
    }
}
