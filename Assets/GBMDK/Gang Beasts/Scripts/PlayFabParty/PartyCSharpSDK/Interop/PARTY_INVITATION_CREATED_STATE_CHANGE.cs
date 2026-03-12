namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_INVITATION_CREATED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly PARTY_INVITATION_HANDLE invitation;
    }
}