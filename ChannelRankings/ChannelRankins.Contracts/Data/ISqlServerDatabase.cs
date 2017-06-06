using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;

namespace ChannelRankins.Contracts.Data
{
    public interface ISqlServerDatabase
    {
        IRepository<Corporation> Corporations { get; }

        IRepository<Sponsor> Sponsors { get; }

        IRepository<Channel> Channels { get; }

        IRepository<Country> Countries { get; }

        IRepository<Owner> Owners { get; }

        void Commit();

        void Dispose();
    }
}
