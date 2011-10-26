using XLog.DefaultAdapter.Console;
using XLog.StartupStrategy;

namespace XLog
{
    public class LogPoolBuilder
    {
        public LogPool Build()
        {
            var logFactory = getLogFactory();
            return new LogPool(logFactory);
        }

        private ILogFactory getLogFactory()
        {
            ILogFactory factory;
            string errors;

            if (new AppConfigStrategy().TryGetFactory(out factory, out errors))
            {
                return factory;
            }

            factory = new DefaultLogFactory();
            factory.CreateLogger("LogInitializer").Info(errors);
            return factory;
        }
    }
}