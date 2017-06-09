using ChannelRankings.WPFClient.Configuration;
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ChannelRankings.WPFClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel kernel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.ConfigureContainer();
            Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            this.kernel = new StandardKernel(new ChannelRankingNinjectModule());
            this.MainWindow = this.kernel.Get<MainWindow>();
        }
    }

    
}
