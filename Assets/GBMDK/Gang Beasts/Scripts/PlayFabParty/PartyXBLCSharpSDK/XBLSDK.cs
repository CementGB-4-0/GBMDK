using System.Collections.Generic;
using PartyCSharpSDK;

namespace PartyXBLCSharpSDK
{
    public class XBLSDK
    {
        private const uint PartyErrorXblChatUserAlreadyExists = 20481u;

        internal static ObjectPool objectPool;

        static XBLSDK()
        {
        }

        public static uint PartyXblChatUserIsLocal(PARTY_XBL_CHAT_USER_HANDLE handle, out bool isLocal)
        {
            isLocal = default(bool);
            return 0u;
        }

        public static uint PartyXblChatUserGetXboxUserId(PARTY_XBL_CHAT_USER_HANDLE handle, out ulong xboxUserId)
        {
            xboxUserId = default(ulong);
            return 0u;
        }

        public static uint PartyXblChatUserSetCustomContext(PARTY_XBL_CHAT_USER_HANDLE handle, object customContext)
        {
            return 0u;
        }

        public static uint PartyXblChatUserGetCustomContext(PARTY_XBL_CHAT_USER_HANDLE handle, out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint PartyXblLocalChatUserGetAccessibilitySettings(PARTY_XBL_CHAT_USER_HANDLE handle,
            out PARTY_XBL_ACCESSIBILITY_SETTINGS settings)
        {
            settings = null;
            return 0u;
        }

        public static uint PartyXblLocalChatUserGetRequiredChatPermissionInfo(PARTY_XBL_CHAT_USER_HANDLE handle,
            PARTY_XBL_CHAT_USER_HANDLE targetChaUser, out PARTY_XBL_CHAT_PERMISSION_INFO chatPermissionInfo)
        {
            chatPermissionInfo = null;
            return 0u;
        }

        public static uint PartyXblLocalChatUserGetCrossNetworkCommunicationPrivacySetting(
            PARTY_XBL_CHAT_USER_HANDLE handle, out PARTY_XBL_CROSS_NETWORK_COMMUNICATION_PRIVACY_SETTING setting)
        {
            setting = default(PARTY_XBL_CROSS_NETWORK_COMMUNICATION_PRIVACY_SETTING);
            return 0u;
        }

        public static uint PartyXblGetErrorMessage(uint error, out string errorMessage)
        {
            errorMessage = null;
            return 0u;
        }

        public static uint PartyXblSetThreadAffinityMask(PARTY_XBL_THREAD_ID threadId, ulong threadAffinityMask)
        {
            return 0u;
        }

        public static uint PartyXblGetThreadAffinityMask(PARTY_XBL_THREAD_ID threadId, out ulong threadAffinityMask)
        {
            threadAffinityMask = default(ulong);
            return 0u;
        }

        public static uint PartyXblInitialize(string titleId, out PARTY_XBL_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        public static uint PartyXblCleanup(PARTY_XBL_HANDLE handle)
        {
            return 0u;
        }

        public static uint PartyXblStartProcessingStateChanges(PARTY_XBL_HANDLE handle,
            out List<PARTY_XBL_STATE_CHANGE> stateChanges)
        {
            stateChanges = null;
            return 0u;
        }

        public static uint PartyXblFinishProcessingStateChanges(PARTY_XBL_HANDLE handle,
            List<PARTY_XBL_STATE_CHANGE> stateChanges)
        {
            return 0u;
        }

        public static uint PartyXblCreateLocalChatUser(PARTY_XBL_HANDLE handle, ulong xboxUserId,
            object asyncIdentifier, out PARTY_XBL_CHAT_USER_HANDLE localXboxLiveUser)
        {
            localXboxLiveUser = null;
            return 0u;
        }

        public static uint PartyXblCompleteGetTokenAndSignatureRequest(PARTY_XBL_HANDLE handle, uint correlationId,
            bool succeeded, string token, string signature)
        {
            return 0u;
        }

        public static uint PartyXblCreateRemoteChatUser(PARTY_XBL_HANDLE handle, ulong xboxUserId,
            out PARTY_XBL_CHAT_USER_HANDLE chatUser)
        {
            chatUser = null;
            return 0u;
        }

        public static uint PartyXblDestroyChatUser(PARTY_XBL_HANDLE handle, PARTY_XBL_CHAT_USER_HANDLE chatUser)
        {
            return 0u;
        }

        public static uint PartyXblGetChatUsers(PARTY_XBL_HANDLE handle, out PARTY_XBL_CHAT_USER_HANDLE[] chatUsers)
        {
            chatUsers = null;
            return 0u;
        }

        public static uint PartyXblLoginToPlayFab(PARTY_XBL_CHAT_USER_HANDLE localChatUser, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyXblGetEntityIdsFromXboxLiveUserIds(PARTY_XBL_HANDLE handle, ulong[] xboxLiveUserIds,
            PARTY_XBL_CHAT_USER_HANDLE localChatUser, object asyncIdentifier)
        {
            return 0u;
        }
    }
}