using System;
using System.Collections.Generic;

namespace ChannelRankins.Contracts.Data
{
    public interface IDatabaseReader
    {
        List<Tuple<int, int, string>> GetFormattedChannels();

        List<Tuple<int, string>> GetFormattedCountries();

        List<Tuple<int, string, string, string>> GetFormattedOwners();
    }
}
