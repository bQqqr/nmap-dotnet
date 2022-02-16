using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    public class OS
    {
        [XmlElement("portsused")]
        public List<PortUsed>? PortsUsed { get; set; }

        [XmlElement("osmatch")]
        public List<OSMatch>? OSMatches { get; set; }

        [XmlElement("osfingerprint")]
        public List<OSFingerprint>? OSFingerprints { get; set; }
    }

    public class PortUsed
    {
        [XmlAttribute("state")]
        public string? State { get; set; }

        [XmlAttribute("proto")]
        public string? Proto { get; set; }

        [XmlAttribute("portid")]
        public int ID { get; set; }
    }

    public class OSMatch
    {
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("accuracy")]
        public int Accuracy { get; set; }

        [XmlAttribute("line")]
        public int Line { get; set; }

        [XmlElement("osclass")]
        public List<OSClass>? Classes { get; set; }

    }

    public class OSClass
    {
        [XmlAttribute("vendor")]
        public string? Vendor { get; set; }

        [XmlAttribute("osgen")]
        public string? OSGeneration { get; set; }

        [XmlAttribute("type")]
        public string? Type { get; set; }

        [XmlAttribute("accuracy")]
        public int Accuracy { get; set; }

        [XmlAttribute("osfamily")]
        public string? Family { get; set; }

        [XmlAttribute("cpe")]
        public List<string>? CPEs { get; set; }
    }

    public class OSFingerprint
    {
        [XmlAttribute("fingerprint")]
        public string? Fingerprint { get; set; }
    }
}
