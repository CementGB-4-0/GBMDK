using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class StringMessage : MessageBase
	{
		public string value;

		public StringMessage()
		{
		}

		public StringMessage(string v)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
