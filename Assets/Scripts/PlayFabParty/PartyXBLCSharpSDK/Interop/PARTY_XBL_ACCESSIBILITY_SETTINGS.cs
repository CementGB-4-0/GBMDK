using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PartyCSharpSDK;

namespace PartyXBLCSharpSDK.Interop
{
	internal struct PARTY_XBL_ACCESSIBILITY_SETTINGS
	{
		[StructLayout(LayoutKind.Sequential, Size = 85)]
		[UnsafeValueType]
		[CompilerGenerated]
		public struct _003ClanguageCode_003Ee__FixedBuffer
		{
			public byte FixedElementField;
		}

		internal readonly byte speechToTextEnabled;

		internal readonly byte textToSpeechEnabled;

		private unsafe fixed byte languageCode[85];

		internal readonly PARTY_GENDER gender;

		internal string GetLanguageCode()
		{
			return null;
		}

		internal PARTY_XBL_ACCESSIBILITY_SETTINGS(PartyXBLCSharpSDK.PARTY_XBL_ACCESSIBILITY_SETTINGS publicObject)
		{
			speechToTextEnabled = 0;
			textToSpeechEnabled = 0;
			gender = default(PARTY_GENDER);
		}
	}
}
