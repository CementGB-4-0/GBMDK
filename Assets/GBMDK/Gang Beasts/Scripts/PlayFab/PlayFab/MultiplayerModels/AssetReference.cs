using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class AssetReference : PlayFabBaseModel
    {
        public string FileName;

        public string MountPath;
    }
}