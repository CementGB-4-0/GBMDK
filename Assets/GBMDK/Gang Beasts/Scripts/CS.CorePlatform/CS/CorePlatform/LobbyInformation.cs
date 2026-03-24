using Coatsink.Platform.Systems.Online;

namespace CS.CorePlatform
{
    public struct LobbyInformation
    {
        public BaseUserInfo host;

        public uint maxSlots;

        public uint userCount;

        public LOBBY_TYPE lobbyType;

        public ILobbyID lobbyId;

        public string joinCode;

        public void Blank()
        {
        }
    }
}