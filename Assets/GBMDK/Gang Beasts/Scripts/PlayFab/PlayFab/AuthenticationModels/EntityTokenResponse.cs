using System;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
    [Serializable]
    public class EntityTokenResponse : PlayFabBaseModel
    {
        public EntityKey Entity;

        public string EntityToken;

        public DateTime? TokenExpiration;
    }
}