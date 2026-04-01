using System;
using System.Collections.Generic;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_ENDPOINT_MESSAGE_RECEIVED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_ENDPOINT_MESSAGE_RECEIVED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange,
            IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_NETWORK_HANDLE network { get; }

        public PARTY_ENDPOINT_HANDLE senderEndpoint { get; }

        public List<PARTY_ENDPOINT_HANDLE> receiverEndpoints { get; }

        public PARTY_MESSAGE_RECEIVED_OPTIONS options { get; }

        public uint messageSize { get; }

        public IntPtr messageBuffer { get; }

        internal override void Cleanup()
        {
        }
    }
}