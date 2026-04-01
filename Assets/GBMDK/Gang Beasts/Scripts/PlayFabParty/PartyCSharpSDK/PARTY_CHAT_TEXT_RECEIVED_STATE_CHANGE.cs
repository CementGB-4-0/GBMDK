using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_CHAT_TEXT_RECEIVED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_CHAT_TEXT_RECEIVED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_CHAT_CONTROL_HANDLE senderChatControl { get; }

        public PARTY_CHAT_CONTROL_HANDLE[] receiverChatControls { get; }

        public string languageCode { get; }

        public string chatText { get; }

        public byte[] data { get; }

        public PARTY_TRANSLATION[] translations { get; }

        public PARTY_CHAT_TEXT_RECEIVED_OPTIONS options { get; }

        public string originalChatText { get; }

        public uint errorDetail { get; }
    }
}