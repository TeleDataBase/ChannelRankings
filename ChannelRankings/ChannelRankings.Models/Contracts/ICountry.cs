using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Models.Contracts
{
    public interface ICountry
    {
        int Id { get; set; }

        string Name { get; set; }

        ICollection<IChannel> Channels { get; set; }
    }
}
