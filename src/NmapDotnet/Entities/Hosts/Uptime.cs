using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Uptime is the amount of time the host has been up.
    /// </summary>
    public class Uptime
    {
        [XmlAttribute("seconds")]
        public int Seconds { get; set; }

        [XmlAttribute("lastboot")]
        public string? Lastboot { get; set; }
    }
}
