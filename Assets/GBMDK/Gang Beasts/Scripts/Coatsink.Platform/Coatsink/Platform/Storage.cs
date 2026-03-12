using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.Storage;
using Coatsink.Platform.Systems.UI;
using Coatsink.Platform.Systems.User;
using Coatsink.Platform.Utils;

namespace Coatsink.Platform
{
    public static class Storage
    {
        private static object _threadLock;

        private static bool _waitingOnChange;

        private static object _managerLock;

        private static IStorageManager _localStorage;

        private static IStorageManager _cloudStorage;

        private static ThreadHandler _storageThread;

        private static IStorageTask _currentTask;

        private static TaskResult<bool> _retryCheck;

        private static IDisabledChecker _fileDisableHandler;

        private static Queue<IStorageTask> _jobs;

        public static IStorageManager StorageBase
        {
            set { }
        }

        public static IStorageManager StorageCloud
        {
            set { }
        }

        public static event Action OnStorageActivityChange
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static void AbortThread(bool block)
        {
        }

        private static void CheckThread()
        {
        }

        public static uint Load<T>(StorageTask<T> task) where T : TaskResultBase<T>
        {
            return 0u;
        }

        public static uint Save<T>(StorageTask<T> task) where T : TaskResultBase<T>
        {
            return 0u;
        }

        private static void ThreadLogic()
        {
        }

        private static uint SaveLogic(IStorageTask activeTask)
        {
            return 0u;
        }

        private static uint LoadLogic(IStorageTask activeTask)
        {
            return 0u;
        }

        private static uint ExistsLogic(IStorageTask activeTask)
        {
            return 0u;
        }

        private static void TriggerOnStorageActivityChange()
        {
        }

        private static uint TrySave(LocalID localID, bool cloud, string file, byte[] data)
        {
            return 0u;
        }

        private static uint TryLoad(LocalID localID, bool cloud, string file, ref byte[] data)
        {
            return 0u;
        }

        private static uint TryExists(LocalID localID, bool cloud, string file)
        {
            return 0u;
        }

        private static class UserInputCalls
        {
            private static string _file;

            private static bool _cloud;

            private static LocalID _localID;

            private static DisplayTask _displayTask;

            public static void StartSaveInput(uint startError, string file, LocalID localID, bool cloud)
            {
            }

            private static void SaveRetryResult(DisplayTask task)
            {
            }

            private static void SaveCancelResult(DisplayTask task)
            {
            }

            private static void SaveCorruptDeleteResult(DisplayTask task)
            {
            }

            public static void StartLoadInput(uint startError, string file, LocalID localID, bool cloud)
            {
            }

            private static void LoadRetryResult(DisplayTask task)
            {
            }

            private static void LoadContinueWithoutResult(DisplayTask task)
            {
            }
        }
    }
}