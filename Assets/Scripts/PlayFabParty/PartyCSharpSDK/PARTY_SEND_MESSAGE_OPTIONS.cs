namespace PartyCSharpSDK
{
	public enum PARTY_SEND_MESSAGE_OPTIONS : uint
	{
		PARTY_SEND_MESSAGE_OPTIONS_DEFAULT = 0u,
		PARTY_SEND_MESSAGE_OPTIONS_GUARANTEED_DELIVERY = 1u,
		PARTY_SEND_MESSAGE_OPTIONS_BEST_EFFORT_DELIVERY = 0u,
		PARTY_SEND_MESSAGE_OPTIONS_SEQUENTIAL_DELIVERY = 2u,
		PARTY_SEND_MESSAGE_OPTIONS_NONSEQUENTIAL_DELIVERY = 0u,
		PARTY_SEND_MESSAGE_OPTIONS_COALESCE_OPPORTUNISTICALLY = 0u,
		PARTY_SEND_MESSAGE_OPTIONS_ALWAYS_COALESCE_UNTIL_FLUSHED = 8u,
		PARTY_SEND_MESSAGE_OPTIONS_REQUIRE_TIMELY_ACKNOWLEDGEMENT = 0u,
		PARTY_SEND_MESSAGE_OPTIONS_ALLOW_LAZY_ACKNOWLEDGEMENT = 16u
	}
}
