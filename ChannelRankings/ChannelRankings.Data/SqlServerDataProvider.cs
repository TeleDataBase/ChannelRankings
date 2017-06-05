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

        //public IRepository<Corporation> Corporations
        //{
        //    get
        //    {
        //        return this.GetRepository<Corporation>();
        //    }
        //}


        public IRepository<Corporation> Corporations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Sponsor> Sponsors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Channel> Channels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Country> Countries { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Owner> Owners { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //private IRepository<T> GetRepository<T>()
        //{
        //    var type = typeof(T);

        //    return Repository<type>
        //}

        public void Commit()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
