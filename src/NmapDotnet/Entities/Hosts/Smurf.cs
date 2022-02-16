using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    public class Smurf
    {
        [XmlAttribute("responses")]
        public List<string>? Responses { get; set; }
    }
}
