using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    public class Hostname
    {
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("type")]
        public string? Type { get; set; }
    }
}
