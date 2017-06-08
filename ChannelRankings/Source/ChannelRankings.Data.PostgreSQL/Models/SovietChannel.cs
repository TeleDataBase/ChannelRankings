using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Data.PostgreSQL.Models
{
    public class SovietChannel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public int SvoietRankplace { get; set; }

        [Required]
        public Director Director { get; set; }

        
        public virtual Country Country { get; set; }
    }
}
