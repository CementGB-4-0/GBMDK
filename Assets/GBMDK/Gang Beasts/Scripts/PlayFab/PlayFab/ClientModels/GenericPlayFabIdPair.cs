using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GenericPlayFabIdPair : PlayFabBaseModel
    {
        public GenericServiceId GenericId;

        public string PlayFabId;
    }
}