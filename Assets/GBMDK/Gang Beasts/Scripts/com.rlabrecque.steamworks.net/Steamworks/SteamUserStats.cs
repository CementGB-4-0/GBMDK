namespace Steamworks
{
    public static class SteamUserStats
    {
        public static bool GetStat(string pchName, out int pData)
        {
            pData = default(int);
            return false;
        }

        public static bool GetStat(string pchName, out float pData)
        {
            pData = default(float);
            return false;
        }

        public static bool SetStat(string pchName, int nData)
        {
            return false;
        }

        public static bool SetStat(string pchName, float fData)
        {
            return false;
        }

        public static bool SetAchievement(string pchName)
        {
            return false;
        }

        public static bool ClearAchievement(string pchName)
        {
            return false;
        }

        public static bool StoreStats()
        {
            return false;
        }
    }
}