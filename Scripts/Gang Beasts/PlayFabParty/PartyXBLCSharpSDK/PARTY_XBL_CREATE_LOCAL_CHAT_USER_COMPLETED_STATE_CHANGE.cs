using System;
using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_CREATE_LOCAL_CHAT_USER_COMPLETED_STATE_CHANGE : PARTY_XBL_STATE_CHANGE
	{
		public PARTY_XBL_STATE_CHANGE_RESULT result { get; }

		public uint errorDetail { get; }

		public object asyncIdentifier { get; }

		public PARTY_XBL_CHAT_USER_HANDLE localChatUser { get; }

		internal PARTY_XBL_CREATE_LOCAL_CHAT_USER_COMPLETED_STATE_CHANGE(PARTY_XBL_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_XBL_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}
