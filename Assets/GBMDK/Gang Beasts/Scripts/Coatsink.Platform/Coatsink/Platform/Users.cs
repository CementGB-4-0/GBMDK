using System;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform
{
    public static class Users
    {
        [CompilerGenerated] private static Action<int> OnMaxUsersChanged;

        private static object _managerLock;

        private static IUserManager _mainUserManager;

        public static IUserManager UserManager
        {
            set { }
        }

        public static int MaxUsers
        {
            get { return 0; }
            set { }
        }

        public static LocalID PrimaryUser => default(LocalID);

        public static event Action<LocalID> OnPrimarySet
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<LocalID> OnPrimaryLost
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<LocalID> OnUserJoined
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<LocalID> OnUserLeft
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static LocalID LocalID(int controller)
        {
            return default(LocalID);
        }

        public static int GetControllerSlot(LocalID localID)
        {
            return 0;
        }

        public static string GetUserName(LocalID localID)
        {
            return null;
        }

        public static OnlineID GetUserOnlineID(LocalID localID)
        {
            return default(OnlineID);
        }

        public static UserInfo GetUserInfo(LocalID localID)
        {
            return default(UserInfo);
        }

        public static TaskResult<LocalID, int> UserJoin(int controller, TaskResult<LocalID, int> taskResult = null)
        {
            return null;
        }

        public static int UserLeave(int controller)
        {
            return 0;
        }

        public static int SetPrimaryUser(LocalID localID)
        {
            return 0;
        }

        public static TaskResult<LocalID, bool> OnlineAllowed(LocalID localID, bool showMessage, bool realtime = true,
            TaskResult<LocalID, bool> taskResult = null)
        {
            return null;
        }

        public static class TriggerEvents
        {
            public static void OnPrimarySet(LocalID localID, IUserManager caller)
            {
            }

            public static void OnPrimaryLost(LocalID localID, IUserManager caller)
            {
            }

            public static void OnUserJoin(LocalID localID, IUserManager caller)
            {
            }

            public static void OnUserLeft(LocalID localID, IUserManager caller)
            {
            }

            public static void OnMaxUsersChanged(int newMax, IUserManager caller)
            {
            }
        }
    }
}