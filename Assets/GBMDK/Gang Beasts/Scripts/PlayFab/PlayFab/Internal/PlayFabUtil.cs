using System;
using System.Globalization;
using System.Text;

namespace PlayFab.Internal
{
    public static class PlayFabUtil
    {
        public const int DEFAULT_UTC_OUTPUT_INDEX = 2;

        public const int DEFAULT_LOCAL_OUTPUT_INDEX = 9;
        private static string _localSettingsFileName;

        public static readonly string[] _defaultDateTimeFormats;

        public static DateTimeStyles DateTimeStyles;

        [ThreadStatic] private static StringBuilder _sb;

        static PlayFabUtil()
        {
        }

        public static string timeStamp => null;

        public static string utcTimeStamp => null;

        public static string Format(string text, params object[] args)
        {
            return null;
        }

        public static string ReadAllFileText(string filename)
        {
            return null;
        }

        public static T TryEnumParse<T>(string value, T defaultValue)
        {
            return default(T);
        }

        internal static string GetLocalSettingsFileProperty(string propertyKey)
        {
            return null;
        }
    }
}