using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_SET_TEXT_TO_SPEECH_PROFILE_COMPLETED_STATE_CHANGE : PARTY_STATE_CHANGE
	{
		public PARTY_STATE_CHANGE_RESULT result { get; }

		public uint errorDetail { get; }

		public PARTY_CHAT_CONTROL_HANDLE localChatControl { get; }

		public PARTY_SYNTHESIZE_TEXT_TO_SPEECH_TYPE type { get; }

		public string profileIdentifier { get; }

		public object asyncIdentifier { get; }

		internal PARTY_SET_TEXT_TO_SPEECH_PROFILE_COMPLETED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}
