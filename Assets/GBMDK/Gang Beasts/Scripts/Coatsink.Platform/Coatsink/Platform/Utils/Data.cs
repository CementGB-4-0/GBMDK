using System.IO;

namespace Coatsink.Platform.Utils
{
    public static class Data
    {
        public static uint Serialize(object thing, MemoryStream mem)
        {
            return 0u;
        }

        public static uint Deserialize<T>(MemoryStream mem, out T result)
        {
            result = default(T);
            return 0u;
        }

        public static byte[] Encrypt(byte[] key, byte[] data, int offset = 0, int count = 0)
        {
            return null;
        }

        public static byte[] Decrypt(byte[] key, byte[] data, int offset = 0, int count = 0)
        {
            return null;
        }
    }
}