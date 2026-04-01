using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class DeepLink : PlayFabBaseModel
    {
        public string Platform;

        public string Url;
    }
}