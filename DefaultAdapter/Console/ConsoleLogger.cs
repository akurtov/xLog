using System;

namespace XLog.DefaultAdapter.Console
{
    public class ConsoleLogger : ILog
    {
        private readonly string _name;
        private const string MESSAGE_PATTERN = "{0} [{1}] ({2}): {3}";
        
        private const string TRACE = "TRACE";
        private const string DEBUG = "DEBUG";
        private const string INFO = "INFO";
        private const string WARNING = "WARNING";
        private const string ERROR = "ERROR";
        private const string FATAL = "FATAL";

        public ConsoleLogger(string name)
        {
            _name = name;
        }

        public void Trace(string message, params object[] args)
        {
            log(TRACE, message, args);
        }

        public void Trace(Exception ex, string message = null)
        {
            logException(TRACE, message, ex);
        }

        public void Debug(string message, params object[] args)
        {
            log(DEBUG, message, args);
        }

        public void Debug(Exception ex, string message = null)
        {
            logException(DEBUG, message, ex);
        }

        public void Info(string message, params object[] args)
        {
            log(INFO, message, args);
        }

        public void Info(Exception ex, string message = null)
        {
            logException(INFO, message, ex);
        }

        public void Warn(string message, params object[] args)
        {
            log(WARNING, message, args);
        }

        public void Warn(Exception ex, string message = null)
        {
            logException(WARNING, message, ex);
        }

        public void Error(string message, params object[] args)
        {
            log(ERROR, message, args);
        }

        public void Error(Exception ex, string message = null)
        {
            logException(ERROR, message, ex);
        }

        public void Fatal(string message, params object[] args)
        {
            log(FATAL, message, args);
        }

        public void Fatal(Exception ex, string message = null)
        {
            logException(FATAL, message, ex);
        }

        private void log(string level, string message, params object[] args)
        {
            var compositeMessage = string.Format(message, args);
            System.Console.WriteLine(MESSAGE_PATTERN, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), level, _name, compositeMessage);
        }

        private void logException(string level, string message, Exception ex)
        {
            log(level, "Exception will be thrown. Message - {0}. Stack trace - {1}", message ?? ex.Message, ex.StackTrace);
        }
    }
}