using System;

namespace PartyCSharpSDK.Interop
{
	internal struct PARTY_KICK_USER_COMPLETED_STATE_CHANGE
	{
		internal readonly PARTY_STATE_CHANGE stateChange;

		internal readonly PARTY_STATE_CHANGE_RESULT result;

		internal readonly uint errorDetail;

		internal readonly PARTY_NETWORK_HANDLE network;

		internal readonly IntPtr kickedEntityId;

		internal readonly IntPtr asyncIdentifier;
	}
}
