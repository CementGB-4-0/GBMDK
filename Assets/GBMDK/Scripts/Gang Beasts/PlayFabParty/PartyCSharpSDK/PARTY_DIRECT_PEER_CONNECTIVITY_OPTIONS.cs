namespace PartyCSharpSDK
{
	public enum PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS : uint
	{
		PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS_NONE = 0u,
		PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS_SAME_PLATFORM_TYPE = 1u,
		PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS_DIFFERENT_PLATFORM_TYPE = 2u,
		PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS_ANY_PLATFORM_TYPE = 3u,
		PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS_SAME_ENTITY_LOGIN_PROVIDER = 4u,
		PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS_DIFFERENT_ENTITY_LOGIN_PROVIDER = 8u,
		PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS_ANY_ENTITY_LOGIN_PROVIDER = 12u
	}
}
