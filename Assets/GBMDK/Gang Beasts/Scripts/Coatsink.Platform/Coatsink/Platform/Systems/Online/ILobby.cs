using System.Collections.Generic;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Online
{
    public interface ILobby
    {
        ILobbyID LobbyID { get; }

        bool IsInLobby { get; }

        bool IsLobbyHost { get; }

        bool IsJoiningLobby { get; }

        UserInfo Host { get; }

        int TotalInLobby { get; }

        bool Joinable { get; set; }

        event LobbyUserEvent OnUserLeft;

        event LobbyUserEvent OnUserJoin;

        event LobbyUserEvent OnHostChanged;

        event LobbyIdEvent OnLobbyClosed;

        TaskResult<ILobby> CreateLobby(LocalID join, uint maxSlots, TaskResult<ILobby> task = null);

        TaskResult<ILobby> JoinLobby(LocalID join, ILobbyID id, string joinCode = null, TaskResult<ILobby> task = null);

        TaskResult<ILobby> LeaveLobby(TaskResult<ILobby> task = null);

        bool SendLobbyMessage(UserInfo userID, byte[] message);

        string GetJoinCode();

        uint GetLobbyUsers(ref List<UserInfo> users);

        string GetUserName(UserInfo userInfo);

        bool KickUser(UserInfo kickTarget);

        TaskResult<ILobby> ShowInviteUI(LocalID localID, int maxInvites, TaskResult<ILobby> task = null);

        void LobbyUpdate();
    }
}