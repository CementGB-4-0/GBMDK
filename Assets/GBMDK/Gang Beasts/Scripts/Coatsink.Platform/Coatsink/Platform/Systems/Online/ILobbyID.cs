namespace Coatsink.Platform.Systems.Online
{
    public interface ILobbyID
    {
        PlatformID Platform { get; }

        bool IsValid();
    }
}