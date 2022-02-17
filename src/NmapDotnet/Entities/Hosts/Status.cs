using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Status represents a host's status.
    /// </summary>
    public class Status
    {
        [XmlAttribute("state")]
        public string? State_ { get; set; }

        [XmlAttribute("reason")]
        public string? Reason { get; set; }

        [XmlAttribute("reasonttl")]
        public float ReasonTTL { get; set; }
    }
}
