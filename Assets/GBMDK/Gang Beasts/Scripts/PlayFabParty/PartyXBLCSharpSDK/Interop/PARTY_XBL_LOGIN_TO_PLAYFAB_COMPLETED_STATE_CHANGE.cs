using System;

namespace PartyXBLCSharpSDK.Interop
{
    internal struct PARTY_XBL_LOGIN_TO_PLAYFAB_COMPLETED_STATE_CHANGE
    {
        internal readonly PARTY_XBL_STATE_CHANGE stateChange;

        internal readonly PARTY_XBL_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly PARTY_XBL_CHAT_USER_HANDLE localChatUser;

        internal readonly IntPtr asyncIdentifier;

        internal readonly IntPtr entityId;

        internal readonly IntPtr titlePlayerEntityToken;

        internal readonly long expirationTime;
    }
}