namespace Coatsink.Platform.Systems.Online
{
    public interface ILobbyFactory
    {
        ILobby CreateLobby();

        uint EndMultiplayer();
    }
}