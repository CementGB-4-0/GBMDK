using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class AgeRating
    {
        private static PlatformAgeRatingDatabase _ratingInfomation;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void AgeRatingSetup(string databaseLocation = null)
        {
        }

        public static string AgeNone(string key)
        {
            return null;
        }

        public static string AgeSteam(string key)
        {
            return null;
        }

        public static string AgeOculus(string key)
        {
            return null;
        }

        public static string AgePS4(string key)
        {
            return null;
        }

        public static bool AgePS4Active(string key)
        {
            return false;
        }

        public static string[] AgeKeys()
        {
            return null;
        }
    }
}