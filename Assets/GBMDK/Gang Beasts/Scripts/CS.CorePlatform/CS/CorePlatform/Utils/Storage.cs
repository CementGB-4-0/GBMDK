using System.Collections.Generic;
using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public static class Storage
    {
        private static string _directory;

        private static PlatformStorageDatabase _storageInfomation;

        public static int StorageFilesTotal => 0;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void StorageSetup(string databaseLocation = null)
        {
        }

        public static string StorageNoneDirectory()
        {
            return null;
        }

        public static List<string> StorageFiles()
        {
            return null;
        }

        public static List<string> StorageFilesLocal()
        {
            return null;
        }

        public static string StorageFiles(int i)
        {
            return null;
        }

        public static bool StorageFilesNameExpected(string file)
        {
            return false;
        }

        public static bool StorageFilesNameExpectedCloud(string file)
        {
            return false;
        }

        public static bool StorageFilesNameExpectedLocal(string file)
        {
            return false;
        }

        public static string StorageOculusBucketName()
        {
            return null;
        }

        public static string StorageXboxContainerName()
        {
            return null;
        }

        public static string StorageNintendoMountName()
        {
            return null;
        }
    }
}