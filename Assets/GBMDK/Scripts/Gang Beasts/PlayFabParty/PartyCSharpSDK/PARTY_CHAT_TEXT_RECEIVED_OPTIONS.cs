namespace PartyCSharpSDK
{
	public enum PARTY_CHAT_TEXT_RECEIVED_OPTIONS : uint
	{
		PARTY_CHAT_TEXT_RECEIVED_OPTIONS_NONE = 0u,
		PARTY_CHAT_TEXT_RECEIVED_OPTIONS_FILTERED_OFFENSIVE_TERMS = 1u,
		PARTY_CHAT_TEXT_RECEIVED_OPTIONS_FILTERED_ENTIRE_MESSAGE = 2u,
		PARTY_CHAT_TEXT_RECEIVED_OPTIONS_FILTERED_DUE_TO_ERROR = 4u
	}
}
