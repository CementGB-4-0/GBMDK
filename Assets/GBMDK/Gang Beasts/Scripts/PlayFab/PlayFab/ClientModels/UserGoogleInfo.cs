using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserGoogleInfo : PlayFabBaseModel
    {
        public string GoogleEmail;

        public string GoogleGender;

        public string GoogleId;

        public string GoogleLocale;

        public string GoogleName;
    }
}