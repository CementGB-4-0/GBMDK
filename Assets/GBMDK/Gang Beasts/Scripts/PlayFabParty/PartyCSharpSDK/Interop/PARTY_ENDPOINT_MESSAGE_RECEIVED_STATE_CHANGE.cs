using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_ENDPOINT_MESSAGE_RECEIVED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly PARTY_ENDPOINT_HANDLE senderEndpoint;

        internal readonly uint receiverEndpointCount;

        internal readonly IntPtr receiverEndpoints;

        internal readonly PARTY_MESSAGE_RECEIVED_OPTIONS options;

        internal readonly uint messageSize;

        internal readonly IntPtr messageBuffer;
    }
}