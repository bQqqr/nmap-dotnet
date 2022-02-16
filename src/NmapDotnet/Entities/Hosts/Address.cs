using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Address contains a IPv4 or IPv6 address for a host.
    /// </summary>
    public class Address
    {
        [XmlAttribute("addr")]
        public string? Addr { get; set; }

        [XmlAttribute("addrtype")]
        public string? AddrType { get; set; }

        [XmlAttribute("vendor")]
        public string? Vendor { get; set; }
    }
}
