using System;
using ChannelRankings.Models.Contracts;
using System.Collections.Generic;
using ChannelRankings.Models.Authorities;

namespace ChannelRankings.Models
{
    public class Owner : IPerson, IOwner
    {
        private ICollection<ICorporation> corporations;

        public Owner()
        {
            this.corporations = new HashSet<ICorporation>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NetWorth { get; set; }

        public virtual ICollection<ICorporation> Corporations
        {
            get
            {
                return this.corporations;
            }

            set
            {
                this.corporations = value;
            }
        }
    }
}
