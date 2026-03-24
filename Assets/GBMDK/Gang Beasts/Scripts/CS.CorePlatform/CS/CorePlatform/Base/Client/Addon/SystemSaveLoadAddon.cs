using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CS.CorePlatform.Utils;

namespace CS.CorePlatform.Base.Client.Addon
{
    public class SystemSaveLoadAddon
    {
        private bool _failed;

        private bool _loading;
        private BasePlatformManager _manager;

        private ThreadHandler _saveloadThread;

        private bool _saving;

        public Action<string, byte[]> AddData;

        public Func<string, byte[]> GetData;

        public Func<List<string>.Enumerator> GetFiles;

        public Func<List<string>.Enumerator> GetLoadFiles;

        public SystemSaveLoadAddon(BasePlatformManager manager)
        {
        }

        public bool IsLoading => false;

        public bool IsSaving => false;

        public bool HasFailed => false;

        public bool IsBusy => false;

        public event Action OnSaveComplete
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event Action OnLoadComplete
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        ~SystemSaveLoadAddon()
        {
        }

        public void Abort(bool block)
        {
        }

        public void SaveData()
        {
        }

        private void SaveToFiles()
        {
        }

        public void LoadData()
        {
        }

        private void LoadFromFiles()
        {
        }

        private void SaveComplete()
        {
        }

        private void LoadComplete()
        {
        }
    }
}