using System;
using System.Windows;
using ChannelRankins.Contracts.Data;

namespace ChannelRankings.WPFClient.DeleteOperations
{
    /// <summary>
    /// Interaction logic for DeleteModelsWindow.xaml
    /// </summary>
    public partial class DeleteModelsWindow : Window
    {
        private IDbManipulationManager dbManager;

        public DeleteModelsWindow(IDbManipulationManager dbManager)
        {
            this.InitializeComponent();
            this.dbManager = dbManager;
        }

        private void DeleteModelButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var deleteModelId = int.Parse(this.deleteId.Text);

                if (this.deleteOwnerRadio.IsChecked == true)
                {
                    this.dbManager.DeleteOwner(deleteModelId);
                }
                else if (this.deleteCountryRadio.IsChecked == true)
                {
                    this.dbManager.DeleteCountry(deleteModelId);
                }

                MessageBox.Show("Model deleted successfully!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
