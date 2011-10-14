using XLog.DefaultAdapter.Console;

namespace XLog.StartupStrategy
{
    public class DefaultStratagy : IStartupStrategy
    {
        public bool TryGetFactory(out ILogFactory factory, out string errors)
        {
            factory = new DefaultLogFactory();
            errors = null;
            return true;
        }
    }
}