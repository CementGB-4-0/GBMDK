using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_ENDPOINT_DESTROYED_STATE_CHANGE : PARTY_STATE_CHANGE
	{
		public PARTY_NETWORK_HANDLE network { get; }

		public PARTY_ENDPOINT_HANDLE endpoint { get; }

		public PARTY_DESTROYED_REASON reason { get; }

		public uint errorDetail { get; }

		internal PARTY_ENDPOINT_DESTROYED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}
