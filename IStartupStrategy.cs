namespace XLog
{
    public interface IStartupStrategy
    {
        bool TryGetFactory(out ILogFactory factory, out string errors);
    }
}