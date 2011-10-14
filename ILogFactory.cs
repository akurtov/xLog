namespace XLog
{
    public interface ILogFactory
    {
        ILog CreateLogger(string name);
    }
}