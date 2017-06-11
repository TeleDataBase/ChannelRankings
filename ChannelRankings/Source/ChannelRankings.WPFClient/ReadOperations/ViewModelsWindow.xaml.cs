using System.Linq;
using System.Windows;
using ChannelRankings.Models;
using ChannelRankins.Contracts.Data;

namespace ChannelRankings.WPFClient.ReadOperations
{
    /// <summary>
    /// Interaction logic for ViewModelsWindow.xaml
    /// </summary>
    public partial class ViewModelsWindow : Window
    {
        private MainWindow mainWindow;
        private IRepository<Channel> channels;
        private IRepository<Owner> owners;
        private IRepository<Country> countries;

        public ViewModelsWindow(MainWindow mainWindow, IRepository<Channel> channels, IRepository<Owner> owners, IRepository<Country> countries)
        {
            this.InitializeComponent();
            this.mainWindow = mainWindow;
            this.channels = channels;
            this.owners = owners;
            this.countries = countries;
        }

        private void ViewChannelsButton_Click(object sender, RoutedEventArgs e)
        {
            var channels = this.channels.GetAll()
                .Select(x => new
                {
                    x.Id,
                    x.WorldRankplace,
                    x.Name
                })
                .ToList();

            this.mainWindow.dataGrid.ItemsSource = channels;
        }

        private void ViewCountriesButton_Click(object sender, RoutedEventArgs e)
        {
            var countries = this.countries.GetAll()
                .Select(x => new
                {
                    x.Id,
                    x.Name
                })
                .ToList();

            this.mainWindow.dataGrid.ItemsSource = countries;
        }

        private void ViewOwnersButton_Click(object sender, RoutedEventArgs e)
        {
            var owners = this.owners.GetAll()
                .Select(x => new
                {
                    x.Id,
                    x.FirstName,
                    x.LastName,
                    x.NetWorth
                })
                .ToList();

            this.mainWindow.dataGrid.ItemsSource = owners;
        }
    }
}
