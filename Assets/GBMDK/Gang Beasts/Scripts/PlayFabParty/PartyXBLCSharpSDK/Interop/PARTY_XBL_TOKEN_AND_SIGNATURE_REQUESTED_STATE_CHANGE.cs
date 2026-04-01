using System;

namespace PartyXBLCSharpSDK.Interop
{
    internal struct PARTY_XBL_TOKEN_AND_SIGNATURE_REQUESTED_STATE_CHANGE
    {
        internal readonly PARTY_XBL_STATE_CHANGE stateChange;

        internal readonly uint correlationId;

        internal readonly IntPtr method;

        internal readonly IntPtr url;

        internal readonly uint headerCount;

        internal readonly IntPtr headers;

        internal readonly uint bodySize;

        internal readonly IntPtr body;

        internal readonly byte forceRefresh;

        internal readonly byte allUsers;

        internal readonly PARTY_XBL_CHAT_USER_HANDLE localChatUser;
    }
}