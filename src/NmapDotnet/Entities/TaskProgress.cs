using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    /// <summary>
    /// TaskProgress contains information about the progression of a task.
    /// </summary>
    public class TaskProgress
    {
        [XmlAttribute("specification")]
        public float Percent { get; set; }

        [XmlAttribute("remaining")]
        public int Remaining { get; set; }

        [XmlAttribute("task")]
        public string? Task { get; set; }

        [XmlAttribute("etc")]
        public string? Etc { get; set; }

        [XmlAttribute("time")]
        public string? Time { get; set; }
    }
}
