namespace PartyCSharpSDK.Interop
{
	internal struct PARTY_LOCAL_CHAT_AUDIO_OUTPUT_CHANGED_STATE_CHANGE
	{
		internal readonly PARTY_STATE_CHANGE stateChange;

		internal readonly PARTY_CHAT_CONTROL_HANDLE localChatControl;

		internal readonly PARTY_AUDIO_OUTPUT_STATE state;

		internal readonly uint errorDetail;
	}
}
