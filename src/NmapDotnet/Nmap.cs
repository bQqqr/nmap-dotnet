using System.Text;
using System.Xml.Serialization;

using CliWrap;

using NmapDotnet.Entities;

namespace NmapDotnet
{
    public class Nmap : IEnviromentSetupStage, IArgumentSelectionStage, IExecutionStage
    {
        public Enviroment Env { get; set; } = new Enviroment();
        public Arguments Args { get; set; } = new Arguments();

        public static Nmap Scan() => new Nmap();

        public IArgumentSelectionStage WithEnviroment(Action<Enviroment> env)
        {
            env.Invoke(Env);
            return this;
        }

        public IExecutionStage WithArguments(Action<Arguments> args)
        {
            args.Invoke(Args);
            return this;
        }

        public async Task<Result> ExecuteAsync()
        {
            var stdOut = new StringBuilder();
            var stdErr = new StringBuilder();

            var result = await Cli.Wrap(Env.NmapExecutablePath)
                .WithArguments("-oX -" + " " + Args.Options)
                .WithWorkingDirectory(Env.WorkingDirectoryPath)
                .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOut))
                .WithStandardErrorPipe(PipeTarget.ToStringBuilder(stdErr))
                .ExecuteAsync();

            var serializer = new XmlSerializer(typeof(NmapRun));

            using var reader = new StringReader(stdOut.ToString());

            var nmapRun = (NmapRun?)serializer.Deserialize(reader);

            return new Result { Output = stdOut.ToString(), Errors = stdErr.ToString(), Run = nmapRun };
        }
    }
}
