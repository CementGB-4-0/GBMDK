using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Storage
{
    public interface IDisabledChecker
    {
        bool CanSave(LocalID localID, string file);

        bool CanLoad(LocalID localID, string file);
    }
}