namespace NmapDotnet
{
    /// <summary>
    /// Information regarding an API key for the Meilisearch server.
    /// </summary>
    public class Version
    {
        /// <summary>
        /// Extracts version from Nmap.csproj.
        /// </summary>
        /// <returns>Returns a formatted version.</returns>
        public string GetQualifiedVersion()
        {
            return $"Nmap .NET (v{GetVersion()})";
        }

        /// <summary>
        /// Extracts the "major.minor.build" version from Nmap.csproj.
        /// </summary>
        /// <returns>Returns a version from the GetType as String.</returns>
        public string GetVersion()
        {
            return GetType().Assembly
                .GetName().Version!
                .ToString(3);
        }
    }
}
