using System;
using System.Collections.Generic;
using ChannelRankings.XmlModels.Authorities;
using System.Xml.Serialization;

namespace ChannelRankings.XmlModels
{
    public class Channel
    {   
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("worldRankplace")]
        public int WorldRankplace { get; set; }

        [XmlElement("corporation")]
        public virtual Corporation Corporation { get; set; }

        [XmlElement("country")]
        public virtual Country Country { get; set; }

        [XmlArray("sponsors"), XmlArrayItem("sponsor")]
        public virtual List<Sponsor> Sponsors { get; set; }
    }
}
