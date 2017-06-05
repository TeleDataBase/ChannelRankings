using System;
using System.Collections.Generic;
using ChannelRankings.Models.Authorities;

namespace ChannelRankings.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NetWorth { get; set; }

        public virtual ICollection<Corporation> Corporations { get; set; }
    }
}
