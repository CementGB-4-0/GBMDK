using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_SYNTHESIZE_TEXT_TO_SPEECH_COMPLETED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly PARTY_CHAT_CONTROL_HANDLE localChatControl;

        internal readonly PARTY_SYNTHESIZE_TEXT_TO_SPEECH_TYPE type;

        internal readonly IntPtr textToSynthesize;

        internal readonly IntPtr asyncIdentifier;
    }
}