namespace NmapDotnet.Entities.Scripts
{
    public class Script
    {
        public string? ID { get; set; }
        public string? Output { get; set; }
        public List<Element>? Elements { get; set; }
        public List<Table>? Tables { get; set; }
    }

    public class Element
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
    }

    public class Table
    {
        public string? Key { get; set; }
        public List<Table>? Tables { get; set; }
        public List<Element>? Elements { get; set; }
    }
}
