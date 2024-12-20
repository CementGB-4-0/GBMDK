using System;

namespace PartyCSharpSDK.Interop
{
	internal struct PARTY_SET_CHAT_AUDIO_ENCODER_BITRATE_COMPLETED_STATE_CHANGE
	{
		internal readonly PARTY_STATE_CHANGE stateChange;

		internal readonly PARTY_STATE_CHANGE_RESULT result;

		internal readonly uint errorDetail;

		internal readonly PARTY_CHAT_CONTROL_HANDLE localChatControl;

		internal readonly uint bitrate;

		internal readonly IntPtr asyncIdentifier;
	}
}
