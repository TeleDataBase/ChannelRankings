using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;
using ChannelRankins.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Utils
{
    public class DbManipulationManager : IDbManipulationManager
    {
        private ISqlServerDatabase database;
        private IRepository<Channel> channels;
        private IRepository<Owner> owners;
        private IRepository<Sponsor> sponsors;
        private IRepository<Country> countries;

        public DbManipulationManager(ISqlServerDatabase database, IRepository<Owner> owners, IRepository<Sponsor> sponsors,
            IRepository<Channel> channels, IRepository<Country> countries)
        {
            this.database = database;
            this.owners = owners;
            this.sponsors = sponsors;
            this.channels = channels;
            this.countries = countries;
        }

        //public void Add
    }
}
