using System.Data.Entity;
using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;
using System.Data.Entity.Infrastructure;

namespace ChannelRankins.Contracts.Data
{
    public interface IDbContext
    {
        DbSet<Corporation> Corporations { get; set; }

        DbSet<Sponsor> Sponsors { get; set; }

        DbSet<Channel> Channels { get; set; }

        DbSet<Country> Countries { get; set; }

        DbSet<Owner> Owners { get; set; }

        DbSet<T> Set<T>() where T : class;

        DbEntityEntry Entry<T>(T entity) where T : class;

        int SaveChanges();

        void Dispose();
    }
}
