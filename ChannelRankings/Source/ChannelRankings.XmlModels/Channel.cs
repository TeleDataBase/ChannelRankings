using System.Collections.Generic;
using System.Xml.Serialization;
using ChannelRankings.XmlModels.Authorities;

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
