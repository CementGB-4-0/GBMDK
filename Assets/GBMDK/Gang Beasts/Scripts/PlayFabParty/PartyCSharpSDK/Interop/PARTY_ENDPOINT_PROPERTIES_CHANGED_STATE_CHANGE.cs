using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_ENDPOINT_PROPERTIES_CHANGED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_ENDPOINT_HANDLE endpoint;

        internal readonly uint propertyCount;

        internal readonly IntPtr keys;
    }
}