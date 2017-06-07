using ChannelRankings.Data;
using ChannelRankings.Utils.Importers;
using ChannelRankings.Utils.ModelFactory;

namespace TestProject
{
    public class Program
    {
        public static void Main()
        {
            // This setup should be put in a container configuration class in the WPFClient project

            var modelMapper = new ChannelModelMapper();
            var context = new SqlServerDbContext();
            var db = new SqlServerDataProvider(context);

            var importer = new XmlImporter(modelMapper, db);
            
            // Imports data from XML to Sql server database
            importer.Import();
        }
    }
}
