using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class Presence
    {
        private static PlatformPresenceDatabase _presenceInfomation;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void PreseneceSetup(string databaseLocation = null)
        {
        }

        public static string GetConnecter()
        {
            return null;
        }

        public static string GetSteamPresence(string key)
        {
            return null;
        }

        public static string GetPS4Presence(string key)
        {
            return null;
        }

        public static string GetDiscordPresence(string key)
        {
            return null;
        }

        public static string GetXboxPresence(string key)
        {
            return null;
        }

        public static string GetSteamStatus(string key)
        {
            return null;
        }

        public static string GetPS4Status(string key)
        {
            return null;
        }

        public static string GetDiscordStatus(string key)
        {
            return null;
        }

        public static string GetDiscordImage(string key)
        {
            return null;
        }

        public static string GetDiscordImageText(string key)
        {
            return null;
        }
    }
}