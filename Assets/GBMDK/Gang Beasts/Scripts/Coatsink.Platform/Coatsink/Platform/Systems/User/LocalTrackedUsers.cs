using System.Collections.Generic;

namespace Coatsink.Platform.Systems.User
{
    public class LocalTrackedUsers<T> : IUserManager where T : ITrackedUser, new()
    {
        protected List<T> _activeUsers;

        protected LocalID _currentPrimary;
        protected object _locker;

        private uint _onlineAllowedKey;

        protected PlatformID _platform;

        protected int _platformMax;

        public LocalTrackedUsers(int maxUsers = 8, PlatformID platform = PlatformID.NONE, int platformMax = -1,
            bool allowOnline = false)
        {
        }

        public virtual int PlatformMaxUsers => 0;

        public LocalID PrimaryUser => default(LocalID);

        public int MaxUsers
        {
            get { return 0; }
            set { }
        }

        public int GetControllerSlot(LocalID localID)
        {
            return 0;
        }

        public virtual string GetUserName(LocalID localID)
        {
            return null;
        }

        public UserInfo GetUserInfo(LocalID localID)
        {
            return default(UserInfo);
        }

        public virtual OnlineID GetUserOnlineID(LocalID localID)
        {
            return default(OnlineID);
        }

        public LocalID LocalID(int controller)
        {
            return default(LocalID);
        }

        public virtual void OnlineAllowed(LocalID localID, bool showMessage, bool realtime,
            TaskResult<LocalID, bool> taskResult)
        {
        }

        public int SetPrimaryUser(LocalID localID)
        {
            return 0;
        }

        public virtual void UserJoin(int controller, TaskResult<LocalID, int> taskResult)
        {
        }

        public virtual int UserLeave(int controller)
        {
            return 0;
        }

        protected virtual void UserJoin(int controller, TaskResult<LocalID, int> taskResult, params object[] info)
        {
        }
    }
}