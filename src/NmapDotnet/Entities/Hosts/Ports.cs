using System.Xml.Serialization;

using NmapDotnet.Entities.Scripts;

namespace NmapDotnet.Entities.Hosts
{
    public class PortsSection
    {
        [XmlElement("extraports")]
        public List<ExtraPort>? Extraports { get; set; }

        [XmlElement("port")]
        public List<Port>? Ports { get; set; }
    }

    /// <summary>
    /// Port contains all the information about a scanned port.
    /// </summary>
    public class Port
    {
        [XmlAttribute("portid")]
        public UInt16 ID { get; set; }

        [XmlAttribute("protocol")]
        public string? Protocol { get; set; }

        [XmlElement("owner")]
        public Owner? Owner { get; set; }

        [XmlElement("service")]
        public Service? Service { get; set; }

        [XmlElement("state")]
        public State? State { get; set; }

        [XmlElement("script")]
        public List<Script>? Scripts { get; set; }
    }

    /// <summary>
    /// Owner contains the name of a port's owner.
    /// </summary>
    public class Owner
    {
        [XmlAttribute("name")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// Service contains detailed information about a service on an open port.
    /// </summary>
    public class Service
    {
        [XmlAttribute("devicetype")]
        public string? DeviceType { get; set; }

        [XmlAttribute("extrainfo")]
        public string? ExtraInfo { get; set; }

        [XmlAttribute("highver")]
        public string? HighVersion { get; set; }

        [XmlAttribute("hostname")]
        public string? Hostname { get; set; }

        [XmlAttribute("lowver")]
        public string? LowVersion { get; set; }

        [XmlAttribute("method")]
        public string? Method { get; set; }

        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("ostype")]
        public string? OSType { get; set; }

        [XmlAttribute("product")]
        public string? Product { get; set; }

        [XmlAttribute("proto")]
        public string? Proto { get; set; }

        [XmlAttribute("rpcnum")]
        public string? RPCNum { get; set; }

        [XmlAttribute("servicefp")]
        public string? ServiceFP { get; set; }

        [XmlAttribute("tunnel")]
        public string? Tunnel { get; set; }

        [XmlAttribute("version")]
        public string? Version { get; set; }

        [XmlAttribute("conf")]
        public int Confidence { get; set; }

        [XmlElement("cpe")]
        public List<string>? CPEs { get; set; }
    }

    /// <summary>
    /// ExtraPort contains the information about the closed and filtered ports.
    /// </summary>
    public class ExtraPort
    {
        [XmlAttribute("state")]
        public string? State { get; set; }

        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("extrareasons")]
        public List<Reason>? Reasons { get; set; }
    }

    /// <summary>
    /// Reason represents a reason why a port is closed or filtered.
    /// This won't be in the scan results unless WithReason is used.
    /// </summary>
    public class Reason
    {
        [XmlAttribute("reason")]
        public string? Reason_ { get; set; }

        [XmlAttribute("count")]
        public int Count { get; set; }
    }
}
