using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;
using ChannelRankins.Contracts.Utils;
using System.Collections.Generic;

namespace ChannelRankings.Utils.ModelFactory
{
    public class ChannelModelMapper : IChannelModelMapper
    {
        public Channel CreateChannel(string name, int worldRankplace, Corporation corporation, Country country, ICollection<Sponsor> sponsors)
        {
            var channel = new Channel()
            {
                Name = name,
                WorldRankplace = worldRankplace,
                Corporation = corporation,
                Country = country,
                Sponsors = sponsors
            };

            return channel;
        }

        public Corporation CreateCorporation(string name, Owner owner)
        {
            var corporation = new Corporation()
            {
                Name = name,
                Owner = owner
            };

            return corporation;
        }

        public Sponsor CreateSponsor(string name, string about)
        {
            var sponsor = new Sponsor()
            {
               Name = name,
               About = about
            };

            return sponsor;
        }

        public Country CreateCountry(string name)
        {
            var country = new Country()
            {
                Name = name
            };

            return country;
        }

        public Owner CreateOwner(string firstName, string lastName, string netWorth)
        {
            var owner = new Owner()
            {
                FirstName = firstName,
                LastName = lastName,
                NetWorth = netWorth
            };

            return owner;
        }
    }
}
