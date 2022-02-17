using System.Xml.Serialization;

namespace NmapDotnet.Entities.Scripts
{
    /// <summary>
    /// Script represents an Nmap Scripting Engine script.
    /// The inner elements can be an arbitrary collection
    /// of Tables and Elements. Both of them can also be
    /// empty.
    /// </summary>
    public class Script
    {
        [XmlAttribute("id")]
        public string? ID { get; set; }

        [XmlAttribute("output")]
        public string? Output { get; set; }

        [XmlElement("elem")]
        public List<Element>? Elements { get; set; }

        [XmlElement("table")]
        public List<Table>? Tables { get; set; }
    }

    /// <summary>
    /// Element is the smallest building block for scripts/tables. 
    /// It can optionally(!) have a key.
    /// </summary>
    public class Element
    {
        [XmlText]
        public string? Value { get; set; }

        [XmlAttribute("key")]
        public string? Key { get; set; }
    }

    /// <summary>
    /// Table is an arbitrary collection of (sub-)Tables and
    /// Elements. All its fields can be empty
    /// </summary>
    public class Table
    {
        [XmlAttribute("key")]
        public string? Key { get; set; }

        [XmlElement("table")]
        public List<Table>? Tables { get; set; }

        [XmlElement("elem")]
        public List<Element>? Elements { get; set; }
    }
}
