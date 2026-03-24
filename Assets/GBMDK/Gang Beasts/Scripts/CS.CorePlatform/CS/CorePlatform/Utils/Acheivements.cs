using System.Collections.Generic;
using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class Acheivements
    {
        private static PlatformAchievementDatabase _achievementInfomation;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void AcheivementSetup(string databaseLocation = null)
        {
        }

        public static int AcheivementPS4Index(string key)
        {
            return 0;
        }

        public static string AcheivementSteamAPI(string key)
        {
            return null;
        }

        public static string AcheivementOculusAPI(string key)
        {
            return null;
        }

        public static string AcheivementXboxAPI(string key)
        {
            return null;
        }

        public static string AcheivementName(string key)
        {
            return null;
        }

        public static string AcheivementDescription(string key)
        {
            return null;
        }

        public static int AcheivementLargestPS4()
        {
            return 0;
        }

        public static string AcheivementGOGAPI(string key)
        {
            return null;
        }

        public static Dictionary<string, string> DictionaryListSteam()
        {
            return null;
        }

        public static Dictionary<string, string> DictionaryListXbox()
        {
            return null;
        }
    }
}