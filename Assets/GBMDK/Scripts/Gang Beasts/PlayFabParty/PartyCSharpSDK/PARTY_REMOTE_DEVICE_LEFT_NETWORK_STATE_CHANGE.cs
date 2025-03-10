using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_REMOTE_DEVICE_LEFT_NETWORK_STATE_CHANGE : PARTY_STATE_CHANGE
	{
		public PARTY_DESTROYED_REASON reason { get; }

		public uint errorDetail { get; }

		public PARTY_DEVICE_HANDLE device { get; }

		public PARTY_NETWORK_HANDLE network { get; }

		internal PARTY_REMOTE_DEVICE_LEFT_NETWORK_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}
