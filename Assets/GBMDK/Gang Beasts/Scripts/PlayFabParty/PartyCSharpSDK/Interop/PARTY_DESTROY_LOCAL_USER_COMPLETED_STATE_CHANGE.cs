using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_DESTROY_LOCAL_USER_COMPLETED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly PARTY_LOCAL_USER_HANDLE localUser;

        internal readonly IntPtr asyncIdentifier;
    }
}