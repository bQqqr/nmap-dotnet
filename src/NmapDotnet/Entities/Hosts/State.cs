using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// State contains information about a given port's status
    /// State will be open, closed, etc.
    /// </summary>
    public class State
    {
        [XmlAttribute("state")]
        public string? State_ { get; set; }

        [XmlAttribute("reason")]
        public string? Reason { get; set; }

        [XmlAttribute("reason_ip")]
        public string? ReasonIP { get; set; }

        [XmlAttribute("reason_ttl")]
        public float ReasonTTL { get; set; }
    }
}
