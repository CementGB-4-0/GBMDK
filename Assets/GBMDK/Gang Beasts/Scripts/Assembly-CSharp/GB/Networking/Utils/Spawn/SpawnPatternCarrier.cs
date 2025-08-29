using System;
using System.Collections.Generic;
using GB.Gamemodes;
using GB.Utils;
using UnityEngine;

namespace GB.Networking.Utils.Spawn
{
	[CreateAssetMenu(fileName = "SpawnPattern", menuName = "Gang Beasts/Data/Game/Spawn Pattern", order = 1)]
	public class SpawnPatternCarrier : ScriptableObject
	{
		[Serializable]
		public class Pattern
		{
			[SerializeField]
			[Tooltip("Needed gamemode")]
			[EnumUtils.EnumFlags]
			public GameModeEnum Mode;

			[SerializeField]
			[Tooltip("Needed Min Gangs")]
			public int MinGangs;

			[SerializeField]
			[Tooltip("Needed Max Gangs")]
			public int MaxGangs;

			[SerializeField]
			public List<int> SpawnOptions;
		}

		[SerializeField]
		private List<Pattern> _options;

		public Pattern FindActivePattern()
		{
			return null;
		}

		public Pattern[] FindPatterns(GameModeEnum mode, int gangs)
		{
			return null;
		}
	}
}
