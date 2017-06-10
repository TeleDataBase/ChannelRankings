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
    /// Interaction logic for UpdateChannel.xaml
    /// </summary>
    public partial class UpdateChannel : Window
    {
        private ISqlServerDatabase database;
        private IRepository<Channel> channels;

        public UpdateChannel(ISqlServerDatabase database, IRepository<Channel> channels)
        {
            this.InitializeComponent();
            this.database = database;
            this.channels = channels;
        }

        private void UpdateChannelButton_Click(object sender, RoutedEventArgs e)
        {
            var channelId = int.Parse(this.channelId.Text);
            var channelToUpdate = this.channels.GetById(channelId);

            var newChannelName = string.IsNullOrEmpty(this.channelName.Text) ? channelToUpdate.Name : this.channelName.Text;
            var newChannelRankplace = string.IsNullOrEmpty(this.channelRankplace.Text) ?
                channelToUpdate.WorldRankplace : int.Parse(this.channelRankplace.Text);

            channelToUpdate.Name = newChannelName;
            channelToUpdate.WorldRankplace = newChannelRankplace;
            channelToUpdate.Country = channelToUpdate.Country;

            this.channels.Update(channelToUpdate);
            this.database.Commit();

            MessageBox.Show("Channel updated successfully!");
            this.Close();
        }
    }
}
