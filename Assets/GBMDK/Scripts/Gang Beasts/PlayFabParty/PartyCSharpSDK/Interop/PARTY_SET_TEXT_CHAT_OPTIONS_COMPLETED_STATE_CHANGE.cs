using System;

namespace PartyCSharpSDK.Interop
{
	internal struct PARTY_SET_TEXT_CHAT_OPTIONS_COMPLETED_STATE_CHANGE
	{
		internal readonly PARTY_STATE_CHANGE stateChange;

		internal readonly PARTY_STATE_CHANGE_RESULT result;

		internal readonly uint errorDetail;

		internal readonly PARTY_CHAT_CONTROL_HANDLE localChatControl;

		internal readonly PARTY_TEXT_CHAT_OPTIONS options;

		internal readonly IntPtr asyncIdentifier;
	}
}
