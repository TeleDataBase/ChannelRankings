using System.Windows;
using ChannelRankins.Contracts.Data;

namespace ChannelRankings.WPFClient.UpdateOperations
{
    /// <summary>
    /// Interaction logic for UpdateModelsWindow.xaml
    /// </summary>
    public partial class UpdateModelsWindow : Window
    {
        private IDbManipulationManager dbManager;

        public UpdateModelsWindow(IDbManipulationManager dbManager)
        {
            this.InitializeComponent();
            this.dbManager = dbManager;
        }

        private void UpdateChannelButton_Click(object sender, RoutedEventArgs e)
        {
            var updateChannelWindow = new UpdateChannel(this.dbManager);
            updateChannelWindow.ShowDialog();
        }

        private void UpdateCountryButton_Click(object sender, RoutedEventArgs e)
        {
            var updateCountryWinow = new UpdateCountry(this.dbManager);
            updateCountryWinow.ShowDialog();
        }
    }
}
