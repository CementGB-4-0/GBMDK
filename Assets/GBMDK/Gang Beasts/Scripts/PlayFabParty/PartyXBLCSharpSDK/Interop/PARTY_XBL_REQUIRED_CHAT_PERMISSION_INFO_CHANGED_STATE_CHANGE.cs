namespace PartyXBLCSharpSDK.Interop
{
    internal struct PARTY_XBL_REQUIRED_CHAT_PERMISSION_INFO_CHANGED_STATE_CHANGE
    {
        internal readonly PARTY_XBL_STATE_CHANGE stateChange;

        internal readonly PARTY_XBL_CHAT_USER_HANDLE localChatUser;

        internal readonly PARTY_XBL_CHAT_USER_HANDLE targetChatUser;
    }
}