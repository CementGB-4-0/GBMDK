using Coatsink.Platform.Systems.RichPresence;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform
{
    public static class RichPresence
    {
        private static object _managerLock;

        private static IRichPresenceManager _richManager;

        private static ISystemExtras _systemExtras;

        public static void RegisterPlayedWith(LocalID localID, UserInfo onlineUser)
        {
        }
    }
}