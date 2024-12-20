using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_LOCAL_CHAT_AUDIO_INPUT_CHANGED_STATE_CHANGE : PARTY_STATE_CHANGE
	{
		public PARTY_CHAT_CONTROL_HANDLE localChatControl { get; }

		public PARTY_AUDIO_INPUT_STATE state { get; }

		public uint errorDetail { get; }

		internal PARTY_LOCAL_CHAT_AUDIO_INPUT_CHANGED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}
