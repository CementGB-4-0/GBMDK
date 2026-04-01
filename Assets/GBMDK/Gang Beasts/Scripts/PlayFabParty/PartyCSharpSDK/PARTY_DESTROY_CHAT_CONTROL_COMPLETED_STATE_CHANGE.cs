using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_DESTROY_CHAT_CONTROL_COMPLETED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_DESTROY_CHAT_CONTROL_COMPLETED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange,
            IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_STATE_CHANGE_RESULT result { get; }

        public uint errorDetail { get; }

        public PARTY_DEVICE_HANDLE localDevice { get; }

        public PARTY_CHAT_CONTROL_HANDLE localChatControl { get; }

        public object asyncIdentifier { get; }
    }
}