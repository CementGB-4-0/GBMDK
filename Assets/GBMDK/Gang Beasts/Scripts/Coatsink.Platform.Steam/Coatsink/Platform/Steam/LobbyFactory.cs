using System;
using Coatsink.Platform.Systems.Online;
using GangBeastsUnityLobby.Platform;
using Steamworks;

namespace Coatsink.Platform.Steam
{
    public class LobbyFactory : ILobbyFactory
    {
        public static string STEAM_LOBBY_ARG;

        private Callback<GameRichPresenceJoinRequested_t> _callbackOnGameLobbyJoinRequested;

        private Callback<NewUrlLaunchParameters_t> _callbackOnNewLaunchCheckRequested;

        private Lobby _currentLobby;

        private int _maxCommandLine;

        private Func<bool> _steamCheck;

        private int _unityLobbyIdLength;

        public LobbyFactory(Func<bool> steamActiveCheck, string launchArgs = null, bool checkSteamCommand = true,
            int maxSteamCommandLenght = 256)
        {
        }

        public ILobby CreateLobby()
        {
            return null;
        }

        public uint EndMultiplayer()
        {
            return 0u;
        }

        ~LobbyFactory()
        {
        }

        protected void OnJoinLobby(GameRichPresenceJoinRequested_t message)
        {
        }

        protected void OnNewLaunchCheck(NewUrlLaunchParameters_t message)
        {
        }

        private bool CheckSteamCommands()
        {
            return false;
        }

        public ILobbyID CheckForInvite(string launchArgs)
        {
            return null;
        }

        private void OnLobbyEntered(ILobby lobby, ILobbyID lobbyID)
        {
        }
    }
}