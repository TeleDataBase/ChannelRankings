using System;
using System.ComponentModel.DataAnnotations;

namespace ChannelRankings.Data.PostgreSQL.Models
{
    public class RadioChannel
    {
        public int Id { get; set; }

        [MaxLength(40)]
        [MinLength(5)]
        public string Frequency { get; set; }

        [MaxLength(40)]
        public string MainTopic { get; set; }

        public virtual Country Country { get; set; }
    }
}
