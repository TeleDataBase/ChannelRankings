using System;
using System.Collections.Generic;
using ChannelRankings.Models.Authorities;
using ChannelRankings.Models.Contracts;

namespace ChannelRankings.Models
{
    public class Owner : IPerson
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NetWorth { get; set; }

        public virtual ICollection<Corporation> Corporations { get; set; }
    }
}
