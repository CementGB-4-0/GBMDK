using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_CREATE_CHAT_CONTROL_COMPLETED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly PARTY_DEVICE_HANDLE localDevice;

        internal readonly PARTY_LOCAL_USER_HANDLE localUser;

        internal readonly IntPtr languageCode;

        internal readonly IntPtr asyncIdentifier;

        internal readonly PARTY_CHAT_CONTROL_HANDLE localChatControl;
    }
}