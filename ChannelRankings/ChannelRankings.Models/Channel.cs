using ChannelRankings.Models.Authorities;
using ChannelRankings.Models.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChannelRankings.Models
{
    public class Channel : IChannel
    {
        private ICollection<ISponsor> sponsors;

        public Channel()
        {
            this.sponsors = new HashSet<ISponsor>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public virtual ICorporation Corporation { get; set; }

        [Required]
        public virtual ICountry Country { get; set; }

        public virtual ICollection<ISponsor> Sponsors { get; set; }
    }
}
