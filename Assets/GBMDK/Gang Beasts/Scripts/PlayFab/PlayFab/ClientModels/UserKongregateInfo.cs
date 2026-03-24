using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserKongregateInfo : PlayFabBaseModel
    {
        public string KongregateId;

        public string KongregateName;
    }
}