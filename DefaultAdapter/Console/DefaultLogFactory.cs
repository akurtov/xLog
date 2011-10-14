namespace XLog.DefaultAdapter.Console
{
    public class DefaultLogFactory : ILogFactory
    {
        public ILog CreateLogger(string name)
        {
            return new ConsoleLogger(name);
        }
    }
}