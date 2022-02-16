namespace NmapDotnet
{
    public interface IEnviromentSetupStage
    {
        IArgumentSelectionStage WithEnviroment(Action<Enviroment> env);
    }

    public interface IArgumentSelectionStage
    {
        IExecutionStage WithArguments(Action<Arguments> args);
    }

    public interface IExecutionStage
    {
        Task<Result> ExecuteAsync();
    }
}
