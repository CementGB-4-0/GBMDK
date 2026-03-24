using System;
using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class Statistics
    {
        private static PlatformStatisticsDatabase _statisticsInfomation;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void StatisticsSetup(string databaseLocation = null)
        {
        }

        public static string StatisticName(string key)
        {
            return null;
        }

        public static string StatisticDescription(string key)
        {
            return null;
        }

        public static string StatisticSteamAPI(string key)
        {
            return null;
        }

        public static bool StatisticAchievementLinked(string key)
        {
            return false;
        }

        public static string StatisticAchievementLink(string key, int index)
        {
            return null;
        }

        public static float StatisticAchievementUnlockAt(string key, int index)
        {
            return 0f;
        }

        public static string StatisticAchievementUnlockCheck(string key, float value, int index)
        {
            return null;
        }

        public static void StatisticAchievementUnlock(string key, float value, Action<string> unlockCall)
        {
        }

        public static void StatisticAchievementUpdate(string key, float value, Action<string, float, float> update)
        {
        }

        public static string[] StatisticList()
        {
            return null;
        }

        public static string[] StatisticAllXbox()
        {
            return null;
        }

        public static string StatisticXboxAPI(string key)
        {
            return null;
        }

        public static string StatisticsSaveFile()
        {
            return null;
        }

        public static int StatisticsSaveEstSize()
        {
            return 0;
        }

        public static PlatformStatisticsDatabase.StatsType StatisticsType(string key)
        {
            return default(PlatformStatisticsDatabase.StatsType);
        }

        public static string StatisticGOGAPI(string key)
        {
            return null;
        }
    }
}