namespace CS.CorePlatform.Utils.Data
{
    public static class PlatformDataExtensions
    {
        public static void WriteMatchmakingEncryptionModel(DataWriter writer, EncryptionData encryptionData)
        {
        }

        public static EncryptionData ReadMatchmakingEncryptionModel(DataReader reader)
        {
            return null;
        }

        public class EncryptionData
        {
            public byte[] EncryptionKey;

            public uint EncryptionKeyLength;

            public byte[] HmacKey;

            public uint HmacKeyLength;

            public byte[] InitialisationVector;

            public uint InitialisationVectorLength;
            public string Uuid;
        }
    }
}