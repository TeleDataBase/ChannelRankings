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

        [XmlElement("corporationName")]
        public virtual Corporation Corporation { get; set; }

        [XmlElement("countryName")]
        public virtual Country Country { get; set; }

        public virtual IList<Sponsor> Sponsors { get; set; }
    }
}
