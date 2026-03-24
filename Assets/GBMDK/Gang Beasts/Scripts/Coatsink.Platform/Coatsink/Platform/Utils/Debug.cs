using System;

namespace Coatsink.Platform.Utils
{
    public static class Debug
    {
        [Flags]
        public enum Level
        {
            NONE = 0,
            INFO = 1,
            WARNING = 2,
            ERROR = 4,
            EXCEPTION = 8,
            STAC = 0x10,
            SPAM = 0x20,
            DEEP = 0x40
        }

        public static Level ActiveLevel;

        public static Action<Level, string> OnLog;

        public static void Log(Level level, string message, params object[] info)
        {
        }

        public static void LogInfo(string message, params object[] info)
        {
        }

        public static void LogWarn(string message, params object[] info)
        {
        }

        public static void LogErro(string message, params object[] info)
        {
        }

        public static void LogExce(string message, Exception exc, params object[] info)
        {
        }

        public static void LogExce(string key, Exception exc, string addition, params object[] info)
        {
        }

        private static string PrepLog(Level level, string message, params object[] info)
        {
            return null;
        }
    }
}