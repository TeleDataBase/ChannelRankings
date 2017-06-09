using ChannelRankings.Models.Authorities;
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

namespace ChannelRankings.WPFClient.AddOperations
{
    /// <summary>
    /// Interaction logic for AddSponsor.xaml
    /// </summary>
    public partial class AddSponsor : Window
    {
        private ISqlServerDatabase database;
        private IRepository<Sponsor> sponsors;

        public AddSponsor(ISqlServerDatabase database, IRepository<Sponsor> sponsors)
        {
            this.InitializeComponent();
            this.database = database;
            this.sponsors = sponsors;
        }

        private void AddSponsorButton_Click(object sender, RoutedEventArgs e)
        {
            var name = this.sponsorName.Text;
            var description = this.sponsorDescription.Text;


            this.sponsors.Add(new Sponsor()
            {
                Name = name,
                About = description
            });

            this.database.Commit();

            MessageBox.Show("Sponsor successfully added!");
            this.Close();
        }
    }
}
