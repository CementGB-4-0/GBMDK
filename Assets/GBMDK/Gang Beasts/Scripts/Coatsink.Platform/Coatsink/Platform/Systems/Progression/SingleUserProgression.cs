using Coatsink.Platform.Systems.Storage;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Progression
{
    public class SingleUserProgression : IProgressionManager
    {
        protected AchievementCarrier _carrierAchie;

        protected SingleStorageTask _carrierLoader;

        protected SingleStorageTask _carrierSaver;

        protected StatsCarrier _carrierStats;

        protected bool _cloudStorage;

        protected byte[] _encryptionkey;

        protected string _file;

        protected LocalID _localID;
        protected object _locker;

        protected bool _registered;

        public SingleUserProgression(LocalID localID, string file, byte[] key, bool cloud)
        {
        }

        public bool IsAchievementUnlocked(LocalID localID, string achievementCode)
        {
            return false;
        }

        public void SetAchievement(LocalID localID, string achievementCode, bool unlock)
        {
        }

        public void Load(LocalID localID)
        {
        }

        private void LoadCarrier(SingleStorageTask task)
        {
        }

        private void CheckReload(StorageTask<SingleStorageTask> task)
        {
        }

        public void Save()
        {
        }

        private void SaveCarrier(SingleStorageTask task)
        {
        }

        private void CheckSave(StorageTask<SingleStorageTask> task)
        {
        }

        ~SingleUserProgression()
        {
        }
    }
}