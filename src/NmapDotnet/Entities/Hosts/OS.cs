using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// OS contains the fingerprinted operating system for a host.
    /// </summary>
    public class OS
    {
        [XmlElement("portsused")]
        public List<PortUsed>? PortsUsed { get; set; }

        [XmlElement("osmatch")]
        public List<OSMatch>? OSMatches { get; set; }

        [XmlElement("osfingerprint")]
        public List<OSFingerprint>? OSFingerprints { get; set; }
    }

    /// <summary>
    /// PortUsed is the port used to fingerprint an operating system.
    /// </summary>
    public class PortUsed
    {
        [XmlAttribute("state")]
        public string? State { get; set; }

        [XmlAttribute("proto")]
        public string? Proto { get; set; }

        [XmlAttribute("portid")]
        public int ID { get; set; }
    }

    /// <summary>
    /// OSMatch contains detailed information regarding an operating system fingerprint.
    /// </summary>
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

    /// <summary>
    /// OSClass contains vendor information about an operating system.
    /// </summary>
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

        [XmlElement("cpe")]
        public List<string>? CPEs { get; set; }
    }

    /// <summary>
    /// OSFingerprint is the actual fingerprint string of an operating system.
    /// </summary>
    public class OSFingerprint
    {
        [XmlAttribute("fingerprint")]
        public string? Fingerprint { get; set; }
    }
}
