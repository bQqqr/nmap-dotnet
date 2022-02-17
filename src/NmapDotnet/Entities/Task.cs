using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    /// <summary>
    /// Task contains information about a task.
    /// </summary>
    public class Task
    {
        [XmlAttribute("timestamp")]
        public string? Timestamp { get; set; }

        [XmlAttribute("task")]
        public string? Task_ { get; set; }

        [XmlAttribute("specification")]
        public string? ExtraInfo { get; set; }
    }
}
