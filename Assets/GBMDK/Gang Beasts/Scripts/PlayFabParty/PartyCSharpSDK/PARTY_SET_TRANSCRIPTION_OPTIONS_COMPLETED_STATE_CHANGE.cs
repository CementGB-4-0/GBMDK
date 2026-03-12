using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_SET_TRANSCRIPTION_OPTIONS_COMPLETED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_SET_TRANSCRIPTION_OPTIONS_COMPLETED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange,
            IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_STATE_CHANGE_RESULT result { get; }

        public uint errorDetail { get; }

        public PARTY_CHAT_CONTROL_HANDLE localChatControl { get; }

        public PARTY_VOICE_CHAT_TRANSCRIPTION_OPTIONS options { get; }

        public object asyncIdentifier { get; }
    }
}