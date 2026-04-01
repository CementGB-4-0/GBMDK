using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class PlayStation5Payload : PlayFabBaseModel
    {
        public List<string> Ids;

        public string ServiceLabel;
    }
}