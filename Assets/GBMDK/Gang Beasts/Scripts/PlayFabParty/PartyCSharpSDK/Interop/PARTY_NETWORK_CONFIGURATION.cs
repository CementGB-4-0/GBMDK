namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_NETWORK_CONFIGURATION
    {
        internal readonly uint maxUserCount;

        internal readonly uint maxDeviceCount;

        internal readonly uint maxUsersPerDeviceCount;

        internal readonly uint maxDevicesPerUserCount;

        internal readonly uint maxEndpointsPerDeviceCount;

        internal readonly PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS directPeerConnectivityOptions;

        internal PARTY_NETWORK_CONFIGURATION(PartyCSharpSDK.PARTY_NETWORK_CONFIGURATION publicObject)
        {
            maxUserCount = 0u;
            maxDeviceCount = 0u;
            maxUsersPerDeviceCount = 0u;
            maxDevicesPerUserCount = 0u;
            maxEndpointsPerDeviceCount = 0u;
            directPeerConnectivityOptions = default(PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS);
        }
    }
}