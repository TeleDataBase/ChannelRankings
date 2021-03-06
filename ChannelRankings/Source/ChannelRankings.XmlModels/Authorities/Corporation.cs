﻿using System;
using System.Xml.Serialization;

namespace ChannelRankings.XmlModels.Authorities
{
    public class Corporation
    {
        [XmlElement("corporationName")]
        public string Name { get; set; }

        [XmlElement("owner")]
        public virtual Owner Owner { get; set; }
    }
}
