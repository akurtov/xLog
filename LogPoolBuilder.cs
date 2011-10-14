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

            new DefaultStratagy().TryGetFactory(out factory, out errors);
            factory.CreateLogger("LogInitializer").Info(errors);
            return factory;
        }
    }
}