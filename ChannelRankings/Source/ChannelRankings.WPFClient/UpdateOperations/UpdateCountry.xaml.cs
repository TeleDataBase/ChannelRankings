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
    /// Interaction logic for UpdateCountry.xaml
    /// </summary>
    public partial class UpdateCountry : Window
    {
        private ISqlServerDatabase database;
        private IRepository<Country> countries;

        public UpdateCountry(ISqlServerDatabase database, IRepository<Country> countries)
        {
            this.InitializeComponent();
            this.database = database;
            this.countries = countries;
        }

        private void UpdateCoutryButton_Click(object sender, RoutedEventArgs e)
        {
            var countryId = int.Parse(this.countryId.Text);
            var countryToUpdate = this.countries.GetById(countryId);

            var newCountryName = string.IsNullOrEmpty(this.countryName.Text) ? countryToUpdate.Name : this.countryName.Text;

            countryToUpdate.Name = newCountryName;

            this.countries.Update(countryToUpdate);
            this.database.Commit();

            MessageBox.Show("Coutry updated successfully!");
            this.Close();
        }
    }
}
