using System.Runtime.CompilerServices;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class Requests
    {
        public delegate string PlatromLocaliseDel(string key, string[] parameters);

        public delegate bool PlatromVoiceConnectionDel(BaseUserInfo userInfo);

        public static event PlatromVoiceConnectionDel VoiceConnectionAttempt
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatromLocaliseDel TextLocalise
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static bool GetVoiceConnectionAttemptResult(BaseUserInfo userInfo)
        {
            return false;
        }

        public static string GetTextLocalise(string key, string[] parameters)
        {
            return null;
        }
    }
}