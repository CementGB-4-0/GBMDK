using System.Collections.Generic;
using Femur;
using GB.Utils;
using UnityEngine;

namespace GB.Game.Objective
{
	public class ObjectivePartInAreaSafe : ObjectivePartInArea
	{
		protected List<Actor> _awarded;

		[SerializeField]
		[EnumUtils.EnumFlags]
		private Actor.ActorState _neededState;

		[EnumUtils.EnumFlags]
		[SerializeField]
		private Actor.ActorState _notStates;

		protected override bool OnActorEntered(Actor actor)
		{
			return false;
		}

		protected override bool OnActorExited(Actor actor)
		{
			return false;
		}

		protected bool CheckAward(Actor actor)
		{
			return false;
		}

		private void Update()
		{
		}
	}
}
