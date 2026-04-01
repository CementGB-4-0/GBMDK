namespace Coatsink.Platform.Systems.User
{
    public class LocalStoredUsers : LocalTrackedUsers<LocalStoredUsers.LocalUser>
    {
        public LocalStoredUsers(int maxUsers = 8, PlatformID platform = PlatformID.NONE, int platformMax = -1,
            bool allowOnline = false)
            : base(0, default(PlatformID), 0, allowOnline: false)
        {
        }

        public class LocalUser : ITrackedUser
        {
            private LocalID _localID;

            public LocalID LocalID => default(LocalID);

            public OnlineID OnlineID => default(OnlineID);

            public uint Set(LocalID value, params object[] extra)
            {
                return 0u;
            }
        }
    }
}