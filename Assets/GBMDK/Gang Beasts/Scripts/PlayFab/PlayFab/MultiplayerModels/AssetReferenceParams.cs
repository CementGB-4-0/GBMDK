using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class AssetReferenceParams : PlayFabBaseModel
    {
        public string FileName;

        public string MountPath;
    }
}