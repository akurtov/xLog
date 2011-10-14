using System;

namespace XLog
{
    public interface ILog
    {
        void Trace(string message, params object[] args);
        void Trace(Exception ex, string message = null);
        
        void Debug(string message, params object[] args);
        void Debug(Exception ex, string message = null);
        
        void Info(string message, params object[] args);
        void Info(Exception ex, string message = null);
        
        void Warn(string message, params object[] args);
        void Warn(Exception ex, string message = null);
        
        void Error(string message, params object[] args);
        void Error(Exception ex, string message = null);

        void Fatal(string message, params object[] args);
        void Fatal(Exception ex, string message = null);
    }
}