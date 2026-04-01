using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ContactEmailInfoModel : PlayFabBaseModel
    {
        public string EmailAddress;

        public string Name;

        public EmailVerificationStatus? VerificationStatus;
    }
}