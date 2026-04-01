namespace PartyCSharpSDK
{
    public class PARTY_NETWORK_DESCRIPTOR
    {
        internal PARTY_NETWORK_DESCRIPTOR(Interop.PARTY_NETWORK_DESCRIPTOR interopStruct)
        {
        }

        public string NetworkIdentifier { get; }

        public string RegionName { get; }

        public byte[] OpaqueConnectionInformation { get; }
    }
}