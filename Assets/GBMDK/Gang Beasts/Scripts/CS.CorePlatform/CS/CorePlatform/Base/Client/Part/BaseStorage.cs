using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Base.Client.Part
{
    public abstract class BaseStorage : MonoBehaviour
    {
        public static string LOCALCONTINUEWITHOUTSAVINGMESSAGE;

        public static string LOCALCANCELSAVEMESSAGE;

        public static string LOCALRETRYSAVEMESSAGE;

        public static string LOCALRETRYLOADMESSAGE;

        public static string LOCALCONTINUEWITHOUTLOADINGMESSAGE;

        protected List<string> _dirtyFiles;
        protected bool _hasCompleted;

        protected List<string> _loadFiles;

        protected object _locker;

        protected bool _storageDisabled;

        protected Dictionary<string, byte[]> _storedData;

        protected Action _waitingAction;

        public abstract bool IsBusy { get; }

        public bool IsReady => false;

        public virtual bool StorageDisabled
        {
            get { return false; }
            set { }
        }

        public virtual bool IsLoading => false;

        public virtual bool IsSaving => false;

        protected abstract void SaveData();

        protected abstract void LoadData();

        public void StartSaveData()
        {
        }

        public void StartLoadData(string[] files)
        {
        }

        private void BeginLoad()
        {
        }

        protected void CompleteSaveData()
        {
        }

        protected void CompleteLoadData()
        {
        }

        protected void FailData(bool save, bool handled)
        {
        }

        protected void RemoveUnused()
        {
        }

        public void Forget(string file)
        {
        }

        public string[] LoadedFiles()
        {
            return null;
        }

        public int HasData(string fileName)
        {
            return 0;
        }

        public int GetLoadedData(string file, ref string data, bool safe = true)
        {
            return 0;
        }

        public int GetLoadedData(string fileName, ref byte[] data, bool copy, bool safe = true)
        {
            return 0;
        }

        public bool AddSaveData(string file, string data, bool safe = true)
        {
            return false;
        }

        public bool AddSaveData(string fileName, byte[] data, int amount = 0, bool copy = false, bool safe = true)
        {
            return false;
        }

        protected bool LogicSaveData(string file, byte[] data)
        {
            return false;
        }

        protected void LogicAddData(string file, byte[] data)
        {
        }

        protected void ShowMessageFailRetry(bool effect1)
        {
        }

        private void ShowMessageCancelSave()
        {
        }

        private void ShowMessageContinueWithout(bool save, bool loadcompleteEvent = false)
        {
        }

        protected List<string>.Enumerator GetFiles()
        {
            return default(List<string>.Enumerator);
        }

        protected List<string>.Enumerator GetLoadFiles()
        {
            return default(List<string>.Enumerator);
        }

        protected byte[] GetData(string file)
        {
            return null;
        }

        public string DebugDataStoreInfo()
        {
            return null;
        }
    }
}