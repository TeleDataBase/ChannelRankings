using System;
using System.Data.Entity;
using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;
using System.Data.Entity.Infrastructure;

namespace ChannelRankins.Contracts.Data
{
    public interface IDbContext
    {
        IDbSet<Corporation> Corporations { get; set; }

        IDbSet<Sponsor> Sponsors { get; set; }

        IDbSet<Channel> Channels { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Owner> Owners { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry Entry<T>(T entity) where T : class;

        int SaveChanges();

        void Dispose();
    }
}
