using System.Windows;
using ChannelRankings.WPFClient.AddOperations;
using ChannelRankins.Contracts.Data;

namespace ChannelRankings.WPFClient
{
    /// <summary>
    /// Interaction logic for AddModelWindow.xaml
    /// </summary>
    public partial class AddModelWindow : Window
    {
        private IDbManipulationManager dbManager;

        public AddModelWindow(IDbManipulationManager dbManager)
        {
            this.InitializeComponent();
            this.dbManager = dbManager;
        }

        private void AddOwner_Click(object sender, RoutedEventArgs e)
        {
            var addOwnerWindow = new AddOwner(this.dbManager);
            addOwnerWindow.ShowDialog();
        }

        private void AddSponsor_Click(object sender, RoutedEventArgs e)
        {
            var addSponsorWindow = new AddSponsor(this.dbManager);
            addSponsorWindow.ShowDialog();
        }
    }
}
