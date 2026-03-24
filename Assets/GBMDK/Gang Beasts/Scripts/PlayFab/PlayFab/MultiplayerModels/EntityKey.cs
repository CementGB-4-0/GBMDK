using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class EntityKey : PlayFabBaseModel
    {
        public string Id;

        public string Type;
    }
}