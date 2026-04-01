using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_ENDPOINT_CREATED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_ENDPOINT_CREATED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_NETWORK_HANDLE network { get; }

        public PARTY_ENDPOINT_HANDLE endpoint { get; }
    }
}