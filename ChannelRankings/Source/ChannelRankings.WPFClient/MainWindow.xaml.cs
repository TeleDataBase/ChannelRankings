using System;
using System.Windows;
using ChannelRankings.Utils.Reporters;
using ChannelRankins.Contracts.Data;
using System.IO;
using System.Diagnostics;
using ChannelRankings.Utils.Importers;
using ChannelRankings.Utils.ModelFactory;
using ChannelRankings.Models;
using ChannelRankings.WPFClient.ReadOperations;
using ChannelRankings.WPFClient.UpdateOperations;
using ChannelRankings.WPFClient.DeleteOperations;

namespace ChannelRankings.WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ReportSavePath = "../../../../Data/Output/pdf-report.pdf";

        private IDbManipulationManager dbManager;
        private ISqlServerDatabase database;
        private IRepository<Channel> channels;
        private IRepository<Owner> owners;
        private IRepository<Country> countries;

        public MainWindow(ISqlServerDatabase database, IDbManipulationManager dbManager, IRepository<Channel> channels,
            IRepository<Owner> owners, IRepository<Country> countries)
        {
            this.InitializeComponent();
            this.database = database;
            this.dbManager = dbManager;
            this.channels = channels;
            this.owners = owners;
            this.countries = countries;
        }

        private void importXmlButton_Click(object sender, RoutedEventArgs e)
        {
            var modelMapper = new ChannelModelMapper();
            var importer = new XmlImporter(modelMapper, this.database);
            importer.Import();

            MessageBox.Show("Xml content successfully imported to SQL Server!");
        }

        private void GeneratePdfReport_Click(object sender, RoutedEventArgs e)
        {
            var savePath = new DirectoryInfo(ReportSavePath);
            var reporter = new PdfReporter(this.database, this.channels);

            reporter.CreateReport(savePath.FullName);
            MessageBox.Show("Pdf Reports generated successfully!");

            // Open report in browser
            Process.Start(savePath.FullName);
        }

        private void CreateModelButton_Click(object sender, RoutedEventArgs e)
        {
            var createModelWindow = new AddModelWindow(this.dbManager);
            createModelWindow.ShowDialog();
        }

        private void viewDataButton_Click(object sender, RoutedEventArgs e)
        {
            var viewModelsWindow = new ViewModelsWindow(this, this.channels, this.owners, this.countries);
            viewModelsWindow.ShowDialog();

        }

        private void UpdateModelButton_Click(object sender, RoutedEventArgs e)
        {
            var updateModelsWindow = new UpdateModelsWindow(this.dbManager);
            updateModelsWindow.ShowDialog();
        }

        private void DeleteModelButton_Click(object sender, RoutedEventArgs e)
        {
            var deleteModelsWindow = new DeleteModelsWindow(this.dbManager);
            deleteModelsWindow.ShowDialog();
        }
    }
}
