using CS.CorePlatform.Utils;

namespace CS.CorePlatform.Base.Client.Part
{
    public class SystemSaveLoad : BaseStorage
    {
        private bool _failed;

        private bool _loading;
        private BasePlatformManager _manager;

        private ThreadHandler _saveloadThread;

        private bool _saving;

        public override bool IsLoading => false;

        public override bool IsSaving => false;

        public override bool IsBusy => false;

        public void Awake()
        {
        }

        protected void OnDestroy()
        {
        }

        protected override void SaveData()
        {
        }

        private void SaveToFiles()
        {
        }

        protected override void LoadData()
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