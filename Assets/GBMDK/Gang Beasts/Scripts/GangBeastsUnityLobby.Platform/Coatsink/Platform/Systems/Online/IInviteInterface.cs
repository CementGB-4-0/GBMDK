using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Online
{
    public interface IInviteInterface
    {
        TaskResult<ILobby> ShowInviteUI(LocalID localID, int maxInvites, string LobbyID,
            TaskResult<ILobby> task = null);
    }
}