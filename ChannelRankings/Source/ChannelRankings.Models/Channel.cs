using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ChannelRankings.Models.Authorities;

namespace ChannelRankings.Models
{
    public class Channel 
    {

        public Channel()
        {
            this.Sponsors = new HashSet<Sponsor>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public int WorldRankplace { get; set; }

        public virtual Corporation Corporation { get; set; }

        [Required]
        public virtual Country Country { get; set; }

        public virtual ICollection<Sponsor> Sponsors { get; set; }
    }
}
