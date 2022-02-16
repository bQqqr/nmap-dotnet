using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Distance is the amount of hops to a particular host.
    /// </summary>
    public class Distance
    {
        [XmlAttribute("value")]
        public int Value { get; set; }
    }
}
