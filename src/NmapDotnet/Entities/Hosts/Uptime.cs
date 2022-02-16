using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    public class Uptime
    {
        [XmlAttribute("seconds")]
        public int Seconds { get; set; }

        [XmlAttribute("lastboot")]
        public string? Lastboot { get; set; }
    }
}
