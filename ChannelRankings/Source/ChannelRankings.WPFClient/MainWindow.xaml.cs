using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ChannelRankings.Data;
using ChannelRankings.Utils.Reporters;
using ChannelRankins.Contracts.Data;
using System.IO;
using System.Threading;
using System.Diagnostics;
using ChannelRankings.Utils.Importers;
using ChannelRankings.Utils.ModelFactory;

namespace ChannelRankings.WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ReportSavePath = "../../../../Data/Output/pdf-report.pdf";

        private ISqlServerDatabase database;

        public MainWindow()
        {
            this.database = new SqlServerDataProvider(new SqlServerDbContext());
            this.InitializeComponent();
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
            var database = new SqlServerDataProvider(new SqlServerDbContext());
            var savePath = new DirectoryInfo(ReportSavePath);
            var reporter = new PdfReporter(database);

            reporter.CreateReport(savePath.FullName);
            MessageBox.Show("Pdf Reports generated successfully!");

            // Open report in browser
            Process.Start(savePath.FullName);
        }
    }
}
