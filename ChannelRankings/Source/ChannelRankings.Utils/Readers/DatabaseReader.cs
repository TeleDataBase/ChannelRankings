using ChannelRankings.Models;
using ChannelRankins.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChannelRankings.Utils.Readers
{
    public class DatabaseReader : IDatabaseReader
    {
        private IRepository<Country> countries;
        private IRepository<Channel> channels;
        private IRepository<Owner> owners;

        public DatabaseReader(IRepository<Country> countries, IRepository<Channel> channels, IRepository<Owner> owners)
        {
            this.countries = countries;
            this.channels = channels;
            this.owners = owners;
        }

        public List<Tuple<int, int, string>> GetFormattedChannels()
        {
            var channels = this.channels.GetAll()
                .Select(x => new Tuple<int, int, string>(
                    x.Id,
                    x.WorldRankplace,
                    x.Name
                ))
                .ToList();

            return channels;
        }

        public List<Tuple<int, string>> GetFormattedCountries()
        {
            var countries = this.countries.GetAll()
                .Select(x => new Tuple<int, string>(
                    x.Id,
                    x.Name
                ))
                .ToList();

            return countries;
        }

        public List<Tuple<int, string, string, string>> GetFormattedOwners()
        {
            var owners = this.owners.GetAll()
                .Select(x => new Tuple<int, string, string, string>(
                    x.Id,
                    x.FirstName,
                    x.LastName,
                    x.NetWorth
                ))
                .ToList();

            return owners;
        }
    }
}
