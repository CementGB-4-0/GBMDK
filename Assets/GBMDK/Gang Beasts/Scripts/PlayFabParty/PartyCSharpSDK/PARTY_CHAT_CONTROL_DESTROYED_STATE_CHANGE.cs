using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_CHAT_CONTROL_DESTROYED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_CHAT_CONTROL_DESTROYED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_CHAT_CONTROL_HANDLE chatControl { get; }

        public PARTY_DESTROYED_REASON reason { get; }

        public uint errorDetail { get; }
    }
}