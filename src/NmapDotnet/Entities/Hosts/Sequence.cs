using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    public class Sequence
    {
        [XmlAttribute("class")]
        public string? Class { get; set; }

        [XmlAttribute("values")]
        public string? Values { get; set; }
    }
}
