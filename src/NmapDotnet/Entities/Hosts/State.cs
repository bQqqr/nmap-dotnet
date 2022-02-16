using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
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
