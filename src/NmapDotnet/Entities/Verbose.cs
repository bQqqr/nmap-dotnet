using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    /// <summary>
    /// Verbose contains the verbosity level of the scan.
    /// </summary>
    public class Verbose
    {
        [XmlAttribute("level")]
        public int Level { get; set; }
    }
}
