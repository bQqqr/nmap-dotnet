using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    public class Debugging
    {
        [XmlAttribute("level")]
        public string? Level { get; set; }
    }
}
