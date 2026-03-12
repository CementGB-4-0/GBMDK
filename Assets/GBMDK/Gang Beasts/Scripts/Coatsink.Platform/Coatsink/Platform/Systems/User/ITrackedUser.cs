namespace Coatsink.Platform.Systems.User
{
    public interface ITrackedUser
    {
        LocalID LocalID { get; }

        OnlineID OnlineID { get; }

        uint Set(LocalID value, params object[] extra);
    }
}