using ChannelRankings.Models.Authorities;
using ChannelRankings.XmlModels;
using System;
using System.Collections.Generic;

namespace ChannelRankins.Contracts.Utils
{
    public interface IChannelModelMapper
    {
        Channel CreateChannel(string name, Corporation corporation, Country country, ICollection<Sponsor> sponsors);

        Corporation CreateCorporation(string name, Owner owner);

        Sponsor CreateSponsor(string name, string about);

        Country CreateCountry(string name);

        Owner CreateOwner(string firstName, string lastName, string netWorth);
    }
}
