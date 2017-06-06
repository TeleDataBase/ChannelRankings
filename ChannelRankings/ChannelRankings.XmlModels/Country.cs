using System;
using System.Xml.Serialization;

namespace ChannelRankings.XmlModels
{
    public class Country
    {
        [XmlElement("countryName")]
        public string Name { get; set; }


    }
}
