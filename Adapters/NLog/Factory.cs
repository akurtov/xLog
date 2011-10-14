using XLog;

namespace NLogAdapter
{
    public class Factory : ILogFactory
    {
        public ILog CreateLogger(string name)
        {
            return new NLogAdapter(name);
        }
    }
}
