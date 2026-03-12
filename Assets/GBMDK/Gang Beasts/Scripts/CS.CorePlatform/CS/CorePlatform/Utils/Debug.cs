using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class Debug
    {
        private static Texture2D _debugBox;

        public static bool IsDebug => false;

        private static Texture2D _DebugBox => null;

        public static bool ShowInfoPlus => false;

        public static void SetDebugColour()
        {
        }

        public static void LogError(string message, params object[] args)
        {
        }

        public static void LogWarning(string message, params object[] args)
        {
        }

        public static void LogInfo(string message, params object[] args)
        {
        }

        public static void ThreadLogError(string message, params object[] args)
        {
        }

        public static void ThreadLogWarning(string message, params object[] args)
        {
        }

        public static void ThreadLogInfo(string message, params object[] args)
        {
        }

        public static void DrawGUIBox(Rect area, Color colour)
        {
        }

        public static class XboxLayout
        {
            public static Rect UtilData;

            public static Rect SaveData;

            public static Rect UserData;

            public static Rect AchievementData;

            public static Rect StatData;

            public static Rect LobbyData;

            public static Rect NetworkData;

            public static Rect VoiceData;

            public static Rect Manager;

            public static Rect Playing;

            public static Rect Devices;
        }

        public static class PS4Layout
        {
            public static Rect MainData;

            public static Rect UtilData;

            public static Rect SaveData;

            public static Rect UserData;

            public static Rect AchievementData;

            public static Rect StatData;

            public static Rect LobbyData;

            public static Rect NetworkData;

            public static Rect VoiceData;
        }

        public static class SwitchLayout
        {
            public static Rect UtilData;

            public static Rect SaveData;

            public static Rect LobbyData;
        }
    }
}