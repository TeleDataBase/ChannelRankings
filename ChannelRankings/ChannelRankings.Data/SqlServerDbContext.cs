using System;
using System.Data.Entity;
using ChannelRankings.Models.Authorities;
using ChannelRankings.Models;

namespace ChannelRankings.Data
{
    public class SqlServerDbContext : DbContext
    {
        private static readonly string DbConnectionName = "ChannelRankingsConnection";

        public SqlServerDbContext()
                    :base(DbConnectionName)
        {
        }

        IDbSet<Corporation> Corporations { get; set; }

        IDbSet<Sponsor> Sponsors { get; set; }

        IDbSet<Channel> Channels { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Owner> Owners { get; set; }
    }
}
