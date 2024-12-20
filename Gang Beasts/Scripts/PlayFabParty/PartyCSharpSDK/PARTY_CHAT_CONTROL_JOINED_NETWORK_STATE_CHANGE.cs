using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_CHAT_CONTROL_JOINED_NETWORK_STATE_CHANGE : PARTY_STATE_CHANGE
	{
		public PARTY_NETWORK_HANDLE network { get; }

		public PARTY_CHAT_CONTROL_HANDLE chatControl { get; }

		internal PARTY_CHAT_CONTROL_JOINED_NETWORK_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}
