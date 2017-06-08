using System;
using System.Collections.Generic;

namespace ChannelRankings.Models.Authorities
{
    public class Sponsor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string About { get; set; }

        public virtual ICollection<Channel> Channels { get; set; }
    }
}
