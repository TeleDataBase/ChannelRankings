using System;
using System.Collections.Generic;

namespace ChannelRankings.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Channel> Channels { get; set; }
    }
}
