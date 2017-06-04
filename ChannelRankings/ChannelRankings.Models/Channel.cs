using System;
using ChannelRankings.Models.Authorities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChannelRankings.Models
{
    public class Channel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public virtual Corporation Corporation { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Sponsor> Sponsors { get; set; }
    }
}
