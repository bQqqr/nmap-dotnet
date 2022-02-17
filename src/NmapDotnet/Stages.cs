namespace NmapDotnet
{
    public interface ISetupStage
    {
        IExecutionStage WithOptions(Action<Configuration> config);
    }

    public interface IExecutionStage
    {
        Task<Result> ExecuteAsync();
    }
}
