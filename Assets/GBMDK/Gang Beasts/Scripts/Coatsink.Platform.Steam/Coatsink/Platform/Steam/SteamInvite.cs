using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Steam
{
    public class SteamInvite : IInviteInterface
    {
        public TaskResult<ILobby> ShowInviteUI(LocalID localID, int maxInvites, string LobbyID,
            TaskResult<ILobby> task = null)
        {
            return null;
        }
    }
}