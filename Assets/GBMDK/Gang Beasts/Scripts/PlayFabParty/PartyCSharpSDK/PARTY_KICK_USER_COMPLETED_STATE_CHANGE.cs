using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_KICK_USER_COMPLETED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_KICK_USER_COMPLETED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_STATE_CHANGE_RESULT result { get; }

        public uint errorDetail { get; }

        public PARTY_NETWORK_HANDLE network { get; }

        public string kickedEntityId { get; }

        public object asyncIdentifier { get; }
    }
}