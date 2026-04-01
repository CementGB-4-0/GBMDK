using System;

namespace PartyXBLCSharpSDK.Interop
{
    internal struct PARTY_XBL_GET_ENTITY_IDS_FROM_XBOX_LIVE_USER_IDS_COMPLETED_STATE_CHANGE
    {
        internal readonly PARTY_XBL_STATE_CHANGE stateChange;

        internal readonly PARTY_XBL_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly IntPtr xboxLiveSandbox;

        internal readonly PARTY_XBL_CHAT_USER_HANDLE localChatUser;

        internal readonly IntPtr asyncIdentifier;

        internal readonly uint entityIdMappingCount;

        internal readonly IntPtr entityIdMappings;
    }
}