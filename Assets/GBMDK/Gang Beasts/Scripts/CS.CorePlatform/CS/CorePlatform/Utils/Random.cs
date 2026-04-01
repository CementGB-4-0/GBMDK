using System;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class Random
    {
        public static Func<string, object> LoadData;

        private static string _gameBaseUIObject;

        private static Type _gameBaseUIScript;

        private static Color _NewImageColour;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void SetGameBasedUI(string asset)
        {
        }

        public static void SetGameBasedUI(Type asset)
        {
        }

        public static PlatformSystemMessenger CreateGameBasedUI(GameObject gameObject)
        {
            return null;
        }

        public static bool LogMainUserIn(int target = 0)
        {
            return false;
        }

        public static Texture2D CreateNewImage(bool apply = true, int w = 64, int h = 64)
        {
            return null;
        }

        public static Texture2D CreateNewImageF(bool apply = true, int w = 64, int h = 64,
            TextureFormat format = TextureFormat.RGBA32, bool mipmap = false)
        {
            return null;
        }
    }
}