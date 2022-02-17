using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    /// <summary>
    /// Target represents a target, how it was specified when passed to nmap,
    /// its status and the reason for its status. Example:
    /// <target specification="domain.does.not.exist" status="skipped" reason="invalid"/>
    /// </summary>
    public class Target
    {
        [XmlAttribute("specification")]
        public string? Specification { get; set; }

        [XmlAttribute("status")]
        public string? Status { get; set; }

        [XmlAttribute("reason")]
        public string? Reason { get; set; }
    }
}
