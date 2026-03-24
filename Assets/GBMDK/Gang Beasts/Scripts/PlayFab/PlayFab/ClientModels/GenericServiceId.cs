using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GenericServiceId : PlayFabBaseModel
    {
        public string ServiceName;

        public string UserId;
    }
}