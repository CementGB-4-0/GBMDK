namespace PlayFab.Party
{
    public class PlayFabLocalPlayer : PlayFabPlayer
    {
        internal string _preferredLanguageCode;

        public bool IsChatControlAvailable => false;

        public string LanguageCode
        {
            get { return null; }
            set { }
        }

        public string PlatformSpecificUserId => null;
    }
}