namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_REGION
    {
        private unsafe fixed byte regionName[20];

        internal readonly uint roundTripLatencyInMilliseconds;

        internal string GetRegionName()
        {
            return null;
        }

        internal PARTY_REGION(PartyCSharpSDK.PARTY_REGION publicObject)
        {
            roundTripLatencyInMilliseconds = 0u;
        }
    }
}