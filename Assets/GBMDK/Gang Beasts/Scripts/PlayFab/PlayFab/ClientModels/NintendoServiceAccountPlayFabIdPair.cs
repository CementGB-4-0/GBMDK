using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class NintendoServiceAccountPlayFabIdPair : PlayFabBaseModel
    {
        public string NintendoServiceAccountId;

        public string PlayFabId;
    }
}