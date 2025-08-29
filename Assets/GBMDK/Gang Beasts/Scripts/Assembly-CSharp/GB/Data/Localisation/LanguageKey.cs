using System;
using UnityEngine.Localization;
using UnityEngine.Localization.Metadata;

namespace GB.Data.Localisation
{
	[Serializable]
	[Metadata(AllowedTypes = MetadataType.StringTable)]
	[DisplayName("Language Key", null)]
	public class LanguageKey : IMetadata
	{
		public string name;
	}
}
