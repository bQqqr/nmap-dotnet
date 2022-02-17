using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Hostname is a name for a host.
    /// </summary>
    public class Hostname
    {
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("type")]
        public string? Type { get; set; }
    }
}
