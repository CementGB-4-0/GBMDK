using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
    public class PlatformStatisticsDatabase : ScriptableObject, ISerializationCallbackReceiver
    {
        public enum StatsType
        {
            FLOAT = 0,
            INT = 1
        }

        [SerializeField] private int _estFileSize;

        [SerializeField] public string SystemStatsStorageLocation;

        [SerializeField] private List<StatisticInfo> _serializer;

        [NonSerialized] private string[] _keys;

        [NonSerialized] private string[] _xboxAPIs;

        public Dictionary<string, StatisticInfo> statistics;

        public string[] Keys => null;

        public string[] XboxAPIs => null;

        public int EstFileSize => 0;

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
        }

        public string Name(string key)
        {
            return null;
        }

        public string Description(string key)
        {
            return null;
        }

        public string SteamAPI(string key)
        {
            return null;
        }

        public string GogAPI(string key)
        {
            return null;
        }

        public string XboxAPI(string key)
        {
            return null;
        }

        public StatsType Type(string key)
        {
            return default(StatsType);
        }

        public bool AchievementLinked(string key)
        {
            return false;
        }

        public string AchievementLink(string key, int index)
        {
            return null;
        }

        public float AchievementUnlock(string key, int index)
        {
            return 0f;
        }

        public string AchievementUnlockCheck(string key, float value, int index)
        {
            return null;
        }

        public string AchievementUnlock(string key, float value, Action<string> unlockCall)
        {
            return null;
        }

        public string AchievementUpdate(string key, float value, Action<string, float, float> update)
        {
            return null;
        }

        [Serializable]
        public class StatisticInfo
        {
            public string key;

            public string name;

            public string description;

            public string steamAPI;

            public string xboxAPI;

            public string gogAPI;

            public StatsType statType;

            public List<AchievementLink> achievements;

            public StatisticInfo(string userKey)
            {
            }

            public bool achievementLinked => false;

            [Serializable]
            public class AchievementLink
            {
                public string achievementKey;

                public float achievementUnlock;
            }
        }
    }
}