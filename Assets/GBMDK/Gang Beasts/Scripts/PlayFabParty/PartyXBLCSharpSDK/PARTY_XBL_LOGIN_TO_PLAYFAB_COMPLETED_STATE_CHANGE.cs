using System;
using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
    public class PARTY_XBL_LOGIN_TO_PLAYFAB_COMPLETED_STATE_CHANGE : PARTY_XBL_STATE_CHANGE
    {
        internal PARTY_XBL_LOGIN_TO_PLAYFAB_COMPLETED_STATE_CHANGE(PARTY_XBL_STATE_CHANGE_UNION stateChange,
            IntPtr StateChangeId)
            : base(default(PARTY_XBL_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public PARTY_XBL_STATE_CHANGE_RESULT result { get; }

        public uint errorDetail { get; }

        public PARTY_XBL_CHAT_USER_HANDLE localChatUser { get; }

        public object asyncIdentifier { get; }

        public string entityId { get; }

        public string titlePlayerEntityToken { get; }

        public long expirationTime { get; }
    }
}