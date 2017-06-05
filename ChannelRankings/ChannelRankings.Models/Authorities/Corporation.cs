using ChannelRankings.Models.Contracts;
using System;

namespace ChannelRankings.Models.Authorities
{
    public class Corporation : ICorporation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IOwner Owner { get; set; }
    }
}
