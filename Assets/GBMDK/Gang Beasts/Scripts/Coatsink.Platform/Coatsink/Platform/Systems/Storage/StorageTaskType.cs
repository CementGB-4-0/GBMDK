using System.ComponentModel;

namespace Coatsink.Platform.Systems.Storage
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public enum StorageTaskType
    {
        Save = 0,
        Load = 1,
        Exists = 2
    }
}