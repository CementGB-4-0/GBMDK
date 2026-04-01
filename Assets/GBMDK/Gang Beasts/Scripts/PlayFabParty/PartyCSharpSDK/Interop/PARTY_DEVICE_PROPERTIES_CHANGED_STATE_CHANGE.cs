using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_DEVICE_PROPERTIES_CHANGED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_DEVICE_HANDLE device;

        internal readonly uint propertyCount;

        internal readonly IntPtr keys;
    }
}