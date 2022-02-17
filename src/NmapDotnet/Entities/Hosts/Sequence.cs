using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Sequence represents a detected sequence.
    /// </summary>
    public class Sequence
    {
        [XmlAttribute("class")]
        public string? Class { get; set; }

        [XmlAttribute("values")]
        public string? Values { get; set; }
    }
}
