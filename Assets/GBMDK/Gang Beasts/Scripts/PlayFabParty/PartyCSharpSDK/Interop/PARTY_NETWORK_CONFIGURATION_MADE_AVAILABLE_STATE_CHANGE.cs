using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_NETWORK_CONFIGURATION_MADE_AVAILABLE_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly IntPtr networkConfiguration;
    }
}