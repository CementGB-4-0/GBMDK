namespace Steamworks
{
    public static class SteamRemoteStorage
    {
        public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
        {
            return false;
        }

        public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
        {
            return 0;
        }

        public static bool FileDelete(string pchFile)
        {
            return false;
        }

        public static bool FileExists(string pchFile)
        {
            return false;
        }

        public static int GetFileSize(string pchFile)
        {
            return 0;
        }
    }
}