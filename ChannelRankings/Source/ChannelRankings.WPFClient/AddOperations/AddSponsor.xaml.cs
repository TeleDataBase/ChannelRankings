using System;
using System.Windows;
using ChannelRankins.Contracts.Data;

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

            try
            {
                this.dbManager.AddSponsorToDb(name, description);

                MessageBox.Show("Sponsor successfully added!");
                this.Close();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
