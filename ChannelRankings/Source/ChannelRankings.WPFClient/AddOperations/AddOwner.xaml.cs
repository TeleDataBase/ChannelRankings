using ChannelRankins.Contracts.Data;
using System.Windows;

namespace ChannelRankings.WPFClient
{
    /// <summary>
    /// Interaction logic for AddOwner.xaml
    /// </summary>
    public partial class AddOwner : Window
    {
        private IDbManipulationManager dbManager;

        public AddOwner(IDbManipulationManager dbManager)
        {
            this.InitializeComponent();
            this.dbManager = dbManager;
        }

        private void AddOwnerButton_Click(object sender, RoutedEventArgs e)
        {

            var firstName = this.ownerFirstName.Text;
            var lastName = this.ownerLastName.Text;
            var netWorth = this.ownerNetWorth.Text;

            this.dbManager.AddOwnerToDb(firstName, lastName, netWorth);

            MessageBox.Show("Owner successfully added!");
            this.Close();
        }
    }
}
