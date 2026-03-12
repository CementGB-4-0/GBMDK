using Coatsink.Platform.Systems;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Steam
{
    public class Users : LocalStoredUsers
    {
        private OnlineID _onlineIDCache;

        public Users(int maxUsers = 8)
            : base(0, default(PlatformID), 0)
        {
        }

        public override string GetUserName(LocalID localID)
        {
            return null;
        }

        public override OnlineID GetUserOnlineID(LocalID localID)
        {
            return default(OnlineID);
        }

        public override void OnlineAllowed(LocalID localID, bool showMessage, bool realtime,
            TaskResult<LocalID, bool> taskResult)
        {
        }
    }
}