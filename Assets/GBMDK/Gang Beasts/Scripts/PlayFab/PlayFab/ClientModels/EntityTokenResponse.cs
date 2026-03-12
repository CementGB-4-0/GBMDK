using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class EntityTokenResponse : PlayFabBaseModel
    {
        public EntityKey Entity;

        public string EntityToken;

        public DateTime? TokenExpiration;
    }
}