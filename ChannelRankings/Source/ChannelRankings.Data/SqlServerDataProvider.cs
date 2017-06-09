using System;
using ChannelRankins.Contracts.Data;
using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;

namespace ChannelRankings.Data
{
    // A.K.A UnitOfWork
    public class SqlServerDataProvider : ISqlServerDatabase
    {
        private IDbContext context;

        public SqlServerDataProvider(IDbContext context)
        {
            this.context = context;
        }

        public IDbContext Context
        {
            get
            {
                return this.context;
            }
        }

        public void Commit()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
