namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_REMOTE_DEVICE_JOINED_NETWORK_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_DEVICE_HANDLE device;

        internal readonly PARTY_NETWORK_HANDLE network;
    }
}