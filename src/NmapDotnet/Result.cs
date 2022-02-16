using NmapDotnet.Entities;

namespace NmapDotnet
{
    public class Result
    {
        public string? Output { get; set; }
        public string? Errors { get; set; }
        public NmapRun? Run { get; set; }
    }
}
