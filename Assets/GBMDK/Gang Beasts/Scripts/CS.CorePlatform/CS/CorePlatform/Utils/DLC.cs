using System.Collections.Generic;
using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class DLC
    {
        private static PlatformDLCDatabase _dlcInfomation;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void DLCSetup(string databaseLocation = null)
        {
        }

        public static List<string> DLCKeys()
        {
            return null;
        }

        public static List<string> DLCPS4Index(string key)
        {
            return null;
        }

        public static uint DLCSteamAPI(string key)
        {
            return 0u;
        }

        public static string DLCOculusAPI(string key)
        {
            return null;
        }

        public static string DLCName(string key)
        {
            return null;
        }

        public static string DLCDescription(string key)
        {
            return null;
        }

        public static long DLCDiscrodAPI(string dlcKey)
        {
            return 0L;
        }

        public static ulong DLCGOGAPI(string dlcKey)
        {
            return 0uL;
        }

        public static string DLCXboxTitle(string dlcKey, out bool needsMount)
        {
            needsMount = default(bool);
            return null;
        }

        public static bool DLCXboxMount(string titleID)
        {
            return false;
        }

        public static int DLCSwitchIndex(string dlcKey, out bool needsMount)
        {
            needsMount = default(bool);
            return 0;
        }

        public static bool DLCSwitchMount(int indexID)
        {
            return false;
        }
    }
}