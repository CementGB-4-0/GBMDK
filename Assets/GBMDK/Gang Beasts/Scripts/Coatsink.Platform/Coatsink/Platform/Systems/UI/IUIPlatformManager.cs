using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.UI
{
    public interface IUIPlatformManager
    {
        bool Active { get; }

        uint OpenUserProfile(LocalID localID, UserInfo onlineUser);
    }
}