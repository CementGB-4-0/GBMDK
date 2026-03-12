using System.ComponentModel;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Storage
{
    internal interface IStorageTask
    {
        LocalID LocalID { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        StorageTaskType TaskType { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        bool Cancel { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        int PrepDataSave();

        [EditorBrowsable(EditorBrowsableState.Never)]
        bool GetData(int step, out string file, out byte[] data);

        [EditorBrowsable(EditorBrowsableState.Never)]
        int PrepDataLoad();

        [EditorBrowsable(EditorBrowsableState.Never)]
        bool SetData(int step, byte[] data);

        [EditorBrowsable(EditorBrowsableState.Never)]
        bool SetSystemResult(int step, uint result);

        [EditorBrowsable(EditorBrowsableState.Never)]
        bool IsCloud(int step);

        [EditorBrowsable(EditorBrowsableState.Never)]
        void Finish(uint pass);

        [EditorBrowsable(EditorBrowsableState.Never)]
        void Failed(uint pass);
    }
}