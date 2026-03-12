using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.RichPresence
{
    public interface ISystemExtras
    {
        void RegisterPlayedWith(LocalID localID, UserInfo onlineUser);
    }
}