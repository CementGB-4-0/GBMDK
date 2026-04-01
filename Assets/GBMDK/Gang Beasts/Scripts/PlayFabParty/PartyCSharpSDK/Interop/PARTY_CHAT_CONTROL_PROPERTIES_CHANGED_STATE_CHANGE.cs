using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_CHAT_CONTROL_PROPERTIES_CHANGED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_CHAT_CONTROL_HANDLE chatControl;

        internal readonly uint propertyCount;

        internal readonly IntPtr keys;
    }
}