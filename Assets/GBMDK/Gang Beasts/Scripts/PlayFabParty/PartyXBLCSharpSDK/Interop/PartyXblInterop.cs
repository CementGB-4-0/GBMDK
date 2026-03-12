using System;
using System.Runtime.InteropServices;
using PartyCSharpSDK;

namespace PartyXBLCSharpSDK.Interop
{
    internal class PartyXblInterop
    {
        private const string ThunkDllName = "PartyXboxLiveWin32";

        [PreserveSig]
        internal static extern uint PartyXblStartProcessingStateChanges(PARTY_XBL_HANDLE handle,
            out uint stateChangeCount, out IntPtr stateChanges);

        [PreserveSig]
        internal static extern uint PartyXblDestroyChatUser(PARTY_XBL_HANDLE handle,
            PARTY_XBL_CHAT_USER_HANDLE chatUser);

        [PreserveSig]
        internal static extern uint PartyXblInitialize(IntPtr partyHandle, byte[] titleId, out PARTY_XBL_HANDLE handle);

        [PreserveSig]
        internal static extern uint PartyXblCompleteGetTokenAndSignatureRequest(PARTY_XBL_HANDLE handle,
            uint correlationId, byte succeeded, byte[] token, byte[] signature);

        [PreserveSig]
        internal static extern uint PartyXblLocalChatUserGetCrossNetworkCommunicationPrivacySetting(
            PARTY_XBL_CHAT_USER_HANDLE handle, out PARTY_XBL_CROSS_NETWORK_COMMUNICATION_PRIVACY_SETTING setting);

        [PreserveSig]
        internal static extern uint PartyXblLocalChatUserGetAccessibilitySettings(PARTY_XBL_CHAT_USER_HANDLE handle,
            out PARTY_XBL_ACCESSIBILITY_SETTINGS settings);

        [PreserveSig]
        internal static extern uint PartyXblCleanup(PARTY_XBL_HANDLE handle);

        [PreserveSig]
        internal static extern uint PartyXblGetChatUsers(PARTY_XBL_HANDLE handle, out uint chatUserCount,
            out IntPtr chatUsers);

        [PreserveSig]
        internal static extern uint PartyXblChatUserGetXboxUserId(PARTY_XBL_CHAT_USER_HANDLE handle,
            out ulong xboxUserId);

        [PreserveSig]
        internal static extern uint PartyXblLoginToPlayFab(PARTY_XBL_CHAT_USER_HANDLE localChatUser,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyXblCreateRemoteChatUser(PARTY_XBL_HANDLE handle, ulong xboxUserId,
            out PARTY_XBL_CHAT_USER_HANDLE chatUser);

        [PreserveSig]
        internal static extern uint PartyXblSetThreadAffinityMask(PARTY_XBL_THREAD_ID threadId,
            ulong threadAffinityMask);

        [PreserveSig]
        internal static extern uint PartyXblGetThreadAffinityMask(PARTY_XBL_THREAD_ID threadId,
            out ulong threadAffinityMask);

        [PreserveSig]
        internal static extern uint PartyXblChatUserIsLocal(PARTY_XBL_CHAT_USER_HANDLE handle, out byte isLocal);

        [PreserveSig]
        internal static extern uint PartyXblFinishProcessingStateChanges(PARTY_XBL_HANDLE handle, uint stateChangeCount,
            IntPtr stateChanges);

        [PreserveSig]
        internal static extern uint PartyXblChatUserSetCustomContext(PARTY_XBL_CHAT_USER_HANDLE handle,
            IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyXblChatUserGetCustomContext(PARTY_XBL_CHAT_USER_HANDLE handle,
            out IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyXblGetErrorMessage(uint error, out UTF8StringPtr errorMessage);

        [PreserveSig]
        internal static extern uint PartyXblCreateLocalChatUser(PARTY_XBL_HANDLE handle, ulong xboxUserId,
            IntPtr asyncIdentifier, out PARTY_XBL_CHAT_USER_HANDLE localXboxLiveUser);

        [PreserveSig]
        internal static extern uint PartyXblLocalChatUserGetRequiredChatPermissionInfo(
            PARTY_XBL_CHAT_USER_HANDLE handle, PARTY_XBL_CHAT_USER_HANDLE targetChaUser,
            out PARTY_XBL_CHAT_PERMISSION_INFO chatPermissionInfo);

        [PreserveSig]
        internal static extern uint PartyXblGetEntityIdsFromXboxLiveUserIds(PARTY_XBL_HANDLE handle,
            uint xboxLiveUserIdCount, ulong[] xboxLiveUserIds, PARTY_XBL_CHAT_USER_HANDLE localChatUser,
            IntPtr asyncIdentifier);
    }
}