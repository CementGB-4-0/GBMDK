using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_VOICE_CHAT_TRANSCRIPTION_RECEIVED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly PARTY_CHAT_CONTROL_HANDLE senderChatControl;

        internal readonly uint receiverChatControlCount;

        internal readonly IntPtr receiverChatControls;

        internal readonly PARTY_AUDIO_SOURCE_TYPE sourceType;

        internal readonly IntPtr languageCode;

        internal readonly IntPtr transcription;

        internal readonly PARTY_VOICE_CHAT_TRANSCRIPTION_PHRASE_TYPE type;

        internal readonly uint translationCount;

        internal readonly IntPtr translations;
    }
}