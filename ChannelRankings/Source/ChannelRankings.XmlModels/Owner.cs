using System;
using System.Xml.Serialization;

namespace ChannelRankings.XmlModels
{
    public class Owner
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("netWorth")]
        public string NetWorth { get; set; }
    }
}
