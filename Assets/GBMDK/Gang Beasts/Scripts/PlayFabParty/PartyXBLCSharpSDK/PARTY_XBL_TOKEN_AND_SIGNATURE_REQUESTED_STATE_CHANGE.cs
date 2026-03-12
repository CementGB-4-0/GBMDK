using System;
using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
    public class PARTY_XBL_TOKEN_AND_SIGNATURE_REQUESTED_STATE_CHANGE : PARTY_XBL_STATE_CHANGE
    {
        internal PARTY_XBL_TOKEN_AND_SIGNATURE_REQUESTED_STATE_CHANGE(PARTY_XBL_STATE_CHANGE_UNION stateChange,
            IntPtr StateChangeId)
            : base(default(PARTY_XBL_STATE_CHANGE_TYPE), (IntPtr)0)
        {
        }

        public uint correlationId { get; }

        public string method { get; }

        public string url { get; }

        public PARTY_XBL_HTTP_HEADER[] headers { get; }

        public byte[] body { get; }

        public bool forceRefresh { get; }

        public bool allUsers { get; }

        public PARTY_XBL_CHAT_USER_HANDLE localChatUser { get; }
    }
}