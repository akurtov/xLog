namespace XLog
{
    public static class LogManager
    {
        private static readonly LogPool LogPool;

        static LogManager()
        {
            LogPool = new LogPoolBuilder().Build();
        }

        public static ILog GetLogger(string name)
        {
            return LogPool.GetLogger(name);
        }
    }
}