namespace PartyXBLCSharpSDK.Interop
{
    internal struct PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_STATE_CHANGE
    {
        internal readonly PARTY_XBL_STATE_CHANGE stateChange;

        internal readonly PARTY_XBL_CHAT_USER_HANDLE localChatUser;

        internal readonly PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON reason;

        internal readonly uint errorDetail;
    }
}