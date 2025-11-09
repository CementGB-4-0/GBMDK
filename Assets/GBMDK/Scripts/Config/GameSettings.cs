#if UNITY_EDITOR
using System;

namespace GBMDK.Editor
{
    [Serializable]
    public struct GameSettings
    {
        public string gameFolderPath;
        public string launchArgs;
    }
}

#endif