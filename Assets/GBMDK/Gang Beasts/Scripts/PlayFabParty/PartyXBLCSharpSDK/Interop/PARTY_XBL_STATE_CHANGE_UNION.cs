using System.Runtime.InteropServices;

namespace PartyXBLCSharpSDK.Interop
{
    [StructLayout((LayoutKind)2)]
    internal struct PARTY_XBL_STATE_CHANGE_UNION
    {
        [FieldOffset(0)] internal readonly PARTY_XBL_STATE_CHANGE stateChange;

        [FieldOffset(0)]
        internal readonly PARTY_XBL_CREATE_LOCAL_CHAT_USER_COMPLETED_STATE_CHANGE createLocalChatUserCompleted;

        [FieldOffset(0)] internal readonly PARTY_XBL_LOGIN_TO_PLAYFAB_COMPLETED_STATE_CHANGE loginToPlayfabCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_XBL_GET_ENTITY_IDS_FROM_XBOX_LIVE_USER_IDS_COMPLETED_STATE_CHANGE
            getEntityIdsFromXboxLiveUserIdsCompleted;

        [FieldOffset(0)] internal readonly PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_STATE_CHANGE localChatUserDestroyed;

        [FieldOffset(0)]
        internal readonly PARTY_XBL_REQUIRED_CHAT_PERMISSION_INFO_CHANGED_STATE_CHANGE
            requiredChatPermissionInfoChanged;

        [FieldOffset(0)]
        internal readonly PARTY_XBL_TOKEN_AND_SIGNATURE_REQUESTED_STATE_CHANGE tokenAndSignatureRequested;
    }
}