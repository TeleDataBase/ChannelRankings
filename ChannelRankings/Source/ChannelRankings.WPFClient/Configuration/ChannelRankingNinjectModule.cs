using Ninject.Modules;
using ChannelRankins.Contracts.Data;
using ChannelRankings.Models;
using ChannelRankings.Data;
using ChannelRankings.Models.Authorities;
using ChannelRankings.Utils;
using ChannelRankings.Utils.Readers;

namespace ChannelRankings.WPFClient.Configuration
{
    public class ChannelRankingNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ISqlServerDatabase>().To<SqlServerDataProvider>().InSingletonScope();
            this.Bind<IDbContext>().To<SqlServerDbContext>().InSingletonScope();
            this.Bind<IDbManipulationManager>().To<DbManipulationManager>().InSingletonScope();
            this.Bind<IDatabaseReader>().To<DatabaseReader>().InSingletonScope();

            this.Bind<IRepository<Owner>>().To<GenericRepository<Owner>>().InSingletonScope();
            this.Bind<IRepository<Channel>>().To<GenericRepository<Channel>>().InSingletonScope();
            this.Bind<IRepository<Country>>().To<GenericRepository<Country>>().InSingletonScope();
            this.Bind<IRepository<Corporation>>().To<GenericRepository<Corporation>>().InSingletonScope();
            this.Bind<IRepository<Sponsor>>().To<GenericRepository<Sponsor>>().InSingletonScope();
        }
    }
}
