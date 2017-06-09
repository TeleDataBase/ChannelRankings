using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Data.SQLite.Entity
{
  public  class YouTubeChannel
    {
      [Key]
      public int Id { get; set; }

      [Required]
      [MaxLength(30)]
      public string Name { get; set; }

      [MaxLength(64)]
      public string Url { get; set; }
      
      public int Rank { get; set; }
    }
}
