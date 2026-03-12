namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_CHAT_CONTROL_LEFT_NETWORK_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_DESTROYED_REASON reason;

        internal readonly uint errorDetail;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly PARTY_CHAT_CONTROL_HANDLE chatControl;
    }
}