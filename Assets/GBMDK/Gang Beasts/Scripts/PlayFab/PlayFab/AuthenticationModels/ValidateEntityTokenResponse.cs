using System;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
    [Serializable]
    public class ValidateEntityTokenResponse : PlayFabResultCommon
    {
        public EntityKey Entity;

        public string IdentityProviderIssuedId;

        public EntityLineage Lineage;

        public IdentifiedDeviceType? IdentifiedDeviceType;

        public LoginIdentityProvider? IdentityProvider;
    }
}