using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.Core.Loading
{
	public class LoadingScreenArchive : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		public class MapImageLinker
		{
			public Texture[] basicImage;

			public SortedDictionary<string, Texture[]> modeSpecial;

			public Texture GetRandomImage(string gamemode)
			{
				return null;
			}
		}

		[Serializable]
		public class Hint
		{
			public int probablility;

			public string key;

			public Texture mainImage;

			public LoadScreenLayoutManager layoutStyle;

			public string[] textKeys;

			public Texture[] images;

			public Hint()
			{
			}

			public Hint(Hint copy)
			{
			}

			public void Copy(Hint copy)
			{
			}
		}

		[Serializable]
		public class HintLinker
		{
			private int _probablility;

			private int _totalProbablilities;

			public List<Hint> hints;

			public List<Hint> vrhints;

			public List<Hint> nonevrhints;

			public int Probablility
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int TotalProbablilities => 0;

			public void ResetTotalProbablilities()
			{
			}

			public Hint GetRandomHint()
			{
				return null;
			}
		}

		[Serializable]
		public class HintArchive
		{
			public HintLinker hints;

			public SortedDictionary<string, HintLinker> gameModeHints;

			public SortedDictionary<string, HintLinker> mapHints;

			public HintLinker[] platform;

			public Hint GetHint(string level, string gameMode)
			{
				return null;
			}
		}

		[Serializable]
		private class ManuallySerializedData
		{
			[Serializable]
			public class ImageCarrier
			{
				public string key;

				public Texture[] value;
			}

			public string[] mapDictionaryKeys;

			public MapImageLinker[] mapDictionaryData;

			public int[] mapmodecounter;

			public ImageCarrier[] mapmodeDictionaryData;

			public string[] hintmodeDictionaryKeys;

			public HintLinker[] hintmodeDictionaryData;

			public string[] hintmapDictionaryKeys;

			public HintLinker[] hintmapDictionaryData;
		}

		public SortedDictionary<string, MapImageLinker> mapUniqueBackgrounds;

		[SerializeField]
		public Texture[] fallbackBackgrounds;

		public Color[] fallbackBackgroundColours;

		[SerializeField]
		public HintArchive hintArchive;

		[SerializeField]
		[HideInInspector]
		private ManuallySerializedData _derializedData;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
