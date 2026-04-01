using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    public class PARTY_CREATE_NEW_NETWORK_COMPLETED_STATE_CHANGE : PARTY_STATE_CHANGE
    {
        internal PARTY_CREATE_NEW_NETWORK_COMPLETED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange,
            IntPtr StateChangeId)
            : base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_STATE_CHANGE_RESULT result { get; }

        public uint errorDetail { get; }

        public PARTY_LOCAL_USER_HANDLE localUser { get; }

        public PARTY_NETWORK_CONFIGURATION networkConfiguration { get; }

        public uint regionCount { get; }

        public PARTY_REGION[] regions { get; }

        public object asyncIdentifier { get; }

        public PARTY_NETWORK_DESCRIPTOR networkDescriptor { get; }

        public string appliedInitialInvitationIdentifier { get; }
    }
}