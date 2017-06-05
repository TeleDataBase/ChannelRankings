using ChannelRankings.Models.Contracts;
using System;
using System.Collections.Generic;

namespace ChannelRankings.Models
{
    public class Country : ICountry
    {
        private ICollection<IChannel> channels;

        public Country()
        {
            this.channels = new HashSet<IChannel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

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
