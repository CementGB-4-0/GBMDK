using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Storage
{
    public interface IStorageManager
    {
        uint Save(LocalID localID, string file, byte[] data);

        uint Load(LocalID localID, string file, out byte[] data);

        uint Exists(LocalID localID, string file);
    }
}