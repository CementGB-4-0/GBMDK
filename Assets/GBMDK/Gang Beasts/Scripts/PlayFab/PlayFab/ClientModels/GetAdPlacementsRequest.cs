using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetAdPlacementsRequest : PlayFabRequestCommon
    {
        public string AppId;

        public NameIdentifier Identifier;
    }
}