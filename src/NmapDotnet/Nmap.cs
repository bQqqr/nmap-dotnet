using System.Text;
using System.Xml.Serialization;

using CliWrap;

using NmapDotnet.Entities;

namespace NmapDotnet
{
    public class Nmap : ISetupStage, IExecutionStage
    {
        public Configuration Config { get; }

        public Nmap()
        {
            Config = new Configuration();
        }

        public static Nmap Scan() => new Nmap();

        public IExecutionStage WithOptions(Action<Configuration> config)
        {
            config.Invoke(Config);
            return this;
        }

        public async Task<Result> ExecuteAsync()
        {
            var stdOut = new StringBuilder();
            var stdErr = new StringBuilder();

            var result = await Cli.Wrap(Config.NmapExecutablePath)
                .WithArguments("-oX -" + " " + Config.Arguments)
                .WithWorkingDirectory(Config.WorkingDirectoryPath)
                .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOut))
                .WithStandardErrorPipe(PipeTarget.ToStringBuilder(stdErr))
                .ExecuteAsync();

            var serializer = new XmlSerializer(typeof(NmapRun));

            using var reader = new StringReader(stdOut.ToString());

            var nmapRun = (NmapRun?)serializer
                .Deserialize(reader);

            return new Result
            {
                Output = stdOut.ToString(),
                Error = stdErr.ToString(),
                Run = nmapRun
            };
        }


    }
}
