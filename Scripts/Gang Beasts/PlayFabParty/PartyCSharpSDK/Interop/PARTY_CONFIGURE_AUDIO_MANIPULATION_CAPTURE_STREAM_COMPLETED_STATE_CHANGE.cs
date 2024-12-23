using System;

namespace PartyCSharpSDK.Interop
{
	internal struct PARTY_CONFIGURE_AUDIO_MANIPULATION_CAPTURE_STREAM_COMPLETED_STATE_CHANGE
	{
		internal readonly PARTY_STATE_CHANGE stateChange;

		internal readonly PARTY_STATE_CHANGE_RESULT result;

		internal readonly uint errorDetail;

		internal readonly PARTY_CHAT_CONTROL_HANDLE localChatControl;

		internal readonly IntPtr configuration;

		internal readonly IntPtr asyncIdentifier;
	}
}
