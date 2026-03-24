using System;
using System.Collections.Generic;
using System.Text;

namespace PlayFab
{
    public static class PlayFabSettings
    {
        public const string SdkVersion = "2.166.230512";

        public const string BuildIdentifier = "adobuild_unitysdk_167";

        public const string VersionString = "UnitySDK-2.166.230512";

        public const string DefaultPlayFabApiUrl = "playfabapi.com";
        private static PlayFabSharedSettings _playFabShared;

        public static readonly PlayFabApiSettings staticSettings;

        public static readonly PlayFabAuthenticationContext staticPlayer;

        private static string _localApiServer;

        [ThreadStatic] private static StringBuilder _cachedStringBuilder;

        static PlayFabSettings()
        {
        }

        private static PlayFabSharedSettings PlayFabSharedPrivate => null;

        public static string DeviceUniqueIdentifier => null;

        public static string TitleId
        {
            get { return null; }
            set { }
        }

        internal static string VerticalName
        {
            get { return null; }
            set { }
        }

        public static bool DisableDeviceInfo
        {
            get { return false; }
            set { }
        }

        public static bool DisableFocusTimeCollection
        {
            get { return false; }
            set { }
        }

        [Obsolete("LogLevel has been deprecated, please use UnityEngine.Debug.Log for your logging needs.")]
        public static PlayFabLogLevel LogLevel
        {
            get { return default(PlayFabLogLevel); }
            set { }
        }

        public static WebRequestType RequestType
        {
            get { return default(WebRequestType); }
            set { }
        }

        public static int RequestTimeout
        {
            get { return 0; }
            set { }
        }

        public static bool RequestKeepAlive
        {
            get { return false; }
            set { }
        }

        public static string LoggerHost
        {
            get { return null; }
            set { }
        }

        public static int LoggerPort
        {
            get { return 0; }
            set { }
        }

        public static bool EnableRealTimeLogging
        {
            get { return false; }
            set { }
        }

        public static int LogCapLimit
        {
            get { return 0; }
            set { }
        }

        public static string LocalApiServer
        {
            get { return null; }
            set { }
        }

        private static PlayFabSharedSettings GetSharedSettingsObjectPrivate()
        {
            return null;
        }

        private static StringBuilder AcquireStringBuilder()
        {
            return null;
        }

        public static string GetFullUrl(string apiCall, Dictionary<string, string> getParams,
            PlayFabApiSettings apiSettings = null)
        {
            return null;
        }
    }
}