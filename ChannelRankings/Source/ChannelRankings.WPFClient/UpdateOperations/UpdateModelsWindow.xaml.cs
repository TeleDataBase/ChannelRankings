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

namespace ChannelRankings.WPFClient.UpdateOperations
{
    /// <summary>
    /// Interaction logic for UpdateModelsWindow.xaml
    /// </summary>
    public partial class UpdateModelsWindow : Window
    {
        private ISqlServerDatabase database;
        private IRepository<Channel> channels;
        private IRepository<Country> countries;

        public UpdateModelsWindow(ISqlServerDatabase database, IRepository<Channel> channels, IRepository<Country> countries)
        {
            this.InitializeComponent();
            this.database = database;
            this.channels = channels;
            this.countries = countries;
        }

        private void UpdateChannelButton_Click(object sender, RoutedEventArgs e)
        {
            var updateChannelWindow = new UpdateChannel(this.database, this.channels);
            updateChannelWindow.ShowDialog();
        }

        private void UpdateCountryButton_Click(object sender, RoutedEventArgs e)
        {
            var updateCountryWinow = new UpdateCountry(this.database, this.countries);
            updateCountryWinow.ShowDialog();
        }
    }
}
