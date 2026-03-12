namespace PlayFab.Party
{
    public class PlayFabNetworkConfiguration
    {
        private const uint _MAX_SUPPORTED_PLAYER_COUNT = 32u;

        private const string _ErrorMessageMaxUserCountValueOutOfRange = "Value must be between 1 and {0}";
        private uint _maxPlayerCount;

        public uint MaxPlayerCount
        {
            get { return 0u; }
            set { }
        }
    }
}