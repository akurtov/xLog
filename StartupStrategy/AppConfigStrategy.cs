using System;
using System.Configuration;

namespace XLog.StartupStrategy
{
    public class AppConfigStrategy : IStartupStrategy
    {
        private const string CONFIG_KEY = "LogFactory";

        public bool TryGetFactory(out ILogFactory factory, out string errors)
        {
            factory = null;
            errors = null;

            var typeName = ConfigurationManager.AppSettings[CONFIG_KEY];
            if (string.IsNullOrEmpty(typeName))
            {
                errors = "Log assembly not found. Loaded default logger.";
                return false;
            }

            var type = Type.GetType(typeName);
            if (type == null)
            {
                errors = "Type - '{0}' not found.";
                return false;
            }

            factory = Activator.CreateInstance(type) as ILogFactory;
            if (factory == null)
            {
                errors = "Type - '{0}' is not implemented ILogFactory.";
                return false;
            }

            return true;
        }
    }
}