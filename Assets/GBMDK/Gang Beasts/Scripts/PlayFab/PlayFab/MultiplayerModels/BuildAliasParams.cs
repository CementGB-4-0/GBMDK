using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class BuildAliasParams : PlayFabBaseModel
    {
        public string AliasId;
    }
}