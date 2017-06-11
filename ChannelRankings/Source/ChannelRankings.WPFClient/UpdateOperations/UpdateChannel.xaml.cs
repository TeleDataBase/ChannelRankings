using System.Windows;
using ChannelRankins.Contracts.Data;

namespace ChannelRankings.WPFClient.UpdateOperations
{
    /// <summary>
    /// Interaction logic for UpdateChannel.xaml
    /// </summary>
    public partial class UpdateChannel : Window
    {
        private IDbManipulationManager dbManager;

        public UpdateChannel(IDbManipulationManager dbManager)
        {
            this.InitializeComponent();
            this.dbManager = dbManager;
        }

        private void UpdateChannelButton_Click(object sender, RoutedEventArgs e)
        {
            var channelId = int.Parse(this.channelId.Text);

            this.dbManager.UpdateChannel(channelId, this.channelName.Text, this.channelRankplace.Text);

            MessageBox.Show("Channel updated successfully!");
            this.Close();
        }
    }
}
