using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LoginResult : PlayFabLoginResultCommon
    {
        public EntityTokenResponse EntityToken;

        public GetPlayerCombinedInfoResultPayload InfoResultPayload;

        public bool NewlyCreated;

        public string PlayFabId;

        public string SessionTicket;

        public UserSettings SettingsForUser;

        public TreatmentAssignment TreatmentAssignment;

        public DateTime? LastLoginTime;
    }
}