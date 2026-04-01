using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Storage
{
    public class SystemStorageMulti : SystemStorage
    {
        public SystemStorageMulti(string fileDirectory)
            : base(null)
        {
        }

        public override uint Exists(LocalID localID, string file)
        {
            return 0u;
        }

        public override uint Load(LocalID localID, string file, out byte[] data)
        {
            data = null;
            return 0u;
        }

        public override uint Save(LocalID localID, string file, byte[] data)
        {
            return 0u;
        }
    }
}