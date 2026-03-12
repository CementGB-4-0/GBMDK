using System;

namespace PlayFab.Internal
{
    [Obsolete("This logging utility has been deprecated. Use UnityEngine.Debug.Log")]
    public static class Log
    {
        [Obsolete("Debug is deprecated.")]
        public static void Debug(string text, params object[] args)
        {
        }

        [Obsolete("Info is deprecated.")]
        public static void Info(string text, params object[] args)
        {
        }

        [Obsolete("Warning is deprecated.")]
        public static void Warning(string text, params object[] args)
        {
        }

        [Obsolete("Error is deprecated.")]
        public static void Error(string text, params object[] args)
        {
        }
    }
}