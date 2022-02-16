using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    public class Verbose
    {
        [XmlAttribute("level")]
        public int Level { get; set; }
    }
}
