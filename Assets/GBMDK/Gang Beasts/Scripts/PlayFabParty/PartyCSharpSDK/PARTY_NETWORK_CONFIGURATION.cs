namespace PartyCSharpSDK
{
    public class PARTY_NETWORK_CONFIGURATION
    {
        internal PARTY_NETWORK_CONFIGURATION(Interop.PARTY_NETWORK_CONFIGURATION interopStruct)
        {
        }

        public PARTY_NETWORK_CONFIGURATION()
        {
        }

        public uint MaxUserCount { get; set; }

        public uint MaxDeviceCount { get; set; }

        public uint MaxUsersPerDeviceCount { get; set; }

        public uint MaxDevicesPerUserCount { get; set; }

        public uint MaxEndpointsPerDeviceCount { get; set; }

        public PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS DirectPeerConnectivityOptions { get; set; }
    }
}