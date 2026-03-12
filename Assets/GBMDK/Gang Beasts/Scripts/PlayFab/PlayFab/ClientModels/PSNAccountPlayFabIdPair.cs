using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class PSNAccountPlayFabIdPair : PlayFabBaseModel
    {
        public string PlayFabId;

        public string PSNAccountId;
    }
}