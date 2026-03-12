using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
    public class PlatformAgeRatingDatabase : ScriptableObject, ISerializationCallbackReceiver
    {
        private static readonly AgeCarrier[] BoardAges;

        private static readonly AgeCarrier[] PS4PublishSettings;

        public static readonly PS4CountryCodesCarrier[] PS4CountryCodes;

        public static readonly PS4RegionBoardCarrier[] PS4RegionBoards;

        [SerializeField] private List<AgeRatingInfo> _serializer;

        private string[] _keys;

        public Dictionary<string, AgeRatingInfo> ratings;

        public string[] Keys => null;

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
        }

        public static int GetBoardAge(string board, string age)
        {
            return 0;
        }

        public static int GetSonyLevelAge(string board, string age)
        {
            return 0;
        }

        public static bool HasBoard(string board)
        {
            return false;
        }

        public static bool HasPublishLevel(string board, string age)
        {
            return false;
        }

        public static bool GetPossableAges(string board, ref List<string> ages)
        {
            return false;
        }

        public AgeRatingInfo AgeRating(string key)
        {
            return null;
        }

        public string Age(string key)
        {
            return null;
        }

        public string AgeNone(string key)
        {
            return null;
        }

        public string AgeSteam(string key)
        {
            return null;
        }

        public string AgeOculus(string key)
        {
            return null;
        }

        public int AgePS4Publish(string key)
        {
            return 0;
        }

        public string AgePS4(string key)
        {
            return null;
        }

        public bool AgePS4Active(string key)
        {
            return false;
        }

        public void ActivatePS4(string region)
        {
        }

        private struct AgeCarrier
        {
            public string board;

            private Dictionary<string, int> levels;

            public AgeCarrier(string newBoard, params object[] newLevels)
            {
                board = null;
                levels = null;
            }

            public bool HasLevel(string age)
            {
                return false;
            }

            public int GetLevel(string age)
            {
                return 0;
            }

            public bool GetAges(ref List<string> ages)
            {
                return false;
            }
        }

        public struct PS4CountryCodesCarrier
        {
            public string board;

            public string[] codes;

            public PS4CountryCodesCarrier(string newBoard, string[] newCodes)
            {
                board = null;
                codes = null;
            }
        }

        public struct PS4RegionBoardCarrier
        {
            public string region;

            public string[] board;

            public PS4RegionBoardCarrier(string newRegion, string[] newBoard)
            {
                region = null;
                board = null;
            }
        }

        [Serializable]
        public class AgeRatingInfo
        {
            public bool ps4Active;

            public string board;

            public string AgeNone;

            public string AgeSteam;

            public string AgeOculus;

            public string AgePS4;

            public AgeRatingInfo(string userKey)
            {
            }
        }
    }
}