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

namespace ChannelRankings.WPFClient
{
    /// <summary>
    /// Interaction logic for AddOwner.xaml
    /// </summary>
    public partial class AddOwner : Window
    {
        private ISqlServerDatabase database;
        private IRepository<Owner> owners;

        public AddOwner(ISqlServerDatabase database, IRepository<Owner> owners)
        {
            this.InitializeComponent();
            this.database = database;
            this.owners = owners;
        }

        private void AddOwnerButton_Click(object sender, RoutedEventArgs e)
        {

            var firstName = this.ownerFirstName.Text;
            var lastName = this.ownerLastName.Text;
            var netWorth = this.ownerNetWorth.Text;

            if (netWorth.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Net worth cannot contain chars other than numbers!");
            }
            else
            {
                this.owners.Add(new Owner()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    NetWorth = netWorth
                });

                this.database.Commit();

                MessageBox.Show("Owner successfully added!");
                this.Close();
            }
        }
    }
}
