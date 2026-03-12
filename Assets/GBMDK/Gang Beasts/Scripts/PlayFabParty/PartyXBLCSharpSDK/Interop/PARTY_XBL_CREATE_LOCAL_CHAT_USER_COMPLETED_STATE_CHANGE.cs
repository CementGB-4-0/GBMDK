using System;

namespace PartyXBLCSharpSDK.Interop
{
    internal struct PARTY_XBL_CREATE_LOCAL_CHAT_USER_COMPLETED_STATE_CHANGE
    {
        internal readonly PARTY_XBL_STATE_CHANGE stateChange;

        internal readonly PARTY_XBL_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly IntPtr asyncIdentifier;

        internal readonly PARTY_XBL_CHAT_USER_HANDLE localChatUser;
    }
}