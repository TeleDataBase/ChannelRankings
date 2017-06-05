using ChannelRankings.Models.Contracts;
using System;
using System.Collections.Generic;

namespace ChannelRankings.Models.Authorities
{
    public class Sponsor : ISponsor
    {
        private ICollection<IChannel> channels;

        public Sponsor()
        {
            this.channels = new HashSet<IChannel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string About { get; set; }

        public virtual ICollection<IChannel> Channels
        {
            get
            {
                return this.channels;
            }

            set
            {
                this.channels = value;
            }
        }
    }
}
