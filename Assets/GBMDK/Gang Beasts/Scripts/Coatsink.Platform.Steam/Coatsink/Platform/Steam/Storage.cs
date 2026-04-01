using Coatsink.Platform.Systems.Storage;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Steam
{
    public class Storage : IStorageManager
    {
        public virtual uint Exists(LocalID localID, string file)
        {
            return 0u;
        }

        public virtual uint Load(LocalID localID, string file, out byte[] data)
        {
            data = null;
            return 0u;
        }

        public virtual uint Save(LocalID localID, string file, byte[] data)
        {
            return 0u;
        }
    }
}