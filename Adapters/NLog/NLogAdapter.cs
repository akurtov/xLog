using System;
using NLog;
using XLog;
using LogManager = NLog.LogManager;

namespace NLogAdapter
{
    internal class NLogAdapter : ILog
    {
        private readonly Logger _logger;
        public NLogAdapter(string name)
        {
            _logger = LogManager.GetLogger(name);
        }

        public void Trace(string message, params object[] args)
        {
            _logger.Trace(message, args);
        }

        public void Trace(Exception ex, string message = null)
        {
            _logger.TraceException(message, ex);
        }

        public void Debug(string message, params object[] args)
        {
            _logger.Debug(message, args);
        }

        public void Debug(Exception ex, string message = null)
        {
            _logger.DebugException(message, ex);
        }

        public void Info(string message, params object[] args)
        {
            _logger.Info(message, args);
        }

        public void Info(Exception ex, string message = null)
        {
            _logger.InfoException(message, ex);
        }

        public void Warn(string message, params object[] args)
        {
            _logger.Warn(message, args);
        }

        public void Warn(Exception ex, string message = null)
        {
            _logger.WarnException(message, ex);
        }

        public void Error(string message, params object[] args)
        {
            _logger.Error(message, args);
        }

        public void Error(Exception ex, string message = null)
        {
            _logger.ErrorException(message, ex);
        }

        public void Fatal(string message, params object[] args)
        {
            _logger.Fatal(message, args);
        }

        public void Fatal(Exception ex, string message = null)
        {
            _logger.FatalException(message, ex);
        }
    }
}