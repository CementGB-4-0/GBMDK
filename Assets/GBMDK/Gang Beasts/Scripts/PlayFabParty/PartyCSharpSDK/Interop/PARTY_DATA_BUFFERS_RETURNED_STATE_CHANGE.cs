using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_DATA_BUFFERS_RETURNED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly PARTY_ENDPOINT_HANDLE localSenderEndpoint;

        internal readonly uint dataBufferCount;

        internal readonly IntPtr dataBuffers;

        internal readonly IntPtr messageIdentifier;
    }
}