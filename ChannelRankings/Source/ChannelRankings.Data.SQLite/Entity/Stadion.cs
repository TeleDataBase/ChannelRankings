﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChannelRankings.Data.SQLite.Entity
{
    public class Stadion
    {
        [Key]
        [Column(Order = 1)]
        [Index("IX_Stadion_Main", Order = 2, IsUnique = true)] // Test for combined, named index
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [Index("IX_Stadion_Main", Order = 1, IsUnique = true)] // Test for combined, named index
        public string Street { get; set; }

        [Key]
        [Column(Order = 3)]
        public string City { get; set; }
    }
}
