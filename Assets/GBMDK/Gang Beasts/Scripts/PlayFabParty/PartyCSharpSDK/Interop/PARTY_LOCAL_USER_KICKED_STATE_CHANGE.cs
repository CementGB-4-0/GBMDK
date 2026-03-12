namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_LOCAL_USER_KICKED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly PARTY_LOCAL_USER_HANDLE localUser;
    }
}