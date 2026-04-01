using System;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform
{
    public static class Multiplayer
    {
        [CompilerGenerated] private static Action<LocalID, ILobbyID> OnLobbyInviteSent;

        private static object _managerLock;

        private static ILobbyFactory _lobbyFactory;

        private static ITokenFactory _tokenFactory;

        public static ILobbyFactory LobbyFactory
        {
            set { }
        }

        public static event Action<LocalID, ILobbyID> OnLobbyJoinRequest
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<LocalID, TaskResult<ILobby>> OnLobbyCreateRequest
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static ILobby CreateRawLobby()
        {
            return null;
        }

        public static TaskResult<ILobby> CreateLobby(LocalID localID, uint maxSlots,
            TaskResult<ILobby> taskResult = null)
        {
            return null;
        }

        public static TaskResult<ILobby> JoinLobby(LocalID localID, ILobbyID lobbyID, string joinCode = null,
            TaskResult<ILobby> taskResult = null)
        {
            return null;
        }

        public static uint EndMultiplayer()
        {
            return 0u;
        }

        public static class TriggerEvents
        {
            public static void OnLobbyJoinRequest(LocalID localID, ILobbyID lobbyID)
            {
            }

            public static void OnLobbyUserEvent(LobbyUserEvent action, ILobby lobby, UserInfo user)
            {
            }

            public static void OnLobbyIdEvent(LobbyIdEvent action, ILobby lobby, ILobbyID id)
            {
            }
        }
    }
}