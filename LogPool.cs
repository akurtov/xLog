using System.Collections.Concurrent;

namespace XLog
{
    public class LogPool
    {
        private readonly ILogFactory _factory;
        private readonly ConcurrentDictionary<string, ILog> _source;
  
        public LogPool(ILogFactory factory)
        {
            _factory = factory;
            _source = new ConcurrentDictionary<string, ILog>();
        }

        public ILog GetLogger(string name)
        {
            return _source.GetOrAdd(name, newName =>  _factory.CreateLogger(newName));
        }
    }
}