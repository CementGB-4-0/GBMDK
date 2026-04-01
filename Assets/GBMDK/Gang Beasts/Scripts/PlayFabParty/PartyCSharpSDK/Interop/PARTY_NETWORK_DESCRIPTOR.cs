namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_NETWORK_DESCRIPTOR
    {
        private unsafe fixed byte networkIdentifier[37];

        private unsafe fixed byte regionName[20];

        private unsafe fixed byte opaqueConnectionInformation[301];

        internal string GetNetworkIdentifier()
        {
            return null;
        }

        internal string GetRegionName()
        {
            return null;
        }

        internal byte[] GetOpaqueConnectionInformation()
        {
            return null;
        }

        internal PARTY_NETWORK_DESCRIPTOR(PartyCSharpSDK.PARTY_NETWORK_DESCRIPTOR publicObject)
        {
        }
    }
}