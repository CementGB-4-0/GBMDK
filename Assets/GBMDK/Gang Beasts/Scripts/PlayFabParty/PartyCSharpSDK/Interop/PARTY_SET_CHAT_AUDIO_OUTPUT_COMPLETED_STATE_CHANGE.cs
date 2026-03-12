using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_SET_CHAT_AUDIO_OUTPUT_COMPLETED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly PARTY_CHAT_CONTROL_HANDLE localChatControl;

        internal readonly PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType;

        internal readonly IntPtr audioDeviceSelectionContext;

        internal readonly IntPtr asyncIdentifier;
    }
}