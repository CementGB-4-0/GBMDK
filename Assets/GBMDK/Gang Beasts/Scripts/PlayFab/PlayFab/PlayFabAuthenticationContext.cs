namespace PlayFab
{
    public sealed class PlayFabAuthenticationContext
    {
        public string ClientSessionTicket;

        public string EntityId;

        public string EntityToken;

        public string EntityType;

        public string PlayFabId;

        public PlayFabAuthenticationContext()
        {
        }

        public PlayFabAuthenticationContext(string clientSessionTicket, string entityToken, string playFabId,
            string entityId, string entityType)
        {
        }

        public void CopyFrom(PlayFabAuthenticationContext other)
        {
        }

        public bool IsClientLoggedIn()
        {
            return false;
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }
    }
}