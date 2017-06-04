using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.XmlModels.Authorities
{
    public class Corporation
    {
        public string Name { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
