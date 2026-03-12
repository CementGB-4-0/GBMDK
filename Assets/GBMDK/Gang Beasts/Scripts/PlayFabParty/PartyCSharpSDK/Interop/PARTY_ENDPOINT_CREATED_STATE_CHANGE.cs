namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_ENDPOINT_CREATED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly PARTY_ENDPOINT_HANDLE endpoint;
    }
}