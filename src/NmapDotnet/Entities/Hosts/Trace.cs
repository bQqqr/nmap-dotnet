using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    public class Trace
    {
        [XmlAttribute("proto")]
        public string? Proto { get; set; }

        [XmlAttribute("port")]
        public string? Port { get; set; }

        [XmlElement("hop")]
        public List<Hop>? Hops { get; set; }
    }

    public class Hop
    {
        [XmlAttribute("ttl")]
        public float TTL { get; set; }

        [XmlAttribute("rtt")]
        public string? RTT { get; set; }

        [XmlAttribute("ipaddr")]
        public string? IPAddr { get; set; }

        [XmlAttribute("host")]
        public string? Host { get; set; }
    }
}
