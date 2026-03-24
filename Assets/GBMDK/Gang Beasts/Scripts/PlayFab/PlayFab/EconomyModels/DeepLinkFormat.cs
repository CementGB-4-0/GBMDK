using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class DeepLinkFormat : PlayFabBaseModel
    {
        public string Format;

        public string Platform;
    }
}