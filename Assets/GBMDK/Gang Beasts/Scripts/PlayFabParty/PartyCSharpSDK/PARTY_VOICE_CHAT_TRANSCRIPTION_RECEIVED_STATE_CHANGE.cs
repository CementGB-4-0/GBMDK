using System;
using System.Collections.Generic;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_VOICE_CHAT_TRANSCRIPTION_RECEIVED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_VOICE_CHAT_TRANSCRIPTION_RECEIVED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange,
            IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_STATE_CHANGE_RESULT result { get; }

        public uint errorDetail { get; }

        public PARTY_CHAT_CONTROL_HANDLE senderChatControl { get; }

        public List<PARTY_CHAT_CONTROL_HANDLE> receiverChatControls { get; }

        public PARTY_AUDIO_SOURCE_TYPE sourceType { get; }

        public string languageCode { get; }

        public string transcription { get; }

        public PARTY_VOICE_CHAT_TRANSCRIPTION_PHRASE_TYPE type { get; }

        public List<PARTY_TRANSLATION> translations { get; }

        internal override void Cleanup()
        {
        }
    }
}