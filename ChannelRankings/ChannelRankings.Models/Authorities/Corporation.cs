using System;

namespace ChannelRankings.Models.Authorities
{
    public class Corporation
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public virtual Owner Owner { get; set; }
    }
}
