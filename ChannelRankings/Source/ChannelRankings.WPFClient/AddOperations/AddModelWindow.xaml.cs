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
        private IDbManipulationManager dbManager;

        public AddModelWindow(IDbManipulationManager dbManager)
        {
            this.InitializeComponent();
            this.dbManager = dbManager;
        }

        private void AddOwner_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddSponsor_Click(object sender, RoutedEventArgs e)
        {
            var addSponsorWindow = new AddSponsor(this.dbManager);
            addSponsorWindow.ShowDialog();
        }

        private void AddOwner_Click_1(object sender, RoutedEventArgs e)
        {
            var addOwnerWindow = new AddOwner(this.dbManager);
            addOwnerWindow.ShowDialog();
        }
    }
}
