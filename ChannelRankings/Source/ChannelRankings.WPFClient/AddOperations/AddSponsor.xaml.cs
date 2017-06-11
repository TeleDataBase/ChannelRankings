using ChannelRankins.Contracts.Data;
using System.Windows;

namespace ChannelRankings.WPFClient.AddOperations
{
    /// <summary>
    /// Interaction logic for AddSponsor.xaml
    /// </summary>
    public partial class AddSponsor : Window
    {
        private IDbManipulationManager dbManager;

        public AddSponsor(IDbManipulationManager dbManager)
        {
            this.InitializeComponent();
            this.dbManager = dbManager;
        }

        private void AddSponsorButton_Click(object sender, RoutedEventArgs e)
        {
            var name = this.sponsorName.Text;
            var description = this.sponsorDescription.Text;


            this.dbManager.AddSponsorToDb(name, description);

            MessageBox.Show("Sponsor successfully added!");
            this.Close();
        }
    }
}
