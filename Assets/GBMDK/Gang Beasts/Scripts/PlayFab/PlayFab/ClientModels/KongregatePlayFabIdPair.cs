using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class KongregatePlayFabIdPair : PlayFabBaseModel
    {
        public string KongregateId;

        public string PlayFabId;
    }
}