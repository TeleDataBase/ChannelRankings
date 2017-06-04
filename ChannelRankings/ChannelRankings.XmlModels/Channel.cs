using System;
using System.Collections.Generic;
using ChannelRankings.XmlModels.Authorities;

namespace ChannelRankings.XmlModels
{
    public class Channel
    {
        public string Name { get; set; }

        public virtual Corporation Corporation { get; set; }

        public virtual Country Country { get; set; }

        public virtual IList<Sponsor> Sponsors { get; set; }
    }
}
