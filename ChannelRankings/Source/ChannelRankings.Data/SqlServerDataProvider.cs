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

        private IRepository<Corporation> corporations;
        private IRepository<Sponsor> sponsors;
        private IRepository<Channel> channels;
        private IRepository<Country> countries;
        private IRepository<Owner> owners;

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

        public IRepository<Corporation> Corporations
        {
            get
            {
                if (this.corporations == null)
                {
                    this.corporations = new GenericRepository<Corporation>(this.Context);
                }

                return this.corporations;
            }
        }

        public IRepository<Sponsor> Sponsors
        {
            get
            {
                if (this.sponsors == null)
                {
                    this.sponsors = new GenericRepository<Sponsor>(this.Context);
                }

                return this.sponsors;
            }
        }

        public IRepository<Channel> Channels
        {

            get
            {
                if (this.channels == null)
                {
                    this.channels = new GenericRepository<Channel>(this.Context);
                }

                return this.channels;
            }
        }

        public IRepository<Country> Countries
        {
            get
            {
                if (this.countries == null)
                {
                    this.countries = new GenericRepository<Country>(this.Context);
                }

                return this.countries;
            }
        }

        public IRepository<Owner> Owners
        {
            get
            {
                if (this.owners == null)
                {
                    this.owners = new GenericRepository<Owner>(this.Context);
                }

                return this.owners;
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
