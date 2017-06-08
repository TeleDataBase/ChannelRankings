using System;
using ChannelRankings.Data;
using ChannelRankings.Models;
using ChannelRankings.Utils.Importers;
using ChannelRankings.Utils.ModelFactory;
using iTextSharp.text;
using iTextSharp.text.pdf;

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

            //Importer

            //var importer = new XmlImporter(modelMapper, db);
            //importer.Import();

            //Reporter

            //var reporter = new PdfReporter(db);
            //var savePath = new DirectoryInfo("../../report.pdf");

            //reporter.CreateReport(savePath);
        }
    }
}
