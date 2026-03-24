using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserSteamInfo : PlayFabBaseModel
    {
        public string SteamCountry;

        public string SteamId;

        public string SteamName;
        public TitleActivationStatus? SteamActivationStatus;

        public Currency? SteamCurrency;
    }
}