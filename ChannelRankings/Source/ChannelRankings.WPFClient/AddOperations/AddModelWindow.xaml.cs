using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;
using ChannelRankings.WPFClient.AddOperations;
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

namespace ChannelRankings.WPFClient
{
    /// <summary>
    /// Interaction logic for AddModelWindow.xaml
    /// </summary>
    public partial class AddModelWindow : Window
    {
        private ISqlServerDatabase database;
        private IRepository<Owner> owners;
        private IRepository<Sponsor> sponsors;

        public AddModelWindow(ISqlServerDatabase database, IRepository<Owner> owners, IRepository<Sponsor> sponsors)
        {
            this.InitializeComponent();
            this.database = database;
            this.owners = owners;
            this.sponsors = sponsors;
        }

        private void AddOwner_Click(object sender, RoutedEventArgs e)
        {
            var addOwnerWindow = new AddOwner(this.database, this.owners);
            addOwnerWindow.ShowDialog();
        }

        private void AddSponsor_Click(object sender, RoutedEventArgs e)
        {
            var addSponsorWindow = new AddSponsor(this.database, this.sponsors);
            addSponsorWindow.ShowDialog();
        }
    }
}
