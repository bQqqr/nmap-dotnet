using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Smurf contains responses from a smurf attack.
    /// </summary>
    public class Smurf
    {
        [XmlAttribute("responses")]
        public List<string>? Responses { get; set; }
    }
}
