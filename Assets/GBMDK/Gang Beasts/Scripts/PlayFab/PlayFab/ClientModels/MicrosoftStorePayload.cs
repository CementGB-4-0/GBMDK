using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class MicrosoftStorePayload : PlayFabBaseModel
    {
        public string CollectionsMsIdKey;

        public string UserId;

        public string XboxToken;
    }
}