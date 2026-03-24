using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_SYNCHRONIZE_MESSAGES_BETWEEN_ENDPOINTS_COMPLETED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly uint endpointCount;

        internal readonly IntPtr endpoints;

        internal readonly PARTY_SYNCHRONIZE_MESSAGES_BETWEEN_ENDPOINTS_OPTIONS options;

        internal readonly IntPtr asyncIdentifier;
    }
}