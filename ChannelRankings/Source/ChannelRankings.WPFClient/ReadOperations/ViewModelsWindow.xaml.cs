using ChannelRankings.Models;
using ChannelRankins.Contracts.Data;
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
using System.Windows.Shapes;

namespace ChannelRankings.WPFClient.ReadOperations
{
    /// <summary>
    /// Interaction logic for ViewModelsWindow.xaml
    /// </summary>
    public partial class ViewModelsWindow : Window
    {
        private MainWindow mainWindow;
        private IRepository<Country> countries;
        private IRepository<Channel> channels;

        public ViewModelsWindow(MainWindow mainWindow, IRepository<Country> countries, IRepository<Channel> channels)
        {
            this.InitializeComponent();
            this.mainWindow = mainWindow;
            this.countries = countries;
            this.channels = channels;
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
    }
}
