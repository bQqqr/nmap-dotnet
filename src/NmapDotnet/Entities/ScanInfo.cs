using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    /// <summary>
    /// ScanInfo represents the scan information.
    /// </summary>
    public class ScanInfo
    {
        [XmlAttribute("numservices")]
        public int NumServices { get; set; }

        [XmlAttribute("protocol")]
        public string? Protocol { get; set; }

        [XmlAttribute("scanflags")]
        public string? ScanFlags { get; set; }

        [XmlAttribute("services")]
        public string? Services { get; set; }

        [XmlAttribute("type")]
        public string? Type { get; set; }
    }
}
