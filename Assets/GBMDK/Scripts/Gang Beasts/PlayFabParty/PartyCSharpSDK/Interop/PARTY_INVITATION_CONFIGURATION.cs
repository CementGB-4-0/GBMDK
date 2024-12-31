using System;

namespace PartyCSharpSDK.Interop
{
	internal struct PARTY_INVITATION_CONFIGURATION
	{
		internal readonly UTF8StringPtr identifier;

		internal readonly PARTY_INVITATION_REVOCABILITY revocability;

		internal readonly uint entityIdCount;

		private unsafe readonly UTF8StringPtr* entityIds;

		internal T[] GetEntityIds<T>(Func<UTF8StringPtr, T> ctor)
		{
			return null;
		}
	}
}
