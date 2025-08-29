using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.AI
{
	public class BeastDirector : MonoBehaviour, IActorOnTriggerEvent
	{
		[CompilerGenerated]
		private sealed class _003CStartAIObjectives_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BeastDirector _003C_003E4__this;

			public Actor actor;

			private int _003Ci_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStartAIObjectives_003Ed__8(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private bool _doOnSpawn;

		[SerializeField]
		private OnActorEventBase _onCompleteEventTrigger;

		[Tooltip("AI behaviours added will be executed in the order provided")]
		[SerializeField]
		private List<AIBehaviourBase> _aiObjectivesQueue;

		private Coroutine _aiObjectivesCoroutine;

		private bool currentobjectiveComplete;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void StartBeastDirecting(Actor newActor)
		{
		}

		[IteratorStateMachine(typeof(_003CStartAIObjectives_003Ed__8))]
		private IEnumerator StartAIObjectives(Actor actor)
		{
			return null;
		}

		private void CheckObjectiveComplete(Actor actor)
		{
		}

		public void Event(Actor actor)
		{
		}
	}
}
