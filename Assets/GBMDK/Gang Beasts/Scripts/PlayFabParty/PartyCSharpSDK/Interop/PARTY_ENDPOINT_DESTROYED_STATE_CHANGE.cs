namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_ENDPOINT_DESTROYED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly PARTY_ENDPOINT_HANDLE endpoint;

        internal readonly PARTY_DESTROYED_REASON reason;

        internal readonly uint errorDetail;
    }
}