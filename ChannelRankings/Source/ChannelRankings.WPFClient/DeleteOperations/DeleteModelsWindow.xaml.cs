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

namespace ChannelRankings.WPFClient.DeleteOperations
{
    /// <summary>
    /// Interaction logic for DeleteModelsWindow.xaml
    /// </summary>
    public partial class DeleteModelsWindow : Window
    {
        private ISqlServerDatabase database;
        private IRepository<Owner> owners;
        private IRepository<Country> countries;

        public DeleteModelsWindow(ISqlServerDatabase database, IRepository<Owner> owners, IRepository<Country> countries)
        {
            this.InitializeComponent();
            this.database = database;
            this.owners = owners;
            this.countries = countries;
        }

        private void DeleteModelButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var deleteModelId = int.Parse(this.deleteId.Text);

                if (this.deleteOwnerRadio.IsChecked == true)
                {
                    var ownerToDelete = this.owners.GetById(deleteModelId);
                    this.owners.Delete(ownerToDelete);
                }
                else if (this.deleteCountryRadio.IsChecked == true)
                {
                    var countryToDelete = this.countries.GetById(deleteModelId);
                    this.countries.Delete(countryToDelete);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

            this.database.Commit();
            MessageBox.Show("Model deleted successfully!");
            this.Close();
        }
    }
}
