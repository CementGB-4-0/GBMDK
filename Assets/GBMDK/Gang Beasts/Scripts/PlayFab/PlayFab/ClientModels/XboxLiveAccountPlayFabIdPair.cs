using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class XboxLiveAccountPlayFabIdPair : PlayFabBaseModel
    {
        public string PlayFabId;

        public string XboxLiveAccountId;
    }
}