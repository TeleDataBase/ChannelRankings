using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Models.Contracts
{
    public interface IChannel
    {
         int Id { get; set; }
        
         string Name { get; set; }

         ICorporation Corporation { get; set; }

         ICountry Country { get; set; }

         ICollection<ISponsor> Sponsors { get; set; }
    }
}
