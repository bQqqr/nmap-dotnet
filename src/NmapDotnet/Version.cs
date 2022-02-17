namespace NmapDotnet
{
    public class Version
    {
        public string GetQualifiedVersion()
        {
            return $"Nmap .NET (v{GetVersion()})";
        }

        public string GetVersion()
        {
            return GetType().Assembly.GetName().Version!.ToString(3);
        }
    }
}
