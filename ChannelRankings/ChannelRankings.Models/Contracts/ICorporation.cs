using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Models.Contracts
{
    public interface ICorporation
    {
        int Id { get; set; }

        string Name { get; set; }

        IOwner Owner { get; set; }
    }
}
