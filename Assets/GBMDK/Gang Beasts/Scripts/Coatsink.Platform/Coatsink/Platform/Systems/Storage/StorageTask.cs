using System.ComponentModel;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Storage
{
    public abstract class StorageTask<T> : TaskResultBase<T>, IStorageTask where T : TaskResultBase<T>
    {
        private bool _cancel;

        private object _cancelLock;
        private StorageTaskType _type;

        protected LocalID _user;

        public LocalID LocalID
        {
            get { return default(LocalID); }
            set { }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public StorageTaskType TaskType
        {
            get { return default(StorageTaskType); }
            set { }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Cancel => false;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract bool IsCloud(int step);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract bool GetData(int step, out string file, out byte[] data);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract int PrepDataLoad();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract int PrepDataSave();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract bool SetData(int step, byte[] data);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract bool SetSystemResult(int step, uint result);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Finish(uint pass)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Failed(uint code)
        {
        }

        protected override void Clear(bool deepReset)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Enqueued()
        {
        }
    }
}