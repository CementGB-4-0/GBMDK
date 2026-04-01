using System;
using System.ComponentModel;

namespace Coatsink.Platform.Systems.Storage
{
    public class SingleStorageTask : StorageTask<SingleStorageTask>
    {
        public bool Cloud;

        public byte[] Data;

        public string File;

        public uint LoadResult;

        public Action<SingleStorageTask> StorageThreadLogic;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool IsCloud(int step)
        {
            return false;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int PrepDataSave()
        {
            return 0;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool GetData(int step, out string file, out byte[] data)
        {
            file = null;
            data = null;
            return false;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int PrepDataLoad()
        {
            return 0;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool SetData(int step, byte[] data)
        {
            return false;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool SetSystemResult(int step, uint result)
        {
            return false;
        }

        protected override void Clear(bool deepReset)
        {
        }
    }
}