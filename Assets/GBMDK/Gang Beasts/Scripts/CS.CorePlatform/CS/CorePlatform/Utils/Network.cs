using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class Network
    {
        private static PlatformNetworkDatabase _ratingInfomation;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void NetworkSetup(string databaseLocation = null)
        {
        }

        public static bool XboxTCPActive()
        {
            return false;
        }

        public static bool XboxUDPActive()
        {
            return false;
        }

        public static bool XboxChatActive()
        {
            return false;
        }

        public static string XboxTCPTemplate()
        {
            return null;
        }

        public static int XboxTCPPort()
        {
            return 0;
        }

        public static string XboxUDPTemplate()
        {
            return null;
        }

        public static int XboxUDPPort()
        {
            return 0;
        }

        public static string XboxChatTemplate()
        {
            return null;
        }

        public static int XboxChatPort()
        {
            return 0;
        }

        public static string XboxSessionTemplateName()
        {
            return null;
        }

        public static string XboxServerSessionTemplateName()
        {
            return null;
        }
    }
}