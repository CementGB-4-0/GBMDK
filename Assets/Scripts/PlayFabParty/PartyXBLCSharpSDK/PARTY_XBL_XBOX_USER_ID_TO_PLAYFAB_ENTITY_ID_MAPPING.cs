using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_XBOX_USER_ID_TO_PLAYFAB_ENTITY_ID_MAPPING
	{
		public ulong xboxLiveUserId { get; }

		public string playfabEntityId { get; }

		internal PARTY_XBL_XBOX_USER_ID_TO_PLAYFAB_ENTITY_ID_MAPPING(PartyXBLCSharpSDK.Interop.PARTY_XBL_XBOX_USER_ID_TO_PLAYFAB_ENTITY_ID_MAPPING interopStruct)
		{
		}
	}
}
