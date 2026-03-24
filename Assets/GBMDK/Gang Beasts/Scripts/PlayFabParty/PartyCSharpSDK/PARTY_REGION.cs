namespace PartyCSharpSDK
{
    public class PARTY_REGION
    {
        internal PARTY_REGION(Interop.PARTY_REGION interopStruct)
        {
        }

        public string RegionName { get; }

        public uint RoundTripLatencyInMilliseconds { get; }
    }
}