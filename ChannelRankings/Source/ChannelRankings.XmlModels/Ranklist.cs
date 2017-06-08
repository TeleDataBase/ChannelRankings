using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChannelRankings.XmlModels
{
    [XmlRoot("channelRanklist")]
    public class Ranklist
    {
        [XmlElement("channel")]
        public virtual List<Channel> Channels { get; set; }
    }
}
