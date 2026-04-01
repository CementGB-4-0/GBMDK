using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_SET_LANGUAGE_COMPLETED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_SET_LANGUAGE_COMPLETED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_STATE_CHANGE_RESULT result { get; }

        public uint errorDetail { get; }

        public PARTY_CHAT_CONTROL_HANDLE localChatControl { get; }

        public string languageCode { get; }

        public object asyncIdentifier { get; }
    }
}