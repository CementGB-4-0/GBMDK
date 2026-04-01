using System;
using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
    public class PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_STATE_CHANGE : PARTY_XBL_STATE_CHANGE
    {
        internal PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_STATE_CHANGE(PARTY_XBL_STATE_CHANGE_UNION stateChange,
            IntPtr StateChangeId)
            : base(default(PARTY_XBL_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_XBL_CHAT_USER_HANDLE localChatUser { get; }

        public PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON reason { get; }

        public uint errorDetail { get; }
    }
}