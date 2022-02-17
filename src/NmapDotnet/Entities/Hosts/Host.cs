using System.Xml.Serialization;

using NmapDotnet.Entities.Scripts;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Host represents a host that was scanned.
    /// </summary>
    public class Host
    {
        [XmlElement("distance")]
        public Distance? Distance { get; set; }

        [XmlAttribute("endtime")]
        public string? EndTime { get; set; }

        [XmlElement("ipidsequence")]
        public Sequence? IPIDSequence { get; set; }

        [XmlElement("os")]
        public OS? OS { get; set; }

        [XmlAttribute("starttime")]
        public string? StartTime { get; set; }

        [XmlElement("status")]
        public Status? Status { get; set; }

        [XmlElement("tcpsequence")]
        public Sequence? TCPSequence { get; set; }

        [XmlElement("tcptssequence")]
        public Sequence? TCPTSSequence { get; set; }

        [XmlElement("times")]
        public Times? Times { get; set; }

        [XmlElement("trace")]
        public Trace? Trace { get; set; }

        [XmlElement("uptime")]
        public Uptime? Uptime { get; set; }

        [XmlAttribute("comment")]
        public string? Comment { get; set; }

        [XmlElement("address")]
        public List<Address>? Addresses { get; set; }

        [XmlArray("hostnames")]
        [XmlArrayItem("hostname")]
        public List<Hostname>? Hostnames { get; set; }

        [XmlElement("hostscript>script")]
        public List<Script>? HostScripts { get; set; }

        [XmlElement("ports")]
        public PortsSection? PortsSection { get; set; }

        [XmlElement("smurf")]
        public List<Smurf>? Smurfs { get; set; }
    }
}
