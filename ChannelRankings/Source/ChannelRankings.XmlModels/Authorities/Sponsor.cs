using System;
using System.Xml.Serialization;

namespace ChannelRankings.XmlModels.Authorities
{
    [XmlRoot("sponsor")]
    public class Sponsor
    {
        [XmlElement("sponsorName")]
        public string Name { get; set; }

        [XmlElement("sponsorDescription")]
        public string About { get; set; }
    }
}
