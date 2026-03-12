using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_NETWORK_PROPERTIES_CHANGED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_NETWORK_HANDLE network;

        internal readonly uint propertyCount;

        internal readonly IntPtr keys;
    }
}