using Femur;
using GB.Gamemodes;
using GB.Utils;
using UnityEngine;

namespace GB.Game
{
	public class KillVolume : MonoBehaviour
	{
		private enum ControlledTypes
		{
			Animation = 1,
			AI = 2,
			Human = 4
		}

		[SerializeField]
		private bool _despawn;

		[EnumUtils.EnumFlags]
		[SerializeField]
		private GameModeEnum _neededMode;

		[SerializeField]
		private int _gangID;

		[EnumUtils.EnumFlags]
		[SerializeField]
		private ControlledTypes _neededController;

		[SerializeField]
		private Actor.DeathType _deathType;

		[SerializeField]
		private bool _killInvulnerable;

		[SerializeField]
		private bool _killImmortal;

		public bool Despawn => false;

		public Actor.DeathType DeathType => default(Actor.DeathType);

		public bool CanKillImmortal => false;

		public bool CanKill(Actor checking)
		{
			return false;
		}

		public virtual void ExtraEffect(Actor actor)
		{
		}
	}
}
