using System.Windows;
using ChannelRankins.Contracts.Data;

namespace ChannelRankings.WPFClient.UpdateOperations
{
    /// <summary>
    /// Interaction logic for UpdateCountry.xaml
    /// </summary>
    public partial class UpdateCountry : Window
    {
        private IDbManipulationManager dbManager;

        public UpdateCountry(IDbManipulationManager dbManager)
        {
            this.InitializeComponent();
            this.dbManager = dbManager;
        }

        private void UpdateCoutryButton_Click(object sender, RoutedEventArgs e)
        {
            var countryId = int.Parse(this.countryId.Text);

            this.dbManager.UpdateCountry(countryId, this.countryName.Text);

            MessageBox.Show("Coutry updated successfully!");
            this.Close();
        }
    }
}
