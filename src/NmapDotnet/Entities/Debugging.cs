using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    /// <summary>
    /// Debugging contains the debugging level of the scan.
    /// </summary>
    public class Debugging
    {
        [XmlAttribute("level")]
        public string? Level { get; set; }
    }
}
